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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Bitmap bmp;         // 宣告圖形物件
        int oldX, oldY;     // 記錄滑鼠指標X、Y座標
        int PenPixel;       // 宣告PenPixel表示畫筆粗細
        Color PenColor;     // 宣告PenColor表示畫筆顏色

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen p = new Pen(PenColor, PenPixel);
                g.DrawLine(p, oldX, oldY, e.X, e.Y);//在bmp畫布上畫一條直線
                pictureBox1.Image = bmp;// 畫布貼到pictureBox1圖片方塊控制項上
                oldX = e.X;           // 將目前畫筆座標當作下次畫筆的起點
                oldY = e.Y;
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(320, 210);  //建立圖形物件大小320*210
            Graphics g = Graphics.FromImage(bmp);  // 建立畫布物件g
            PenColor = Color.Black;
            PenPixel = 3;
            g.Clear(Color.White);   // 將畫布清為白色
            pictureBox1.Image = bmp;// 畫布貼到pictureBox1圖片方塊控制項上
            pictureBox1.Refresh();  // 更新pictureBox1圖片方塊控制項
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }
    }
}
