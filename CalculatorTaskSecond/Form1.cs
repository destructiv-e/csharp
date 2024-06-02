using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomCalc;

namespace CalculatorTaskSecond
{
    public partial class Form1 : Form
    {
        RPN rpn;
        private readonly HashSet<char> _validChars = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '+', '-', '*', '/', '(', ')', '.' };

        
        public Form1()
        {
            InitializeComponent();
            this.rpn = new RPN();
            textBox_input.ShortcutsEnabled = true;
        }
        
       
        private bool checking_for_the_validity_of_the_input(char c) {
            return _validChars.Contains(c);
        }
        
        private void button_five_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_five.Text;
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_six.Text;
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_three.Text;
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_four.Text;
        }

        private void button_one_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_one.Text;
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_two.Text;
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            textBox_input.Text += this.button_zero.Text;
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (CanPlaceDot(textBox_input.Text))
            {
                textBox_input.Text += this.button_dot.Text;
            }
        }
        
  private bool CanPlaceDot(string input)
{
    if (input.Length > 0 && !input.Contains("."))
    {
        // Проверяем, что перед текущей позицией есть число
        return IsNumberBeforeCurrentPosition(input);
    }
    else if (input.Contains("."))
    {
        // Если точка уже есть, проверяем, что после неё есть оператор и до этого оператора нет другой точки
        int lastDotIndex = input.LastIndexOf('.');
        return IsOperatorAfterDot(input, lastDotIndex);
    }
    return false; // Точка не может быть добавлена в пустую строку или после точки, если до этого не было оператора
}

private bool IsOperatorAfterDot(string input, int dotIndex)
{
    for (int i = dotIndex + 1; i < input.Length; i++)
    {
        if ("+-*/()".Contains(input[i]))
        {
            // После оператора должно быть число
            for (int j = i + 1; j < input.Length; j++)
            {
                if ("0123456789".Contains(input[j]))
                {
                    return true;
                }
                if (input[j] == '.')
                {
                    return false; // Если нашли еще одну точку, возвращаем false
                }
                if ("+-*/()".Contains(input[j]))
                {
                    if (i + 1 == j && "()".Contains(input[j]))
                    {
                        return false; // Нельзя ставить скобки сразу после точки
                    }
                    return false; // Если после числа снова оператор, точку ставить нельзя
                }
            }
            return false; // Если до конца строки не нашли числа, возвращаем false
        }
        if (input[i] == '.')
        {
            return false; // Если нашли еще одну точку, возвращаем false
        }
    }
    return false; // Если до конца строки не нашли оператора, возвращаем false
}

private bool IsNumberBeforeCurrentPosition(string input)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if ("0123456789".Contains(input[i]))
        {
            return true; // Если последний символ - число, можно ставить точку
        }
        if ("+-*/()".Contains(input[i]))
        {
            return false; // Если последний символ - оператор, точку ставить нельзя
        }
    }
    return false; // Если строка пуста или содержит только операторы, точку ставить нельзя
}

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0) {
                textBox_input.Text = textBox_input.Text.Remove(textBox_input.Text.Length - 1);
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            textBox_input.Text += @"+";
        }

        private void button_right_parenthesis_Click(object sender, EventArgs e)
        {
            if (CanPlaceParenthesisAfterDot())
            {
                textBox_input.Text += @")";
            }
        }

        private void button_left_parenthesis_Click(object sender, EventArgs e)
        {
            if (CanPlaceParenthesisAfterDot())
            {
                textBox_input.Text += @"(";
            }
        }
        
        private bool CanPlaceParenthesisAfterDot()
        {
            int lastDotIndex = textBox_input.Text.LastIndexOf('.');
            if (lastDotIndex != -1)
            {
                // Проверяем, что после точки есть оператор или скобки уже есть
                for (int i = lastDotIndex + 1; i < textBox_input.Text.Length; i++)
                {
                    if ("+-*/".Contains(textBox_input.Text[i]))
                    {
                        return true;
                    }
                    if (textBox_input.Text[i] == '(' || textBox_input.Text[i] == ')')
                    {
                        return true;
                    }
                }
                return false;
            }
            return true; // Если точки нет, можно ставить скобки
        }


        private void button_equals_Click(object sender, EventArgs e)
        {
            Control inp = this.Controls["textBox_input"];
            try {
                rpn.getInput(inp.Text.ToCharArray());
                Control outp = this.Controls["textBox_output"];
                outp.Text = new string(rpn.countExpression());
            } catch (Exception ex) {
                textBox_output.Text = "";
                Control err = this.Controls["ErrorMsg"];
                err.Visible = true;
                err.Text = ex.Message;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            textBox_input.Text += @"-";
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            textBox_input.Text += @"*";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            textBox_input.Text += @"/";
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == '\b') {
                if (textBox_input.Text.Length > 0) {
                    textBox_input.Text.Remove(textBox_input.Text.Length - 1);
                }
                return;
            }
            else if (c == '\r') {
               // this.ErrorMsg.Visible = false;
                this.button_equals_Click(sender, e);
            }
            else if (checking_for_the_validity_of_the_input(c)) {
                return;
            }
            e.Handled = true;
        }
    }
}