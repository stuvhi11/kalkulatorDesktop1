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
    public partial class ch1 : Form
    {
        public ch1()
        {
            InitializeComponent();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }
            public decimal num1 = 0.0m;
            public decimal num2 = 0.0m;
            public decimal hasil = 0.0m;
            public string operasi = "+";

            private void button5_Click(object sender, EventArgs e)
            {
               
            }

            private void button6_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                inputText.Clear();
            }

            private void button12_Click(object sender, EventArgs e)
            {
                

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "0";
            }
            else
            {
                inputText.Text += "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "1";
            }
            else
            {
                inputText.Text += "1";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "2";
            }
            else
            {
                inputText.Text += "2";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "3";
            }
            else
            {
                inputText.Text += "3";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "4";
            }
            else
            {
                inputText.Text += "4";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "5";
            }
            else
            {
                inputText.Text += "5";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "6";
            }
            else
            {
                inputText.Text += "6";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "7";
            }
            else
            {
                inputText.Text += "7";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "8";
            }
            else
            {
                inputText.Text += "8";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "0")
            {
                inputText.Text = "9";
            }
            else
            {
                inputText.Text += "9";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num1 = decimal.Parse(inputText.Text);
            inputText.Clear();
            operasi = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(inputText.Text);
            inputText.Clear();
            operasi = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(inputText.Text);
            inputText.Clear();
            operasi = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(inputText.Text);
            inputText.Clear();
            operasi = "-";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            switch (operasi)
            {
                case "+":
                    num2 = decimal.Parse(inputText.Text);
                    hasil = num1 + num2;
                    inputText.Text = hasil.ToString();
                    label3.Text = ($"{num1} {operasi} {num2} = {hasil}");
                    break;
                case "-":
                    num2 = decimal.Parse(inputText.Text);
                    hasil = num1 - num2;
                    inputText.Text = hasil.ToString();
                    label3.Text = ($"{num1} {operasi} {num2} = {hasil}");
                    break;
                case "*":
                    num2 = decimal.Parse(inputText.Text);
                    hasil = num1 * num2;
                    inputText.Text = hasil.ToString();
                    label3.Text = ($"{num1} {operasi} {num2} = {hasil}");
                    break;
                case "/":
                    num2 = decimal.Parse(inputText.Text);
                    hasil = num1 / num2;
                    inputText.Text = hasil.ToString();
                    label3.Text = ($"{num1} {operasi} {num2} = {hasil}");
                    break;
            }

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (inputText.Text.Length > 0)
            {
                inputText.Text = inputText.Text.Remove(inputText.Text.Length - 1);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            inputText.Clear();
            label3.Text = "history";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
