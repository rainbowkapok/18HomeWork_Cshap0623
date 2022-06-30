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
    public partial class testGuess : Form
    {
        public testGuess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7_1 OpenF71 = new Form7_1();
            OpenF71.Show();

            GuessN newN = new GuessN();
            //int i = newN.Dis(newN.num);
            //label2.Text = i.ToString();
            int j = newN.num;
            //int i = newN.Dis(j);
            //label2.Text = i.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Form7_1 F71 = new Form7_1();

            //MessageBox.Show(F71.textBox1.Text);
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            //int ans = 5;
            //int count = 0;
            //int max = 100;
            //int min = 1;

            //GuessN gn = new GuessN();
            //double max = (double)gn.max;
            //int min = gn.min;
            //int a = Convert.ToInt32(gn.gNum);
            //label2.Text = $"{min} between {max}";
            //string FiAns = a == ans ? "答對了!!" : "答錯了 再加油!!";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        

        //public string gNuma
        //{
        //    get { return this.label2.Text; }
        //    set { this.label2.Text = value; }
        //}
    }
}
