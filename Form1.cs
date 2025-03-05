using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal1
{
    public partial class Form1 : Form
    {
        List<String> list = new List<String>();
        int total1;
        int total2;
        String number = "";
        public Form1()
        {
            
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < list.Count; i++)
            {
                number += list[i];
            }
            label1.Text = number;
            total1 = Convert.ToInt32(number);
            label1.Text = "";
            list.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Add("1");
            label1.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            list.Add("9");
            label1.Text += "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Add("2");
            label1.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {


            for (int i=0; i<list.Count; i++)
            {
                number += list[i];
            }
            label1.Text = number;
            total2=Convert.ToInt32(number);
            label1.Text = "";
            label1.Text = (total1 + total2).ToString();
            list.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Add("3");
            label1.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Add("4");
            label1.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            list.Add("5");
            label1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Add("6");
            label1.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            list.Add("7");
            label1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            list.Add("8");
            label1.Text += "8";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Add("0");
            label1.Text += "0";
        }
    }
}
