using System.Windows.Forms;

namespace CalculatorTaskSecond
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_three = new RoundButton();
            this.button_four = new RoundButton();
            this.button_left_parenthesis = new RoundButton();
            this.button_right_parenthesis = new RoundButton();
            this.button_equals = new RoundButton();
            this.button_sum = new RoundButton();
            this.button_dot = new RoundButton();
            this.button_zero = new RoundButton();
            this.button_minus = new RoundButton();
            this.button_one = new RoundButton();
            this.button_two = new RoundButton();
            this.button_six = new RoundButton();
            this.button_mul = new RoundButton();
            this.button_division = new RoundButton();
            this.button_delete = new RoundButton();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_five = new RoundButton();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_three
            // 
            this.button_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_three.BackColor2 = System.Drawing.Color.Silver;
            this.button_three.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_three.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_three.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_three.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_three.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_three.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_three.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_three.ButtonRoundRadius = 30;
            this.button_three.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_three.ForeColor = System.Drawing.SystemColors.Control;
            this.button_three.Location = new System.Drawing.Point(0, 276);
            this.button_three.Margin = new System.Windows.Forms.Padding(0);
            this.button_three.Name = "button_three";
            this.button_three.Size = new System.Drawing.Size(192, 87);
            this.button_three.TabIndex = 3;
            this.button_three.Text = "3";
            this.button_three.Click += new System.EventHandler(this.button_three_Click);
            // 
            // button_four
            // 
            this.button_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_four.BackColor2 = System.Drawing.Color.Silver;
            this.button_four.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_four.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_four.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_four.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_four.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_four.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_four.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_four.ButtonRoundRadius = 30;
            this.button_four.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_four.ForeColor = System.Drawing.SystemColors.Control;
            this.button_four.Location = new System.Drawing.Point(192, 276);
            this.button_four.Name = "button_four";
            this.button_four.Size = new System.Drawing.Size(192, 87);
            this.button_four.TabIndex = 2;
            this.button_four.Text = "4";
            this.button_four.Click += new System.EventHandler(this.button_four_Click);
            // 
            // button_left_parenthesis
            // 
            this.button_left_parenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_left_parenthesis.BackColor2 = System.Drawing.Color.Silver;
            this.button_left_parenthesis.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_left_parenthesis.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_left_parenthesis.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_left_parenthesis.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_left_parenthesis.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_left_parenthesis.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_left_parenthesis.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_left_parenthesis.ButtonRoundRadius = 30;
            this.button_left_parenthesis.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left_parenthesis.ForeColor = System.Drawing.SystemColors.Control;
            this.button_left_parenthesis.Location = new System.Drawing.Point(0, 544);
            this.button_left_parenthesis.Name = "button_left_parenthesis";
            this.button_left_parenthesis.Size = new System.Drawing.Size(99, 87);
            this.button_left_parenthesis.TabIndex = 5;
            this.button_left_parenthesis.Text = "(";
            this.button_left_parenthesis.Click += new System.EventHandler(this.button_left_parenthesis_Click);
            // 
            // button_right_parenthesis
            // 
            this.button_right_parenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_right_parenthesis.BackColor2 = System.Drawing.Color.Silver;
            this.button_right_parenthesis.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_right_parenthesis.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_right_parenthesis.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_right_parenthesis.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_right_parenthesis.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_right_parenthesis.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_right_parenthesis.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_right_parenthesis.ButtonRoundRadius = 30;
            this.button_right_parenthesis.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right_parenthesis.ForeColor = System.Drawing.SystemColors.Control;
            this.button_right_parenthesis.Location = new System.Drawing.Point(98, 544);
            this.button_right_parenthesis.Name = "button_right_parenthesis";
            this.button_right_parenthesis.Size = new System.Drawing.Size(97, 87);
            this.button_right_parenthesis.TabIndex = 6;
            this.button_right_parenthesis.Text = ")";
            this.button_right_parenthesis.Click += new System.EventHandler(this.button_right_parenthesis_Click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_equals.BackColor2 = System.Drawing.Color.Silver;
            this.button_equals.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_equals.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_equals.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_equals.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_equals.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_equals.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_equals.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_equals.ButtonRoundRadius = 30;
            this.button_equals.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equals.ForeColor = System.Drawing.SystemColors.Control;
            this.button_equals.Location = new System.Drawing.Point(195, 544);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(186, 87);
            this.button_equals.TabIndex = 7;
            this.button_equals.Text = "=";
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_sum
            // 
            this.button_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_sum.BackColor2 = System.Drawing.Color.Silver;
            this.button_sum.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_sum.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_sum.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_sum.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_sum.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_sum.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_sum.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_sum.ButtonRoundRadius = 30;
            this.button_sum.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sum.ForeColor = System.Drawing.SystemColors.Control;
            this.button_sum.Location = new System.Drawing.Point(381, 544);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(93, 87);
            this.button_sum.TabIndex = 8;
            this.button_sum.Text = "+";
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_dot.BackColor2 = System.Drawing.Color.Silver;
            this.button_dot.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_dot.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_dot.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_dot.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_dot.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_dot.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_dot.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_dot.ButtonRoundRadius = 30;
            this.button_dot.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.ForeColor = System.Drawing.SystemColors.Control;
            this.button_dot.Location = new System.Drawing.Point(0, 454);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(192, 87);
            this.button_dot.TabIndex = 9;
            this.button_dot.Text = ".";
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_zero
            // 
            this.button_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_zero.BackColor2 = System.Drawing.Color.Silver;
            this.button_zero.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_zero.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_zero.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_zero.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_zero.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_zero.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_zero.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_zero.ButtonRoundRadius = 30;
            this.button_zero.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_zero.ForeColor = System.Drawing.SystemColors.Control;
            this.button_zero.Location = new System.Drawing.Point(192, 454);
            this.button_zero.Name = "button_zero";
            this.button_zero.Size = new System.Drawing.Size(192, 87);
            this.button_zero.TabIndex = 10;
            this.button_zero.Text = "0";
            this.button_zero.Click += new System.EventHandler(this.button_zero_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_minus.BackColor2 = System.Drawing.Color.Silver;
            this.button_minus.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_minus.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_minus.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_minus.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_minus.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_minus.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_minus.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_minus.ButtonRoundRadius = 30;
            this.button_minus.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.ForeColor = System.Drawing.SystemColors.Control;
            this.button_minus.Location = new System.Drawing.Point(384, 454);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(90, 87);
            this.button_minus.TabIndex = 11;
            this.button_minus.Text = "−";
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_one
            // 
            this.button_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_one.BackColor2 = System.Drawing.Color.Silver;
            this.button_one.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_one.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_one.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_one.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_one.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_one.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_one.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_one.ButtonRoundRadius = 30;
            this.button_one.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_one.ForeColor = System.Drawing.SystemColors.Control;
            this.button_one.Location = new System.Drawing.Point(0, 364);
            this.button_one.Margin = new System.Windows.Forms.Padding(0);
            this.button_one.Name = "button_one";
            this.button_one.Size = new System.Drawing.Size(192, 87);
            this.button_one.TabIndex = 12;
            this.button_one.Text = "1";
            this.button_one.Click += new System.EventHandler(this.button_one_Click);
            // 
            // button_two
            // 
            this.button_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_two.BackColor2 = System.Drawing.Color.Silver;
            this.button_two.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_two.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_two.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_two.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_two.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_two.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_two.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_two.ButtonRoundRadius = 30;
            this.button_two.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_two.ForeColor = System.Drawing.SystemColors.Control;
            this.button_two.Location = new System.Drawing.Point(192, 364);
            this.button_two.Margin = new System.Windows.Forms.Padding(0);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(192, 87);
            this.button_two.TabIndex = 13;
            this.button_two.Text = "2";
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            // 
            // button_six
            // 
            this.button_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_six.BackColor2 = System.Drawing.Color.Silver;
            this.button_six.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_six.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_six.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_six.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_six.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_six.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_six.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_six.ButtonRoundRadius = 30;
            this.button_six.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_six.ForeColor = System.Drawing.SystemColors.Control;
            this.button_six.Location = new System.Drawing.Point(192, 186);
            this.button_six.Margin = new System.Windows.Forms.Padding(0);
            this.button_six.Name = "button_six";
            this.button_six.Size = new System.Drawing.Size(192, 87);
            this.button_six.TabIndex = 14;
            this.button_six.Text = "6";
            this.button_six.Click += new System.EventHandler(this.button_six_Click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_mul.BackColor2 = System.Drawing.Color.Silver;
            this.button_mul.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_mul.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_mul.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_mul.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_mul.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_mul.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_mul.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_mul.ButtonRoundRadius = 30;
            this.button_mul.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.ForeColor = System.Drawing.SystemColors.Control;
            this.button_mul.Location = new System.Drawing.Point(384, 364);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(90, 87);
            this.button_mul.TabIndex = 15;
            this.button_mul.Text = "×";
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_division.BackColor2 = System.Drawing.Color.Silver;
            this.button_division.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_division.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_division.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_division.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_division.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_division.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_division.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_division.ButtonRoundRadius = 30;
            this.button_division.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_division.ForeColor = System.Drawing.SystemColors.Control;
            this.button_division.Location = new System.Drawing.Point(384, 276);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(90, 87);
            this.button_division.TabIndex = 16;
            this.button_division.Text = "÷";
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_delete.BackColor2 = System.Drawing.Color.Silver;
            this.button_delete.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_delete.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_delete.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_delete.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_delete.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_delete.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_delete.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_delete.ButtonRoundRadius = 30;
            this.button_delete.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_delete.Location = new System.Drawing.Point(384, 186);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(90, 87);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "⌦";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_input.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_input.Location = new System.Drawing.Point(0, 0);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(475, 80);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // button_five
            // 
            this.button_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.button_five.BackColor2 = System.Drawing.Color.Silver;
            this.button_five.ButtonBorderColor = System.Drawing.Color.Black;
            this.button_five.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.button_five.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_five.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_five.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_five.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_five.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_five.ButtonRoundRadius = 30;
            this.button_five.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_five.ForeColor = System.Drawing.SystemColors.Control;
            this.button_five.Location = new System.Drawing.Point(0, 186);
            this.button_five.Margin = new System.Windows.Forms.Padding(0);
            this.button_five.Name = "button_five";
            this.button_five.Size = new System.Drawing.Size(192, 87);
            this.button_five.TabIndex = 19;
            this.button_five.Text = "5";
            this.button_five.Click += new System.EventHandler(this.button_five_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBox_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_output.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_output.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_output.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_output.Location = new System.Drawing.Point(0, 80);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.Size = new System.Drawing.Size(475, 80);
            this.textBox_output.TabIndex = 0;
            this.textBox_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(475, 633);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.button_five);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_six);
            this.Controls.Add(this.button_two);
            this.Controls.Add(this.button_one);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_four);
            this.Controls.Add(this.button_three);
            this.Controls.Add(this.button_zero);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_sum);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_right_parenthesis);
            this.Controls.Add(this.button_left_parenthesis);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_output;

        private RoundButton button_five;

        private System.Windows.Forms.TextBox textBox_input;

        private RoundButton button_one;
        private RoundButton button_two;
        private RoundButton button_mul;
        private RoundButton button_division;
        private RoundButton button_delete;

        private RoundButton button_dot;
        private RoundButton button_zero;
        private RoundButton button_minus;

        private RoundButton button_three;
        private RoundButton button_left_parenthesis;
        private RoundButton button_right_parenthesis;
        private RoundButton button_equals;
        private RoundButton button_sum;

        private RoundButton button_six;
        private RoundButton button_four;

        #endregion
    }
}