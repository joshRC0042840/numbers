using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 52e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("n") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.14159253589793;
            richTextBox1.AppendText(pi.ToString("n15") + "\n");

            string st = "three";
            try
            {

                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + "is not an interger");
            }
            string s2 = "3";
            try
            {

                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + "is not an interger");
                int i2 = 0;

            }
            string s3 = "pi";
            try
            {

                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
    }   
}
