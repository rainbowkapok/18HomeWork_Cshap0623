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

        private void Form5_Load(object sender, EventArgs e)
        {

            //string f= $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n";
            // label6.Text = f;
            /*"舉例:\r\n\t測試";*/

        }
        Dictionary<int, int> mykey = new Dictionary<int, int>();
        List<int> showRange = new List<int>();
        List<MyClass2> Mylist = new List<MyClass2>();
        List<int> MylistCH = new List<int>();
        List<int> MylistEH = new List<int>();
        List<int> MylistMH = new List<int>();
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

        public int showlow(int x, int y, int z)
        {
            showRange.Add(x);
            showRange.Add(y);
            showRange.Add(z);
            showRange.Sort();
            return showRange[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            MyClass2 num = new MyClass2();
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            Mylist.Add(num);
            string llow = "";
            string hscore = "";
            string str1 = "";
            string str2 = "";
            string[] subject = new string[] { "國文", "英文", "數學" };
            int[] score = new int[] { num.EChi, num.Eng, num.EMath };
            Array.Sort(score, subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i]+score[i]);
                llow = subject[0] + score[0];
            }
            str1 = llow;
            Array.Reverse(score);
            Array.Reverse(subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i] + score[i]);
                hscore = subject[0] + score[0];
            }
            str2 = hscore;
            //showshow();
            int low = showlow(num.EChi, num.Eng, num.EMath);
            int lh = showh(num.EChi, num.Eng, num.EMath);
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
                result += $"{item.EName,-6},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{str1,b},{str2,b}\n";
            }
            int mm = 0;
            label6.Text = $"{"姓名",-6}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;




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
            label5.Visible = false;
            MyClass2 num = new MyClass2();
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            int low = showlow(num.EChi, num.Eng, num.EMath);
            int lh = showh(num.EChi, num.Eng, num.EMath);
            Mylist.Insert(0, num);
            string llow = "";
            string hscore = "";
            string str1 = "";
            string str2 = "";
            string[] subject = new string[] { "國文", "英文", "數學" };
            int[] score = new int[] { num.EChi, num.Eng, num.EMath };
            Array.Sort(score, subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i]+score[i]);
                llow = subject[0] + score[0];
            }
            str1 = llow;
            Array.Reverse(score);
            Array.Reverse(subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i] + score[i]);
                hscore = subject[0] + score[0];
            }
            str2 = hscore;
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
                result += $"{item.EName,-6},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{str1,b},{str2,b}\n";
            }

            label6.Text = $"{"姓名",-6}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClass2 num = new MyClass2();
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            int low = showlow(num.EChi, num.Eng, num.EMath);
            int lh = showh(num.EChi, num.Eng, num.EMath);
            Mylist.RemoveAt(0);
            string llow = "";
            string hscore = "";
            string str1 = "";
            string str2 = "";
            string[] subject = new string[] { "國文", "英文", "數學" };
            int[] score = new int[] { num.EChi, num.Eng, num.EMath };
            Array.Sort(score, subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i]+score[i]);
                llow = subject[0] + score[0];
            }
            str1 = llow;
            Array.Reverse(score);
            Array.Reverse(subject);
            for (int i = 0; i < subject.Length; i++)
            {
                //MessageBox.Show(subject[i] + score[i]);
                hscore = subject[0] + score[0];
            }
            str2 = hscore;
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
                result += $"{item.EName,-6},{(item.EChi).ToString("###"),b},{(item.Eng).ToString("###"),b},{(item.EMath).ToString("###"),b},{(atotal).ToString("###"),b},{(avg).ToString("###.##"),b},{str1,b},{str2,b}\n";
            }

            label6.Text = $"{"姓名",-6}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label5.Text = "";
            MyClass2 num = new MyClass2();
            label6.Text = "";
            label8.Text = "";

            num.EName = "";
            num.EChi = 0;
            num.Eng = 0;
            num.EMath = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string r1 = "abcdefgh";
            //int i = r1.IndexOf("c");//a=0 b=1 c=2
            //MessageBox.Show(i.ToString());

            //int tt = MylistCH.IndexOf(int.Parse(cs));
            //MessageBox.Show(tt.ToString());
            //label5.Enabled = true;
            /*https://ithelp.ithome.com.tw/articles/10227210*/

            label6.Text = "";
            label6.Text = $"{"姓名",a}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n";
            label5.Visible = true;
            label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            string cs = textBox5.Text;
            string ch = textBox6.Text;


            foreach (var item in Mylist)
            {
                MylistCH.Add(item.EChi);

            }

            int tt = MylistCH.IndexOf(int.Parse(cs));
            int dd = MylistCH.IndexOf(int.Parse(ch));
            //MessageBox.Show(tt.ToString());
            string result = "";
            string result2 = "";
            //IndexOf<T>(T[], T, Int32)


            if (int.Parse(ch) > int.Parse(cs))
            {
                if (tt >= 0)
                {
                    for (int i = 0; i < Mylist.Count; i++)
                    {
                        if (tt == i)
                        {
                            string ggname = Mylist[i].EName;
                            int ggchi = Mylist[i].EChi;
                            int ggeng = Mylist[i].Eng;
                            int ggmat = Mylist[i].EMath;
                            //MessageBox.Show($"{ggname},{ggchi},{ggeng},{ggmat}");
                            result += $"{ggname,-6}{ggchi,b}{ggeng,b}{ggmat,b}";
                        }
                    }

                    label5.Enabled = Visible;
                }
                else
                {
                    MessageBox.Show("找不到值,請重新輸入");
                }

                if (dd >= 0)
                {
                    for (int i = 0; i < Mylist.Count; i++)
                    {
                        if (dd == i)
                        {
                            string hhname = Mylist[i].EName;
                            int hhchi = Mylist[i].EChi;
                            int hheng = Mylist[i].Eng;
                            int hhmat = Mylist[i].EMath;
                            //MessageBox.Show($"{ggname},{ggchi},{ggeng},{ggmat}");
                            result2 += $"{hhname,-6}{hhchi,b}{hheng,b}{hhmat,b}";
                        }
                    }

                    label5.Enabled = Visible;
                }
                else
                {
                    MessageBox.Show("找不到值,請重新輸入");
                }
                ;

            }
            else
            {
                MessageBox.Show("找不到值,請重新輸入(搜尋值左欄填小，右欄填大)，謝謝!");
            }

            int low = 0;
            int lh = 0;
            string result3 = "";
            foreach (var item in Mylist)
            {
                int avg = 0;
                int atotal = 0;
                atotal = item.EChi + item.Eng + item.EMath;
                avg = atotal / 3;
                showRange.Add(item.EChi);
                showRange.Add(item.Eng);
                showRange.Add(item.EMath);
                showRange.Sort();
                showRange.Reverse();
                lh = showRange[0];

                result3 += $"{(atotal).ToString("###"),b}{(avg).ToString("###.##"),b}{low,b}{lh,b}\n";
            }
            foreach (var item in Mylist)
            {
                showRange.Add(item.EChi);
                showRange.Add(item.Eng);
                showRange.Add(item.EMath);
                showRange.Sort();
                low = showRange[0];
            }
            label5.Text = $"{result}{result3}\n{result2}{result3}\n";

            //List<int> kk = new List<int>();

            //kk.Add(10);
            //kk.Add(2);
            //kk.Add(3);
            //int j = kk.IndexOf(1); //0=-1,1=0,2=1,3=2 顯示數字在陣列中的位子,找不到就為-1
            //int j = kk.IndexOf(int.Parse(cs));
            //MessageBox.Show(j.ToString());

            //int low = showlow(20,30,50);
            //int lh = showh(50,30,20);
            //int m = kk.IndexOf(30);
            //int n = kk.LastIndexOf(20);

            //switch (m)
            //{
            //    case 0:
            //        string chi = "國文";
            //        MessageBox.Show(chi);
            //        break;
            //    case 1:
            //        string eng = "英文";
            //        MessageBox.Show(eng);
            //        break;
            //    case 2:
            //        string ma = "數學";
            //        MessageBox.Show(ma);
            //        break;
            //    default:
            //        break;

            //}
            //MessageBox.Show(m.ToString());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int totalchi = 0;
            int totaleng = 0;
            int totalmath = 0;
            int avgchi = 0;
            int avgeng = 0;
            int avgmath = 0;
            int tavgc = 0;
            string lb8t = "";//各科總分
            string lb8a = "";//平均
            foreach (var item in Mylist)
            {
                totalchi += item.EChi;
                totaleng += item.Eng;
                totalmath += item.EMath;
                MylistCH.Add(item.EChi);
                MylistEH.Add(item.Eng);
                MylistMH.Add(item.EMath);
            }
            avgchi = totalchi / 3;
            avgeng = totaleng / 3;
            avgmath = totalmath / 3;
            lb8t += $"總分\t{totalchi,a}{totaleng,a}{totalmath,a}\n";
            lb8a += $"平均\t{avgchi,a}{avgeng,a}{avgmath,a}\n";
            foreach (var item in Mylist)
            {
                MylistCH.Add(item.EChi);
            }
            int chiL = 0;
            int enL = 0;
            int maL = 0;
            int chiH = 0;
            int enH = 0;
            int maH = 0;

            MylistCH.Sort();
            chiL = MylistCH[0];
            MylistCH.Sort();
            MylistCH.Reverse();
            chiH = MylistCH[0];

            MylistEH.Sort();
            enL = MylistEH[0];
            MylistEH.Sort();
            MylistEH.Reverse();
            enH = MylistEH[0];

            MylistMH.Sort();
            maL = MylistMH[0];
            MylistMH.Reverse();
            MylistMH.Sort();
            maH = MylistMH[0];

            string lb8L = "";//最低分
            lb8L += $"最低分\t{chiL,a}{enL,a}{maL,a}\n";
            string lb8H = "";
            lb8H += $"最高分\t{chiH,a}{enH,a}{maH,a}";

            label8.Text = lb8t + lb8a + lb8L + lb8H;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyClass2 num = new MyClass2();
            num.EName = textBox1.Text;
            num.EChi = int.Parse(textBox2.Text);
            num.Eng = int.Parse(textBox3.Text);
            num.EMath = int.Parse(textBox4.Text);
            Mylist.Add(num);
            string llow = "";
            string hscore = "";
            string result = "";
            string str1 = "";
            string str2 = "";
            int chi;
            int eng;
            int math;
            int total;
            double avg;
            int s1 = int.Parse(textBox5.Text);
            int s2 = int.Parse(textBox6.Text);
            if (s2>s1 && s1<s2)
            {



                foreach (MyClass2 item in Mylist)
                {
                    str1 = item.EName;
                    chi = item.EChi;
                    eng = item.Eng;
                    math = item.EMath;
                    total = item.EChi + item.Eng + item.EMath;
                    avg = total / 3;
                    result += $"{str1,-6}{chi,b}{eng,b}{math,b}{total,b}{avg,b}{str1,b}{str2,b}\n";
                }
                string[] subject = new string[] { "國文", "英文", "數學" };
                int[] score = new int[] { num.EChi, num.Eng, num.EMath };
                Array.Sort(score, subject);
                for (int i = 0; i < subject.Length; i++)
                {
                    //MessageBox.Show(subject[i]+score[i]);
                    llow = subject[0] + score[0];
                }
                str1 = llow;
                Array.Reverse(score);
                Array.Reverse(subject);
                for (int i = 0; i < subject.Length; i++)
                {
                    //MessageBox.Show(subject[i] + score[i]);
                    hscore = subject[0] + score[0];
                }
                str2 = hscore;
                label6.Text = $"{"姓名",-6}{"國文",a}{"英文",a}{"數學",a}{"總分",a}{"平均",a}{"最低",a}{"最高",a}\n" + result;
            }

        }
    }
}
