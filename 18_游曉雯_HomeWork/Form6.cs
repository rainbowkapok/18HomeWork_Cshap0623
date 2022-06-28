using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_游曉雯_HomeWork
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int ans = a + b;
            label4.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int ans = a - b;
            label4.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int ans = a * b;
            label4.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a =int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double ans = a / b;

            label4.Text = Convert.ToString(Math.Round(ans));
        }
    }
}
