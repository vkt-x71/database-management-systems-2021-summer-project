using LibraryManagement.Win.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Win
{
    public partial class Form1 : Form
    {
        libraryContext context;
        public Form1()
        {
            InitializeComponent();
            context = new libraryContext();
            yazarlarToolStripMenuItem1.Click += YazarlarToolStripMenuItem1_Click;
            
        }

        private void YazarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmYazarlar frm = new FrmYazarlar();
            frm.TopLevel = false;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
