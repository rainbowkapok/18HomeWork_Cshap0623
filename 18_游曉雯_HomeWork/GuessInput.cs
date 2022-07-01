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
    public partial class GuessInput : Form
    {
        public GuessInput()
        {
            InitializeComponent();
        }
        int ans = 5;
        //Random myObject = new Random();
        //myObject.Next(min, max);

       
        int count = 0; //猜的次數
        int max = 100;
        int min;
        int aans;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Guess fa = (Guess)this.Owner;
            fa.label1.Text = Gu1.Text;
            fa.label3.Visible = false;
            aans = int.Parse(fa.label4.Text);
            //MessageBox.Show(aans.ToString());
            GuessN.n = int.Parse(Gu1.Text);
            int a = GuessN.n;
            while (a >= min && a < max)
            {
                count += 1;

                if (a < aans)
                {
                    min = a;
                    //MessageBox.Show("Min" + min.ToString());
                    fa.label1.Text = $"猜大一點,猜了{count}次";
                    fa.label2.Text = $"答案介於{min} ~{max} ";
                    break;
                }
                else if (a > aans)
                {
                    max = a;
                    //MessageBox.Show("Max" + max.ToString());
                    fa.label1.Text = $"猜小一點,猜了{count}次";
                    fa.label2.Text = $"答案介於{min} ~ {max}";
                    break;
                }
                else
                {
                    //MessageBox.Show("答對了!");
                    fa.label1.Text = $"答對了!";
                    fa.label2.Text = $"恭喜你,數字 {a} 正確!";
                    break;
                }

            }

            while (a > 100)
            {
                MessageBox.Show("超出100!");
                break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gu1_TextChanged(object sender, EventArgs e)
        {
            //Guess NG = new Guess();
            //GuessN.n = int.Parse(Gu1.Text);
            //NG.textBox1.Text = GuessN.n.ToString();
        }
    }
}
