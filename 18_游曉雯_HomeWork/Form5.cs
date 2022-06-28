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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        const int b = 11;
        const int a = 9;
        string f = "";
        private void Form5_Load(object sender, EventArgs e)
        {
           string f= $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n";
            label6.Text = f;
            /*"舉例:\r\n\t測試";*/

        }
        Dictionary<int, int> mykey = new Dictionary<int, int>();
        List<int> showRange = new List<int>();
        List<MyClass2> Mylist = new List<MyClass2>();
        void showshow()
        {
           
        }
        public int showh(int x, int y, int z) 
        {
            showRange.Add(x);
            showRange.Add(y);
            showRange.Add(z);
            showRange.Sort();
            showRange.Reverse();
            return showRange[0];
        }

        public int showlow(int x,int y,int z) 
        { 
            showRange.Add(x);
            showRange.Add(y);
            showRange.Add(z);
            showRange.Sort();
            return showRange[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass2 num;
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            Mylist.Add(num);
            //showshow();
            int low=showlow(num.EChi, num.Eng, num.EMath);
            int lh=showh(num.EChi, num.Eng, num.EMath);
            string result = "";

            foreach (var item in Mylist)
            {
                int avg = 0;
                int atotal = 0;

                //showRange.Add(item.EChi);
                //showRange.Add(item.Eng);
                //showRange.Add(item.EMath);
                //showRange.Sort();
                atotal = item.EChi + item.Eng + item.EMath;
                avg = atotal / 3;
                result += $"{item.EName,b},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{low,b},{lh,b}{showRange.IndexOf(num.EChi)}\n";
            }

            label6.Text = $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;
            //MyEnum ECnum = MyEnum.國文;
            //MyEnum EEnum = MyEnum.英文;
            //MyEnum EMnum = MyEnum.數學;
            //mykey.Add(1, num.EChi);
            //mykey.Add(2, num.Eng);
            //mykey.Add(3, num.EMath);
            //int finekey = 0;
            //foreach (var item2 in mykey)
            //{
            //    if (bbb == item2.Value)
            //    {
            //        finekey = item2.Key;
            //        //MessageBox.Show(item2.Key.ToString());
            //        if (finekey == 1)
            //        {
            //            string rn = "國文"; res += rn;
            //        }
            //        else if (finekey == 2)
            //        {
            //            string rn = "國文"; res += rn;
            //        }
            //        else if (finekey == 3)
            //        {
            //            string rn = "數學"; res += rn;
            //        }

            //        //MessageBox.Show(item2.ToString()); //[1,10]
            //        //MessageBox.Show(item2.Key.ToString());//[1]
            //    }
            //}

        }



        private void button2_Click(object sender, EventArgs e)
        {

            MyClass2 num;
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            int low = showlow(num.EChi, num.Eng, num.EMath);
            int lh = showh(num.EChi, num.Eng, num.EMath);
            Mylist.Insert(0, num);
            //showshow();
            string result = "";

            foreach (var item in Mylist)
            {
                int avg = 0;
                int atotal = 0;

                //showRange.Add(item.EChi);
                //showRange.Add(item.Eng);
                //showRange.Add(item.EMath);
                //showRange.Sort();
                atotal = item.EChi + item.Eng + item.EMath;
                avg = atotal / 3;
                result += $"{item.EName,b},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{low,b},{lh,b}\n";
            }

            label6.Text = $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MyClass2 num;
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            int low = showlow(num.EChi, num.Eng, num.EMath);
            int lh = showh(num.EChi, num.Eng, num.EMath);
            Mylist.RemoveAt(0);
            string result = "";

            foreach (var item in Mylist)
            {
                int avg = 0;
                int atotal = 0;

                //showRange.Add(item.EChi);
                //showRange.Add(item.Eng);
                //showRange.Add(item.EMath);
                //showRange.Sort();
                atotal = item.EChi + item.Eng + item.EMath;
                avg = atotal / 3;
                result += $"{item.EName,b},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{low,b},{lh,b}\n";
            }

            label6.Text = $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            MyClass2 num;
            num.EName = "";
            num.EChi = 0;
            num.Eng = 0;
            num.EMath = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string r1 = "abcdefgh";
            //int i=r1.IndexOf("c");//a=0 b=1 c=2
            //MessageBox.Show(i.ToString());

            List<int> kk = new List<int>();
            
            kk.Add(30);
            kk.Add(50);
            kk.Add(20);
            int j = kk.IndexOf(1); //0=-1,1=0,2=1,3=2 顯示數字在陣列中的位子,找不到就為-1
            //MessageBox.Show(j.ToString());

            //int low = showlow(20,30,50);
            //int lh = showh(50,30,20);
            int m = kk.IndexOf(30);
            //int n = kk.LastIndexOf(20);
            
            switch (m)
            {
                case 0:
                string chi = "國文";
                    MessageBox.Show(chi);
                    break;
                case 1:
                    string eng = "英文";
                    MessageBox.Show(eng);
                    break;
                case 2:
                    string ma = "數學";
                    MessageBox.Show(ma);
                    break;
                default:
                    break;
            
            }MessageBox.Show(m.ToString());

            

            //string result = "";
            //MyClass2 num;
            //num.EName = textBox1.Text;
            //num.EChi = int.Parse(textBox2.Text);
            //num.Eng = int.Parse(textBox3.Text);
            //num.EMath = int.Parse(textBox4.Text);
            //int s1 = int.Parse(textBox5.Text);
            //int s2 = int.Parse(textBox6.Text);
            //int low = showlow(num.EChi, num.Eng, num.EMath);
            //int lh = showh(num.EChi, num.Eng, num.EMath);
            //{showRange.IndexOf(10)},
            //foreach (var item in Mylist)
            //{
            //    showRange.Add(item.EChi);
            //    showRange.Add(item.Eng);
            //    showRange.Add(item.EMath);
            //    int s3=showRange.IndexOf(s1);
            //    if (s3==0)
            //    {
            //            int avg = 0;
            //            int atotal = 0;

            //            atotal = item.EChi + item.Eng + item.EMath;
            //            avg = atotal / 3;
            //            result += $"{item.EName,b},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},\n";


            //        label6.Text = $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;
            //    }
            //}
        }
    }
}
