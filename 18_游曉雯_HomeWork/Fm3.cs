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
    public partial class Fm3 : Form
    {
        public Fm3()
        {
            InitializeComponent();
        }
        int b_count;
        int c_count;
        int d_count;
        int e_count;
        int b_price=80;
        int c_price = 90;
        int d_price = 100;
        int e_price = 70;
        int price;
        double c_total;
        string order1, order2, order3, order4;

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額:{price:c0}");
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            c_total = price * 0.9;
            MessageBox.Show($"總金額:{price:c0}\n折扣後金額:{c_total:c0}");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            b_count++;
            if (b_count>=0)
            {
                order1 = "珍奶 " + b_count + "杯," + "單價:" + b_price + "小計:" + b_price * b_count;
            }
            label2.Text = order1 + "\n" + order2 + "\n" + order3 + "\n" + order4 + "\n";
            price = b_price * b_count + c_price * c_count + d_price * d_count + e_price * e_count;
            label1.Text = price.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            b_count = 0;c_count = 0;d_count = 0;e_count = 0;
            order1 = "";order2 = "";order3 = "";order4 = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c_count++;
            if (c_count >= 0)
            {
                order2 = "蘋果汁 " + c_count + "杯," + "單價:" + c_price + "小計:" + c_price * c_count;
            }
            label2.Text = order1+"\n" + order2 + "\n" + order3 + "\n" + order4 + "\n";
            price = b_price * b_count + c_price * c_count + d_price * d_count + e_price * e_count;
            label1.Text = price.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d_count++;
            if (d_count >= 0)
            {
                order3 = "紅茶 " + d_count + "杯," + "單價:" + d_price + "小計:" + d_price * d_count;
            }
            label2.Text = order1 + "\n" + order2 + "\n" + order3 + "\n" + order4 + "\n";
            price = b_price * b_count + c_price * c_count + d_price * d_count + e_price * e_count;
            label1.Text = price.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            e_count++;
            if (e_count >= 0)
            {
                order4 = "咖啡 " + e_count + "杯," + "單價:" + e_price + "小計:" + e_price * e_count;
            }
            label2.Text = order1 + "\n" + order2 + "\n" + order3 + "\n" + order4 + "\n";
            price = b_price * b_count + c_price * c_count + d_price * d_count + e_price * e_count;
            label1.Text = price.ToString();
        }
    }
}
