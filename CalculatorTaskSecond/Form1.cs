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
            if (!textBox_input.Text.Contains("."))
            {
                textBox_input.Text += this.button_dot.Text;
            }
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
            textBox_input.Text += @")";
        }

        private void button_left_parenthesis_Click(object sender, EventArgs e)
        {
            textBox_input.Text += @"(";
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