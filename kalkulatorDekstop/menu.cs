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
    public partial class menu : Form
    {
        private decimal a1 = 0.0m;
        private decimal a2 = 0.0m;
        private decimal hasil = 0.0m;
        private string p;

        public menu()
        {
            InitializeComponent();
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
            a1 = decimal.Parse(num1.Text);
            a2 = decimal.Parse(num2.Text);
            p = pilih.Text;

            if (p == "1")
            {
                hasil = a1 + a2;
                hitung.Text = hasil.ToString();
            }
            if (p == "2")
            {
                hasil = a1 - a2;
                hitung.Text = hasil.ToString();
            }
            if (p == "3")
            {
                hasil = a1 * a2;
                hitung.Text = hasil.ToString();
            }
            if (p == "4")
            {
                hasil = a1 / a2;
                hitung.Text = hasil.ToString();
            }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (pilih.Text == "0")
            {
                pilih.Text = "1";
            }
            else
            {
                pilih.Text += "1";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (pilih.Text == "0")
            {
                pilih.Text = "2";
            }
            else
            {
                pilih.Text += "2";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (pilih.Text == "0")
            {
                pilih.Text = "3";
            }
            else
            {
                pilih.Text += "3";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (pilih.Text == "0")
            {
                pilih.Text = "4";
            }
            else
            {
                pilih.Text += "4";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            pilih.Clear();
            hitung.Clear();
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button6_Click_1(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
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

        private void button11_Click_1(object sender, EventArgs e)
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

        private void button9_Click_1(object sender, EventArgs e)
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

        private void button8_Click_1(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
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

        private void button22_Click_1(object sender, EventArgs e)
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

        private void button21_Click_1(object sender, EventArgs e)
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

        private void button20_Click_1(object sender, EventArgs e)
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

        private void button19_Click_1(object sender, EventArgs e)
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

        private void button18_Click_1(object sender, EventArgs e)
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

        private void button17_Click_1(object sender, EventArgs e)
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

        private void button13_Click_1(object sender, EventArgs e)
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

        private void button16_Click_1(object sender, EventArgs e)
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

        private void button15_Click_1(object sender, EventArgs e)
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

        private void button14_Click_1(object sender, EventArgs e)
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
    }
}
