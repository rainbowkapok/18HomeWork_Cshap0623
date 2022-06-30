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
    public partial class Form7_1 : Form
    {
        public Form7_1()
        {
            InitializeComponent();
        }
        //int ans = 5;
        //int count = 0; //猜的次數
        //int max = 100;
        //int min = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            testGuess fon = new testGuess();
            fon.Show();
            //    //fon.TopLevel = false;
            fon.label1.Text = textBox1.Text;


            //    GuessN inpN = new GuessN();
            //    inpN.gNum = int.Parse(textBox1.Text);

            //    int a = inpN.gNum;

            //    while (a >= min && a < max)
            //    {
            //        count += 1;

            //        if (a < ans)
            //        {
            //            min = a;
            //            MessageBox.Show("Min" + min.ToString());
            //            break;
            //        }
            //        else if (a > ans)
            //        {
            //            max = a;
            //            MessageBox.Show("Max" + max.ToString());
            //            break;
            //        }
            //        else
            //        {
            //            MessageBox.Show("答對了!");
            //            break;
            //        }

            //    }

            //    while (a > 100)
            //    {
            //        MessageBox.Show("超出100!");
            //        break;
            //    }

        }
    }
}
