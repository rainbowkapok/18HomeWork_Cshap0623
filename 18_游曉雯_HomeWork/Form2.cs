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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ans2.CalNum.myMoney = int.Parse(textBox1.Text);
                Ans2.CalNum.myYear = int.Parse(textBox2.Text);
                Ans2.CalNum.myRate = int.Parse(textBox3.Text);
                Ans2.CalNum.myFirst = int.Parse(textBox4.Text);
                Ans2 Pmt = new Ans2();
                Ans2.CalNum.PMT = Pmt.Cal(Ans2.CalNum.myMoney, Ans2.CalNum.myYear, Ans2.CalNum.myRate, Ans2.CalNum.myFirst);
                label5.Text = Ans2.CalNum.PMT.ToString();
                //MessageBox.Show($"月付額:{m}元");
                MessageBox.Show("月付額:" + string.Format("{0:C0}", Ans2.CalNum.PMT));

            }
            catch (Exception)
            {

                MessageBox.Show("請輸入正確數值，謝謝!");
            }


            //label5.Text = Math.Pow(2,2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Ans2.CalNum.myMoney = int.Parse(textBox1.Text);
                Ans2.CalNum.myYear = int.Parse(textBox2.Text);
                Ans2.CalNum.myRate = int.Parse(textBox3.Text);
                Ans2.CalNum.myFirst = int.Parse(textBox4.Text);
                Ans2 Pmt = new Ans2();
                Ans2.CalNum.PMT = Pmt.Cal(Ans2.CalNum.myMoney, Ans2.CalNum.myYear, Ans2.CalNum.myRate, Ans2.CalNum.myFirst);
                Ans2.CalNum.Total = Pmt.CalTotal(Ans2.CalNum.PMT, Ans2.CalNum.myYear);
                MessageBox.Show("總付額:" + string.Format("{0:C0}", Ans2.CalNum.Total));

            }
            catch (Exception)
            {

                MessageBox.Show("請輸入正確數值，謝謝!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2_1 fm = new Form2_1();
            fm.Show();
        }
    }
}
