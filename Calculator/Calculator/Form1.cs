using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1: Form
    {
        double value1;
        double value2;
        
        double result = 0;
        string sign;

        private object lebel1 = null;
        private object lebel2 = null; 

        
       


        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = " ";
            label2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + "( )";
            int openCount = textBox1.Text.Count(c => c == '(');
            int closeCount = textBox1.Text.Count(c => c == ')');

            if (openCount <= closeCount)
                textBox1.Text += "(";
            else
                textBox1.Text += ")";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
            try
            {
                string expr = textBox1.Text
                    .Replace("×", "*")
                    .Replace("÷", "/")
                    .Replace("%", "/100");

                textBox1.Text = new DataTable().Compute(expr, null).ToString();
            }
            catch
            {
                MessageBox.Show("Error in expression");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+/-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "+";
                label1.Text = textBox1.Text + "+";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input for the first value.");
            }


        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "-";
                label1.Text = textBox1.Text + "-";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input for the first value.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "*";
                label1.Text = textBox1.Text + "*";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input for the first value.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out value1))
            {
                sign = "/";
                label1.Text = textBox1.Text + "/";
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid input for the first value.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox1.Text, out value2))
            {
                MessageBox.Show("Invalid input for the second value.");
                return;
            }
            try
            {
                if (sign == "+")
                {
                    result = value1 + value2;
                    textBox1.Text = Convert.ToString(result);
                }
                else if (sign == "-")
                {
                    result = value1 - value2;
                    textBox1.Text = Convert.ToString(result);
                }
                else if (sign == "*")
                {
                    result = value1 * value2;
                    textBox1.Text = Convert.ToString(result);
                }
                else if (sign == "/")
                {
                    if (value2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = value1 / value2;
                    textBox1.Text = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
