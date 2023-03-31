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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new menu().Show();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            new symbol().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new symbolstring().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new menu().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new fullstr().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ch2().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new ch1().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
