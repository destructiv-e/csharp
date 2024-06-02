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
               
                return IsNumberBeforeCurrentPosition(input) && IsNumberAfterLastParenthesis(input);
            }
            else if (input.Contains("."))
            {
                
                int lastDotIndex = input.LastIndexOf('.');
                return IsOperatorAfterDot(input, lastDotIndex);
            }
            return false; 
        }

        private bool IsNumberAfterLastParenthesis(string input)
        {
            int lastOpenParenthesisIndex = input.LastIndexOf('(');
            int lastCloseParenthesisIndex = input.LastIndexOf(')');
            
            if (lastCloseParenthesisIndex != -1 && lastCloseParenthesisIndex < input.Length - 1)
            {
                for (int i = lastCloseParenthesisIndex + 1; i < input.Length; i++)
                {
                    if ("0123456789".Contains(input[i]))
                    {
                        return true;
                    }
                    if ("+-*/(".Contains(input[i]))
                    {
                        return false;
                    }
                }
                return false; 
            }
            return true; 
        }

private bool IsOperatorAfterDot(string input, int dotIndex)
{
    for (int i = dotIndex + 1; i < input.Length; i++)
    {
        if ("+-*/()".Contains(input[i]))
        {
            
            for (int j = i + 1; j < input.Length; j++)
            {
                if ("0123456789".Contains(input[j]))
                {
                    return true;
                }
                if (input[j] == '.')
                {
                    return false; 
                }
                if ("+-*/()".Contains(input[j]))
                {
                    if (i + 1 == j && "()".Contains(input[j]))
                    {
                        return false; 
                    }
                    return false; 
                }
            }
            return false;
        }
        if (input[i] == '.')
        {
            return false; 
        }
    }
    return false; 
}

private bool IsNumberBeforeCurrentPosition(string input)
{
    for (int i = input.Length - 1; i >= 0; i--)
    {
        if ("0123456789".Contains(input[i]))
        {
            return true; 
        }
        if ("+-*/()".Contains(input[i]))
        {
            return false; 
        }
    }
    return false; 
}

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0) {
                textBox_input.Text = textBox_input.Text.Remove(textBox_input.Text.Length - 1);
            }
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            if (CanPlaceOperatorAfterDot())
            {
                textBox_input.Text += @"+";
            }
        }

        private void button_right_parenthesis_Click(object sender, EventArgs e)
        {
            if (CanPlaceParenthesisAfterDot() && !IsFirstCharacter())
            {
                textBox_input.Text += @")";
            }
        }

        private bool IsFirstCharacter()
        {
            if (textBox_input.Text.Length == 0)
            {
                return true;
            }
            return false;
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
                for (int i = lastDotIndex + 1; i < textBox_input.Text.Length; i++)
                {
                    if ("0123456789(".Contains(textBox_input.Text[i]))
                    {
                        return true;
                    }
                    if ("+-*/)".Contains(textBox_input.Text[i]))
                    {
                        return false;
                    }
                }
                return false; 
            }
            return true; 
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
            if (CanPlaceOperatorAfterDot())
            {
                textBox_input.Text += @"-";
            }
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            if (CanPlaceMulAsFirstOperator() && CanPlaceOperatorAfterDot() && CanPlaceMulAfterCurrentOperator())
            {
                textBox_input.Text += @"*";
            }
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if (CanPlaceDivAsFirstOperator() && CanPlaceOperatorAfterDot() && CanPlaceDivAfterCurrentOperator())
            {
                textBox_input.Text += @"/";
            }
        }
        
        private bool CanPlaceMulAsFirstOperator()
        {
            if (textBox_input.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private bool CanPlaceDivAsFirstOperator()
        {
            if (textBox_input.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private bool CanPlaceMulAfterCurrentOperator()
        {
            if (textBox_input.Text.Length > 0)
            {
                char lastChar = textBox_input.Text[textBox_input.Text.Length - 1];
                if ("+-*/".Contains(lastChar))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CanPlaceDivAfterCurrentOperator()
        {
            if (textBox_input.Text.Length > 0)
            {
                char lastChar = textBox_input.Text[textBox_input.Text.Length - 1];
                if ("+-*/".Contains(lastChar))
                {
                    return false;
                }
            }
            return true;
        }
        
        private bool CanPlaceOperatorAfterDot()
        {
            int lastDotIndex = textBox_input.Text.LastIndexOf('.');
            if (lastDotIndex != -1)
            {
                
                for (int i = lastDotIndex + 1; i < textBox_input.Text.Length; i++)
                {
                    if ("0123456789(".Contains(textBox_input.Text[i]))
                    {
                        return true;
                    }
                    if ("+-*/)".Contains(textBox_input.Text[i]))
                    {
                        return false;
                    }
                }
                return false; 
            }
            return true; 
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
      char c = e.KeyChar;

    // Handle backspace
    if (c == '\b')
    {
        if (textBox_input.Text.Length > 0)
        {
            textBox_input.Text = textBox_input.Text.Remove(textBox_input.Text.Length - 1);
        }
        e.Handled = true; // Ensure that the event is handled and not passed further
        return;
    }

    // Handle Enter key
    if (c == '\r')
    {
        this.button_equals_Click(sender, EventArgs.Empty);
        e.Handled = true; // Ensure that the event is handled and not passed further
        return;
    }

    // Handle valid characters
    if (checking_for_the_validity_of_the_input(c))
    {
        if (char.IsDigit(c))
        {
            textBox_input.Text += c;
        }
        else if (c == '.')
        {
            if (CanPlaceDot(textBox_input.Text))
            {
                textBox_input.Text += c;
            }
        }
        else if ("+-*/()".Contains(c))
        {
            if (CanPlaceOperatorOrParenthesisAfterDot(c))
            {
                // Allow ( + - at the beginning of the line
                if (textBox_input.Text.Length == 0 && (c == '(' || c == '+' || c == '-'))
                {
                    textBox_input.Text += c;
                }
                else if (textBox_input.Text.Length > 0)
                {
                    char lastChar = textBox_input.Text[textBox_input.Text.Length - 1];
                    if ("+-".Contains(lastChar) && (c == '*' || c == '/')) // Prevent * and / after + or -
                    {
                        e.Handled = true;
                        return;
                    }
                    textBox_input.Text += c;
                }
            }
        }
        else if (c == '=') // New handling for the equals sign
        {
            if (textBox_input.Text.Length > 0)
            {
                this.button_equals_Click(sender, EventArgs.Empty);
            }
            e.Handled = true;
            return;
        }
        e.Handled = true; // Ensure that the event is handled and not passed further
        return;
    }

    // If the character is not valid, handle it
    e.Handled = true;
}

private bool CanPlaceOperatorOrParenthesisAfterDot(char c)
{
    int lastDotIndex = textBox_input.Text.LastIndexOf('.');
    if (lastDotIndex != -1)
    {
        for (int i = lastDotIndex + 1; i < textBox_input.Text.Length; i++)
        {
            if ("0123456789(".Contains(textBox_input.Text[i]))
            {
                return true;
            }
            if ("+-*/)".Contains(textBox_input.Text[i]))
            {
                return false;
            }
        }
        return false;
    }
    return true;
}
    }
}