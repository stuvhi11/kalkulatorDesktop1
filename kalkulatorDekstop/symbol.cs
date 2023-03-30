using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorDekstop
{
    public partial class symbol : Form
    {
        private decimal number1 = 0.0m;
        private decimal number2 = 0.0m;
        private decimal hasil = 0.0m;
        private string itung;
        public symbol()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "7";
            }
            else
            {
                num1.Text += "7";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "1";
            }
            else
            {
                num1.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "2";
            }
            else
            {
                num1.Text += "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "3";
            }
            else
            {
                num1.Text += "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "4";
            }
            else
            {
                num1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "5";
            }
            else
            {
                num1.Text += "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "6";
            }
            else
            {
                num1.Text += "6";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "7";
            }
            else
            {
                num1.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "8";
            }
            else
            {
                num1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "9";
            }
            else
            {
                num1.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (num1.Text == "0")
            {
                num1.Text = "0";
            }
            else
            {
                num1.Text += "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "+";
            }
            else
            {
                textBox2.Text += "+";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "-";
            }
            else
            {
                textBox2.Text += "-";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = ":";
            }
            else
            {
                textBox2.Text += ":";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "x";
            }
            else
            {
                textBox2.Text += "x";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "1";
            }
            else
            {
                num2.Text += "1";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "2";
            }
            else
            {
                num2.Text += "2";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "3";
            }
            else
            {
                num2.Text += "3";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "4";
            }
            else
            {
                num2.Text += "4";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "5";
            }
            else
            {
                num2.Text += "5";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "6";
            }
            else
            {
                num2.Text += "6";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "7";
            }
            else
            {
                num2.Text += "7";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "8";
            }
            else
            {
                num2.Text += "8";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "9";
            }
            else
            {
                num2.Text += "9";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (num2.Text == "0")
            {
                num2.Text = "0";
            }
            else
            {
                num2.Text += "0";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            number1 = decimal.Parse(num1.Text);
            number2 = decimal.Parse(num2.Text);
            itung = textBox2.Text;

            if (itung == "+")
            {
                hasil = number1 + number2;
                hitung.Text = hasil.ToString();
            }
            if (itung == "-")
            {
                hasil = number1 - number2;
                hitung.Text = hasil.ToString();
            }
            if (itung == "/" || itung == ":")
            {

                hasil = number1 / number2;
                hitung.Text = hasil.ToString();
            }
            if (itung == "*" || itung == "x")
            {
                hasil = number1 * number2;
                hitung.Text = hasil.ToString();
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (num1.Text.Length > 0)
            {
                num1.Text = num1.Text.Remove(num1.Text.Length - 1);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (num2.Text.Length > 0)
            {
                num2.Text = num2.Text.Remove(num2.Text.Length - 1);
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            textBox2.Clear();
            hitung.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void symbol_Load(object sender, EventArgs e)
        {

        }
    }
}
