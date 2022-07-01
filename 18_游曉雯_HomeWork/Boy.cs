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
    public partial class Boy : Form
    {
        public Boy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FATHER FAFA = (FATHER)this.Owner;
            FAFA.labMOMO.Text = txtFA.Text;

               
        }
    }
}
