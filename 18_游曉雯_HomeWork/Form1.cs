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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member MyName = new Member();
            MyName.ChineseName = textBox1.Text;
            MyName.EnglishName = textBox2.Text;
            MyName.Sex = textBox3.Text;
            MyName.Constellation = textBox4.Text;

            MessageBox.Show($"Hello,我的中文姓名:{MyName.ChineseName}\n我的英文姓名:{MyName.EnglishName}\n性別:{MyName.Sex}\n星座:{MyName.Constellation}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member MyName = new Member();
            MyName.ChineseName = textBox1.Text;
            MyName.EnglishName = textBox2.Text;
            MyName.Sex = textBox3.Text;
            MyName.Constellation = textBox4.Text;

            //Ans1 Method = new Ans1();
            //Method.HiItem(MyName.ChineseName, MyName.EnglishName, MyName.Sex, MyName.Constellation);
            MessageBox.Show($"Hi,我的中文姓名:{MyName.ChineseName}\n我的英文姓名:{MyName.EnglishName}\n性別:{MyName.Sex}\n星座:{MyName.Constellation}");

        }
    }
}
