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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        int a;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            GuessInput G = new GuessInput();//輸入的表單
            G.Show();
            G.Owner = this;
           
            
        }

        private void Guess_Load(object sender, EventArgs e)
        {
            Random myans = new Random();
            int ans = myans.Next(1, 100);
            a = ans;
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正確答案" + a);
            label4.Text = a.ToString();
        }

    }
}
