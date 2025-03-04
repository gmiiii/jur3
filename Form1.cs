using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jur3
{
    public partial class Form1 : Form
    {
        
        int hasil = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text = "7";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void no_1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void no_0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void no_2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void no_3_Click(object sender, EventArgs e)
        {
            input.Text += "3"; 
        }

        private void no_4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void no_5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void no_6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void no_8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void no_9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void add_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(input.Text);
            hasil += x;

            input.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(input.Text);
            hasil += x;
            input.Text = hasil.ToString();
        }
    }
}
