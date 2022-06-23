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
    public partial class Form2_1 : Form
    {
        public Form2_1()
        {
            InitializeComponent();
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {
            Ans2 Pmt = new Ans2();
            Ans2.CalNum.PMT = Pmt.Cal(Ans2.CalNum.myMoney, Ans2.CalNum.myYear, Ans2.CalNum.myRate, Ans2.CalNum.myFirst);

            Ans2.CalNum.PMT = Pmt.Cal(Ans2.CalNum.myMoney, Ans2.CalNum.myYear, Ans2.CalNum.myRate, Ans2.CalNum.myFirst);
            Ans2.CalNum.Total = Pmt.CalTotal(Ans2.CalNum.PMT, Ans2.CalNum.myYear);

            label6.Text = Ans2.CalNum.myMoney.ToString();
            label7.Text = Ans2.CalNum.myYear.ToString();
            label8.Text = Ans2.CalNum.myRate.ToString();
            label9.Text = string.Format("{0:C0}", Ans2.CalNum.PMT);
            label10.Text = Ans2.CalNum.Total.ToString();
        }
    }
}
