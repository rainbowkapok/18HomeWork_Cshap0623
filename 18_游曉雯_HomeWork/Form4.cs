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
        MyClass num = new MyClass();
        List<MyClass> IsMy = new List<MyClass>();
        string result = "";
        void show()
        {
            foreach (var item in IsMy)
            {
                result = $"姓名:{item.Name}\n國文:{item.ChineseScore}\n英文:{item.EnglishScore}\n數學:{item.MathScore}\n\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MyClass num = new MyClass();
            //num.Name = textBox1.Text;
            //num.Chinese = int.Parse(textBox2.Text);
            //num.English = int.Parse(textBox3.Text);
            //num.Math = int.Parse(textBox4.Text);
            //result += $"姓名:{num.Name}\n國文:{num.Chinese}\n英文:{num.English}\n數學:{num.Math}";
            num.Name = textBox1.Text;
            num.ChineseScore = int.Parse(textBox2.Text);
            num.EnglishScore = int.Parse(textBox3.Text);
            num.MathScore = int.Parse(textBox4.Text);
            IsMy.Add(num);
            show();

            //int[] Num = new int[] { num.ChineseScore = int.Parse(textBox2.Text),
            //num.EnglishScore = int.Parse(textBox3.Text),
            //num.MathScore = int.Parse(textBox4.Text),
            //};
            //string[] InputName = new string[] { inputname.Name = textBox1.Text };
            //result += $"姓名:{inputname.Name },國文:{ num.ChineseScore},英文:{num.EnglishScore},數學:{num.MathScore}\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label5.Text += result;
        }
        //string result2 = "";
        private void button3_Click(object sender, EventArgs e)
        {
            //int a = Num[0];
            //int b = Num[0];
            //MessageBox.Show("國文最高分為:"+a.ToString()+"\n"+ "數學最高分為:"+b.ToString());
            //Array.Sort(ary);

            //string result = "";
            //result += ary[2];
            //string result1 = "";
            //result1+= ary[0];
            List<int> mylist = new List<int>();
            mylist.Add(num.ChineseScore);
            mylist.Add(num.EnglishScore);
            mylist.Add(num.MathScore);
            mylist.Sort();
            string mylist1 = string.Join("->", mylist);
            MessageBox.Show($"分數由小到大:{mylist1}");
            label6.Text = "最低分"+mylist[0].ToString()+"\n"+"最高分"+ mylist[2].ToString();
            //String result1 = "";
            //foreach (var item in mylist1)
            //{
            //    result1 = item;
            //}
            //MessageBox.Show(result1);
            //label6.Text = $"最高分:{result1},最低分:{result1}";
            
            //foreach (var item in IsMy)
            //{
            //    result2 += $"{item.Name}:{item.ChineseScore},{item.EnglishScore},{item.MathScore}";
            //}
            //MessageBox.Show(result2);

            //var what = from p in IsMy
            //        orderby p.ChineseScore descending
            //        select p;

            
            //string k = "";
            //foreach (var item in IsMy)
            //{
            //    k += $"國文:{item.ChineseScore} ,英文:{item.EnglishScore} ,數學:{item.MathScore}";
            //}
            //label6.Text=k;

            //for (int i = 0; i < IsMy.Count; i++)
            //{
            //    for (int j = 0; j < IsMy.Count; j++)
            //    {
            //        k += IsMy();
            //    }

            //}
            //MessageBox.Show(k);

            //MessageBox.Show($"最高分:國文{resultc}\n最高分:英文{result}\n最高分:數學{resultm}\n");
            //if (em.ChineseScore > em.EnglishScore && em.ChineseScore > em.MathScore)
            //{
            //    label6.Text += $"國文 最高分:{em.ChineseScore},";
            //}
            //else if (em.ChineseScore < em.EnglishScore && em.EnglishScore > em.MathScore)
            //{
            //    label6.Text += $"英文 最高分:{em.EnglishScore},";
            //}
            //else if (em.ChineseScore < em.MathScore && em.EnglishScore < em.MathScore)
            //{
            //    label6.Text += $"數學 最高分:{em.MathScore}\n";
            //}
            //if (em.ChineseScore < em.MathScore && em.ChineseScore < em.MathScore)
            //{
            //    label6.Text += $"國文 最低分:{em.ChineseScore},";
            //}
            //else if (em.ChineseScore > em.MathScore && em.EnglishScore > em.MathScore)
            //{
            //    label6.Text += $"數學 最低分:{em.MathScore},";
            //}
            //else if (em.ChineseScore > em.EnglishScore && em.EnglishScore < em.MathScore)
            //{
            //    label6.Text += $"英文 最低分:{em.EnglishScore}\n";
            //}

            //int a = em.ChineseScore.CompareTo(em.EnglishScore);
            //if (a > 0)
            //{
            //    a = em.ChineseScore;
            //    if (a > em.MathScore)
            //    {
            //        a = em.ChineseScore;
            //    }

            //}
            //else if (a < 0)
            //{
            //    a = em.EnglishScore;
            //    if (a < em.MathScore)
            //    {
            //        a = em.MathScore;
            //    }
            //}
            //MessageBox.Show(Convert.ToString(a));

            //IsMy.Sort(Compare);
            //string result = "";
            //if (true)
            //{
            //    result = Convert.ToString(IsMy);
            //}
            //MessageBox.Show(result);


            //string result = "";
            //foreach (var item in IsMy)
            //{
            //    result += item.ChineseName + item.ChineseScore + "\n" + item.EnglishName + item.EnglishScore+"\n"+item.MathName+item.MathScore;
            //}
            //MessageBox.Show(result);

            //for (int i = 0; i < ary.GetLength(0); i++)
            //{

            //    result += ary[2]+"\n";

            //}

            //MessageBox.Show(result);



        }
        //public int Compare(MyClass x, MyClass y)
        //{
        //    return x.ChineseScore.CompareTo(y.EnglishScore);
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //string a = "";
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //       a+= $"i:{i},j:{j}\n";
            //    } 
            //}MessageBox.Show(a);
            label5.Text = "";
            label6.Text = "";
            num.Name = "";
            num.ChineseScore =0;
            num.EnglishScore = 0;
            num.MathScore = 0;
            textBox1.Text = "a";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
