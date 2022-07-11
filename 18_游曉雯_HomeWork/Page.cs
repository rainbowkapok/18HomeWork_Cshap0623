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
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form1 No1 = new Form1();
            No1.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No1);
            No1.Show();
            No1.Dock = DockStyle.Fill;
            No1.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form2 No2 = new Form2();
            No2.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No2);
            No2.Show();
            No2.Show();
            No2.Dock = DockStyle.Fill;
            No2.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Fm3 No3 = new Fm3();
            No3.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No3);
            No3.Show();
            No3.Dock = DockStyle.Fill;
            No3.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form4 No4 = new Form4();
            No4.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No4);
            No4.Show();
            No4.Show();
            No4.Dock = DockStyle.Fill;
            No4.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form5 No5 = new Form5();
            No5.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No5);
            No5.Show();
            No5.Show();
            No5.Dock = DockStyle.Fill;
            No5.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form6 No6 = new Form6();
            No6.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No6);
            No6.Show();
            No6.Show();
            No6.Dock = DockStyle.Fill;
            No6.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Guess No7 = new Guess();
            No7.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No7);
            No7.Show();
            No7.Show();
            No7.Dock = DockStyle.Fill;
            No7.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form8 No8 = new Form8();
            No8.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No8);
            No8.Show();
            No8.Show();
            No8.Dock = DockStyle.Fill;
            No8.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form9 No9 = new Form9();
            No9.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(No9);
            No9.Show();
            No9.Show();
            No9.Dock = DockStyle.Fill;
            No9.Bounds = splitContainer2.Panel2.Bounds;
        }
    }
}
