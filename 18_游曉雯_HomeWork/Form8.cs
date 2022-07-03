using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_游曉雯_HomeWork
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是索引");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("../Read.txt", Encoding.UTF8);
                //FileStream fs = new FileStream("../Read.txt", FileMode.Open);
                
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("請按開啟");
            }
        }
        string word = "";
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //richTextBox1.SaveFile("../Read.txt", RichTextBoxStreamType.RichText);

            FileStream fs = new FileStream("../Read.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            
            word=richTextBox1.Text;
            
            if (richTextBox1.ForeColor==Color.Red)
            {
                //MessageBox.Show("rad");
                richTextBox1.ForeColor = Color.Red;
                sw.Write(word);
            }
            sw.Close();
            fs.Close();
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //richTextBox1.SelectionColor = Color.Red;
            richTextBox1.ForeColor = Color.Red;
            
            //richTextBox1.AppendText(word);
            //如果每一行都要不一樣的話也可以寫成這樣：
            //richTextBox1.SelectionColor = Color.Purple;
            //richTextBox1.AppendText("TestLine2" + Environment.NewLine);

            //richTextBox1.SelectionColor = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectionColor = Color.Green;
            richTextBox1.ForeColor = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.ForeColor = Color.Blue;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectionColor = Color.Black;
            richTextBox1.ForeColor = Color.Black;
        }
        string NewWord = "";
        string result = "";
        string a;
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
                    

            //複製字串          
            //string a = "你好阿，我在寫程式";
            //string b;
            //b = string.Copy(a);
            //MessageBox.Show(b);

            //CopyTo
            //char[] str = new char[100];
            //3：需要複製的字元的起始位置3
            //str：目標陣列
            //0：目標陣列中開始存放的位置0
            //10：複製字元的個數
            //a.CopyTo(3, str, 0, 10);
            //Console.WriteLine(str);
            //Console.ReadLine();

            char[] str = new char[8];
            a.CopyTo(0,str,0,8);
            foreach (var item in str)
            {
                //MessageBox.Show(item.ToString());
                result += item;
            }
            
            
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                
                a=richTextBox1.Text;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
                NewWord = word + result;
                MessageBox.Show(NewWord);
           
            
        }
    }
}
