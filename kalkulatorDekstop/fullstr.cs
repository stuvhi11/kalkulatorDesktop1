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
    public partial class fullstr : Form
    {
        
        public fullstr()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "satu";
            }
            else
            {
                inputt.Text += "satu";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "nol";
            }
            else
            {
                inputt.Text += "nol";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "dua";
            }
            else
            {
                inputt.Text += "dua";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "tiga";
            }
            else
            {
                inputt.Text += "tiga";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "empat";
            }
            else
            {
                inputt.Text += "empat";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "lima";
            }
            else
            {
                inputt.Text += "lima";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "enam";
            }
            else
            {
                inputt.Text += "enam";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "tujuh";
            }
            else
            {
                inputt.Text += "tujuh";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "delapan";
            }
            else
            {
                inputt.Text += "delapan";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (inputt.Text == "nol")
            {
                inputt.Text = "sembilan";
            }
            else
            {
                inputt.Text += "sembilan";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var htng = new HitungTerbilang();
            string result = htng.hitung(inputt.Text);
            inputt.Text = result + " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputt.Text == " ")
            {
                inputt.Text = " tambah ";
            }
            else
            {
                inputt.Text += " tambah ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputt.Text == " ")
            {
                inputt.Text = " kali ";
            }
            else
            {
                inputt.Text += " kali ";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputt.Text == " ")
            {
                inputt.Text = " bagi ";
            }
            else
            {
                inputt.Text += " bagi ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputt.Text == " ")
            {
                inputt.Text = " kurangi ";
            }
            else
            {
                inputt.Text += " kurangi ";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputt.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public class HitungTerbilang
        {
            public static string[] _angka = { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas", "belas", "puluh" };

            public static string[] _dataOperanString = { "tambah", "+", "kurangi", "-", "kali", "*", "bagi", "/" };

            public string hitung(string input)
            {

                string[] inputArr = input.Split(' ');

                int pertama = 0, kedua = 0;
                char operan = ' ';

                for (int i = 0; i < _angka.Length; i++)
                {
                    if (inputArr[0] == _angka[i])
                    {
                        pertama = i;
                        break;
                    }
                }

                for (int i = 0; i < _dataOperanString.Length; i++)
                {
                    if (inputArr[1] == _dataOperanString[i]) { operan = Convert.ToChar(_dataOperanString[i + 1]); break; }
                }

                for (int i = 0; i < _angka.Length; i++)
                {
                    if (inputArr[2] == _angka[i])
                    {
                        kedua = i;
                        break;
                    };
                }

                return perhitungan(pertama, operan, kedua);
            }

            public static string perhitungan(int pertama, char operan, int kedua)
            {
                int hasil = 0;

                switch (operan)
                {
                    case '+':
                        hasil = pertama + kedua;
                        break;
                    case '-':
                        hasil = pertama - kedua;
                        break;
                    case '*':
                        hasil = pertama * kedua;
                        break;
                    case '/':
                        hasil = pertama / kedua;
                        break;
                }

                if (hasil >= 0 && hasil < 12)
                {
                    return (_angka[hasil]);
                }
                else if (hasil >= 12 && hasil < 20)
                {
                    hasil -= 10;
                    return ($"{_angka[hasil]} {_angka[12]}");
                }
                else if (hasil < 0)
                {
                    if (hasil < -12)
                    {
                        hasil *= -1;
                        return ($"negatif {_angka[hasil]} {_angka[12]}");
                    }
                    else
                    {
                        hasil *= -1;
                        return ($"negatif {_angka[hasil]}");
                    }
                }
                else
                {
                    return ($" {hasil}");
                }
            }

        }

    }
    }
