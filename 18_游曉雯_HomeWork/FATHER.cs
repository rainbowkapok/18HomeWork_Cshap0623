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
    public partial class FATHER : Form
    {
        public FATHER()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            labMOMO.Text = "";
            Boy F8 = new Boy();
            F8.Owner = this;
            F8.Show();
           
        }
    }
}
