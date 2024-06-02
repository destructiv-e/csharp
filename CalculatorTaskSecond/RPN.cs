using System;
using System.Collections.Generic;

namespace CustomCalc {
    class RPN {
        int initSize = 32;
        public List<Object> list;
        public Stack<char> ops;
        int dvd = 7; // For septenary system
        int lb = 47;
        int rb = 55; // For septenary system
        ulong ns = 7; // For septenary system

        public RPN() {
            this.list = new List<Object>(initSize);
            this.ops = new Stack<char>(initSize);
        }

        public int op_priority(char op) {
            switch (op) {
                case '(': return 1;
                case '+': return 2;
                case '-': return 2;
                case '*': return 3;
                case '/': return 3;
                case ')': return 5;
                default: return -1;
            }
        }

       public void getInput(char[] input) {
    // Проверка, если первый символ - минус, добавляем 0 перед ним
    if (input[0] == '-') {
        Array.Resize(ref input, input.Length + 1);
        for (int i = input.Length - 1; i > 0; i--) {
            input[i] = input[i - 1];
        }
        input[0] = '0';
    }

    char[] number = new char[initSize / 2];
    char prev = ' ';
    int numInd = 0;
    bool isPositive = true;
    bool isPt = false;
    int openBr = 0;
    for (int i = 0; i < input.Length; ++i) {
        char cur = input[i];
        if (char.IsDigit(cur) || cur == '.') {
            if ((this.list.Count > 0 && (prev == '+' || prev == '-')) || prev == '(') {
                addOp('+');
            }
            if (prev != ')') {
                while (char.IsDigit(cur) || cur == '.') {
                    if (numInd == number.Length) {
                        Array.Resize<char>(ref number, number.Length * 2);
                    }
                    number[numInd++] = cur;
                    if (++i == input.Length) {
                        break;
                    }
                    cur = input[i];
                }
                --i;
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Mistake in index: " + (i + 1));
            }
        } else if (cur == '.') {
            if ((char.IsDigit(prev) || prev == '+' || prev == '-' || prev == '*' || prev == '/' || prev == '(') && !isPt) {
                number[numInd++] = '.';
                isPt = true;
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Mistake in index: " + (i + 1));
            }
        } else {
            Array.Resize(ref number, numInd);
            if (number.Length > 0) {
                if (!isPositive) {
                    Array.Resize(ref number, numInd + 1);
                    number[numInd] = '-';
                }
                this.list.Add(number);
                isPositive = true;
            }
            number = new char[initSize / 2];
            numInd = 0;
            isPt = false;
            if (cur == '+' || cur == '-') {
                if (prev == '*' || prev == '/') {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Mistake in index: " + (i + 1));
                }
                bool seenOperator = false;
                while (cur == '+' || cur == '-') {
                    if (cur == '-') {
                        isPositive = !isPositive;
                    }
                    seenOperator = true;
                    if (++i == input.Length) {
                        break;
                    }
                    cur = input[i];
                }
                --i;
                if (!seenOperator) {
                    addOp('+');
                }

            } else if (cur == '*') {
                if (prev == ')' || prev == '.' || char.IsDigit(prev)) {
                    addOp('*');
                } else {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Mistake in index: " + (i + 1));
                }
            } else if (cur == '/') {
                if (prev == ')' || prev == '.' || char.IsDigit(prev)) {
                    addOp('/');
                } else {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Mistake in index: " + (i + 1));
                }
            } else if (cur == '(') {
                if (prev == '+' || prev == '-' || prev == '*' || prev == '/' || prev == '(' || prev == ')' || prev == ' ') {
                    if (prev == '+' || prev == '-') {
                        if (isPositive) {
                            addOp('+');
                        } else {
                            addOp('-');
                        }
                        isPositive = true;
                    }
                    this.ops.Push('(');
                    openBr++;
                    if (prev != '(') {
                        char[] temp = new char[1];
                        temp[0] = '0';
                        this.list.Add(temp);
                    }
                } else {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Mistake in index: " + (i + 1));
                }
            } else if (cur == ')') {
                if ((char.IsDigit(prev) || prev == '.' || prev == ')') && openBr > 0) {
                    openBr--;
                    addOp(')');
                } else {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Mistake in index: " + (i + 1));
                }
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Mistake in index: " + (i + 1));
            }
        }
        prev = input[i];
    }
    if (openBr > 0) {
        this.list.Clear();
        this.ops.Clear();
        throw new Exception("Close parenthesis!!");
    }
    Array.Resize(ref number, numInd);
    if (number.Length > 0) {
        if (!isPositive) {
            Array.Resize(ref number, numInd + 1);
            number[numInd] = '-';
        }
        this.list.Add(number);
    }
    addOp('+');
}
        
        private void addOp(char op) {
            char lastOp;
            if (this.ops.Count == 0) {
                this.ops.Push(op);
                return;
            }
            lastOp = this.ops.Peek();
            if (op_priority(op) > op_priority(lastOp)) {
                if (op == ')') {
                    while (lastOp != '(') {
                        this.list.Add(lastOp);
                        this.ops.Pop();
                        if (this.ops.Count == 0) {
                            break;
                        }
                        lastOp = this.ops.Peek();
                    }
                    this.ops.Pop();
                } else {
                    this.ops.Push(op);
                }
                return;
            }
            this.list.Add(lastOp);
            this.ops.Pop();
            if (this.ops.Count == 0) {
                this.ops.Push(op);
                return;
            }

            lastOp = this.ops.Peek();
            while (op_priority(op) <= op_priority(lastOp)) {
                this.list.Add(lastOp);
                this.ops.Pop();
                if (this.ops.Count == 0) {
                    break;
                }
                lastOp = this.ops.Peek();
            }
            this.ops.Push(op);
            return;
        }

        public double getNum(char[] number, bool isPositive) {
            double res = 0;
            int i = 0;
            while (i < number.Length && number[i] != '.') {
                res += (number[i++] - '0');
                res *= dvd;
            }
            res /= dvd;
            ++i;
            double mnts = 0;
            double m = 10;
            while (i < number.Length) {
                mnts += (number[i++] - '0') / m;
                m *= dvd;
            }
            res = isPositive ? res + mnts : -(res + mnts);
            return res;
        }

        public char[] countExpression() {
    if (this.list.Count == 0) {
        this.list.Clear();
        this.ops.Clear();
        throw new Exception("No numbers provided");
    }

    // Проверка, что в списке операций есть хотя бы одно число
    bool hasNumbers = false;
    foreach (var item in this.list) {
        if (item is char[] && ((char[])item).Length > 0) {
            hasNumbers = true;
            break;
        }
    }

    if (!hasNumbers) {
        this.list.Clear();
        this.ops.Clear();
        throw new Exception("No numbers provided");
    }

    Object[] syms = this.list.ToArray();
    Stack<Double> nums = new Stack<double>(this.list.Count);
    double eps = 0.004115226337;
    for (int i = 0; i < syms.Length; ++i) {
        double n1 = 0, n2 = 0;
        if (syms[i].Equals('+')) {
            if (nums.Count >= 2) {
                n2 = nums.Pop();
                n1 = nums.Pop();
                double temp = n1 + n2;
                nums.Push(temp);
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Too many operators");
            }
        } else if (syms[i].Equals('-')) {
            if (nums.Count >= 2) {
                n2 = nums.Pop();
                n1 = nums.Pop();
                double temp = n1 - n2;
                nums.Push(temp);
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Too many operators");
            }
        } else if (syms[i].Equals('*')) {
            if (nums.Count >= 2) {
                n2 = nums.Pop();
                n1 = nums.Pop();
                double temp = n1 * n2;
                nums.Push(temp);
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Too many operators");
            }
        } else if (syms[i].Equals('/')) {
            if (nums.Count >= 2) {
                n2 = nums.Pop();
                n1 = nums.Pop();
                double temp = n1 / n2;
                if (Double.IsNaN(temp) || Double.IsInfinity(temp)) {
                    this.list.Clear();
                    this.ops.Clear();
                    throw new Exception("Division by zero");
                }
                nums.Push(temp);
            } else {
                this.list.Clear();
                this.ops.Clear();
                throw new Exception("Too many operators");
            }
        } else {
            nums.Push(convertDNSToDec((char[])syms[i], ns));
        }
    }
    if (nums.Count != 1) {
        this.list.Clear();
        this.ops.Clear();
        throw new Exception("Invalid expression");
    }
    double res = nums.Pop();
    this.list.Clear();
    this.ops.Clear();
    nums.Clear();
    return convertDecToDNS(res, ns);
}


        public char[] convertDecToDNS(double num, ulong ns) {
            double eps = 0.004115226337;
            if (Math.Abs(num) < eps) {
                char[] r = new char[1];
                r[0] = '0';
                return r;
            }
            char[] intPart = new char[initSize];
            char[] fracPart = new char[5];
            int i = 0;
            ulong intp;
            double fracp;
            if (num > 0) {
                intp = (ulong)Math.Truncate(num);
                fracp = num - intp;
            } else {
                intp = (ulong)Math.Truncate(-num);
                fracp = -(num + intp);
            }
            if (Math.Abs(1 - fracp) < eps) {
                ++intp;
                fracp = 0;
            }
            while (intp > 0) {
                ulong n = intp % ns;
                intPart[i++] = (char)((n < 10 ? n : n + 55) + '0');
                intp /= ns;
            }
            Array.Resize<char>(ref intPart, i);
            Array.Reverse(intPart);
            i = 0;
            if (fracp > eps) {
                fracPart[i++] = '.';
                for (; i < 5; ++i) {
                    fracp *= ns;
                    ulong digit = (ulong)Math.Floor(fracp);
                    fracPart[i] = (char)((digit < 10 ? digit : digit + 55) + '0');
                    fracp -= digit;
                }
            }
            int k;
            for (k = 4; k >= 0; --k) {
                if (fracPart[k] == '0');
                else break;
            }
            char[] res = new char[intPart.Length + k + 2];
            if (num < 0) {
                res[0] = '-';
            }
            i = 1;
            while (i < intPart.Length + 1) {
                res[i] = intPart[i - 1];
                ++i;
            }
            if (fracp > eps) {
                res[i++] = '.';
                while (i < res.Length) {
                    res[i] = fracPart[i - intPart.Length - 1];
                    ++i;
                }
            }
            if (res[0] != '-') {
                Array.Copy(res, 1, res, 0, res.Length - 1);
                Array.Resize(ref res, res.Length - 1);
            }
            return res;
        }

        public double convertDNSToDec(char[] num, ulong ns) {
            double res = 0;
            int k = 0;
            while (num[k] != '.') {
                if (++k == num.Length) {
                    if (num[k - 1] == '-') {
                        --k;
                    }
                    break;
                }
            }
            double m = Math.Pow(ns, k - 1);
            for (int i = 0; i < k; ++i) {
                res += (num[i] - '0') * m;
                m /= ns;
            }
            for (int i = k + 1; i < num.Length; ++i) {
                if (num[i] == '-') {
                    res *= -1;
                    break;
                }
                res += (num[i] - '0') * m;
                m /= ns;
            }
            if (k == num.Length - 1 && num[k] == '-') {
                res *= -1;
            }
            return res;
        }
    }
}
