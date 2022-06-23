using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _18_游曉雯_HomeWork.Prices;

namespace _18_游曉雯_HomeWork
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        int beer_Count = 0;
        int tequila_Count = 0;
        int whisky_Count = 0;
        int Wine_Count = 0;
        int total = 0;
        int sum = 0;
        
        private void btn_beer_Click(object sender, EventArgs e)
        {
            //btn_beer.Click += Btn_beer_Click;
            //for (int i = 0; i >=0; i++)
            //{
            //    i += 1; 

            //}

            beer_Count++;
            label2.Text = beer_Count.ToString();

            Prices NeedPay = new Prices();
            int m = NeedPay.Subtotal(120, beer_Count);
            //listBox1.Items.Insert(0, $"啤酒 Beer x {b_beer},共NT$:{m}") ;
            //total += m;

            if (beer_Count > 0 && tequila_Count>0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                label5.Text = $"啤酒 Beer x {b},共NT$:{m}\n" +
                    $"龍舌蘭 Tequila x {t},共NT$:{m}";
            }
            else if(beer_Count > 0 && tequila_Count == 0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                label5.Text = $"啤酒 Beer x {b},共NT$:{m}\n";
            }
            else if (beer_Count > 0 && tequila_Count == 0 && whisky_Count>0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                string wisky = whisky_Count.ToString();
                label5.Text = $"威士忌 whisky x {wisky},共NT$:{m}\n"+
                     $"龍舌蘭 Tequila x {t},共NT$:{m}\n"+
                     $"威士忌 whisky x {wisky},共NT$:{m}"; 
            }

            //Payment NeedPay;
            //NeedPay.Subtotal(120,1);

            //int ItemPrice = NeedPay.Menu(m, i);
            //listBox1.Items.Add($"啤酒 Beer x {i},共NT$:{ItemPrice}");

            //MessageBox.Show($"啤酒 NT$:{m}");
            //listBox1.Items.Add($"啤酒 Beer x {i},共NT$:{m}");

            

        }

        private void btn_tequila_Click(object sender, EventArgs e)
        {
            tequila_Count++;
            label3.Text = tequila_Count.ToString();

            Prices NeedPay = new Prices();
            int m = NeedPay.Subtotal(180, tequila_Count);
            //listBox1.Items.Insert(0, $"龍舌蘭 Tequila x {b_tequila},共NT$:{m}");
            total += m;
            label4.Text = total.ToString();

            if (beer_Count > 0 && tequila_Count > 0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                label5.Text = $"啤酒 Beer x {b},共NT$:{m}\n" +
                    $"龍舌蘭 Tequila x {t},共NT$:{m}";
            }
            else if (beer_Count > 0 && tequila_Count == 0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                label5.Text = $"啤酒 Beer x {b},共NT$:{m}\n";
            }
            else if (beer_Count > 0 && tequila_Count == 0 && whisky_Count > 0)
            {
                string b = beer_Count.ToString();
                string t = tequila_Count.ToString();
                string wisky = whisky_Count.ToString();
                label5.Text = $"威士忌 whisky x {wisky},共NT$:{m}\n" +
                     $"龍舌蘭 Tequila x {t},共NT$:{m}\n" +
                     $"威士忌 whisky x {wisky},共NT$:{m}";
            }

            //Payment p;
            //Prices NeedPay = new Prices();
            //p = p(180, b_tequila);
            //if (b_tequila >= 1)
            //{
            //    NeedPay.Subtotal(180, b_tequila);
            //}
        }

       
        //private void Btn_beer_Click(object sender, EventArgs e)
        //{
        //    }



        //throw new NotImplementedException();

    }
}
