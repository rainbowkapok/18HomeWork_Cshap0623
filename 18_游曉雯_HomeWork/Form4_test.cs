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
    public partial class Form4_test : Form
    {
        public Form4_test()
        {
            InitializeComponent();
        }
        string a, b, c;
        int b_count = 0;
        int t_count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string a = $"你好阿";
            string c = $"你好阿2";
            b_count++;
            if (b_count>0)
            {
                string i = b_count.ToString();
                string j = t_count.ToString();
                label1.Text = i+"\n"+j;
            }
            //label1.Text = a +"\n"+ c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = $"努力中";
            t_count++;
            if (b_count > 0)
            {
                string i = b_count.ToString();
                string j = t_count.ToString();
                label1.Text = i + "\n" + j;
            }
        }
    }
}
