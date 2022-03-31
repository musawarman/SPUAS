using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPUAS
{
    public partial class SystemMenu : Form
    {
        public SystemMenu()
        {
            InitializeComponent();
        }

        private void referensiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Referensi refer = new Referensi();
            refer.Show();
            refer.MdiParent = this;
        }

        private void entriDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BahanAjar frm = new BahanAjar();
            frm.Show();
            frm.MdiParent = this;
        }

        private void kELUARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void lAPORANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptUAS rpt = new rptUAS();
            rpt.Show();
            
        }

        private void uTILITYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
