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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string result = "";
        private void button1_Click(object sender, EventArgs e)
        {
            MyClass num = new MyClass();

            num.Name = textBox1.Text;
            num.Chinese = int.Parse(textBox2.Text);
            num.English = int.Parse(textBox3.Text);
            num.Math = int.Parse(textBox4.Text);
            result += $"姓名:{num.Name}\n國文:{num.Chinese}\n英文:{num.English}\n數學:{num.Math}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = 
            label5.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MyClass num = new MyClass();
            //num.Name = textBox1.Text;
            //num.Chinese = int.Parse(textBox2.Text);
            //num.English = int.Parse(textBox3.Text);
            //num.Math = int.Parse(textBox4.Text);

            int[] ary = new int[3];
            ary[0] = int.Parse(textBox2.Text);
            ary[1] = int.Parse(textBox3.Text);
            ary[2] = int.Parse(textBox4.Text);

            

            for (int i = 0; i < 4; i++)
            {
                
            }

            
            
            //if (num.Chinese > num.English && num.Chinese > num.Math)
            //{
            //    label6.Text = $"國文:{num.Chinese}最高分";
            //}
            //else
            //{
            //    label6.Text = $"國文:{num.Chinese}最低分";
            //}
            //if (num.English > num.Chinese && num.English > num.Math)
            //{
            //    label6.Text = $"英文:{num.English}最高分";
            //}
            //else
            //{
            //    label6.Text = $"英文:{num.English}最低分";
            //}
            //if (num.Math > num.Chinese && num.Math > num.English)
            //{
            //    label6.Text = $"數學:{num.Math}最高分";
            //}
            //else
            //{
            //    label6.Text = $"數學:{num.Math}最低分";
            //}
        }
    }
}
