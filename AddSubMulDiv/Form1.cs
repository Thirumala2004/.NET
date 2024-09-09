using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSubMulDiv
{
    public partial class Form1 : Form
    {
        int a, b, c;
        float d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text=c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            d = (float)a / b;
            textBox3.Text = d.ToString();
        }
    }
}
