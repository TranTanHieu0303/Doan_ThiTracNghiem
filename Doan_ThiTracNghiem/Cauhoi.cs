using Doan_ThiTracNghiem.BLL;
using Doan_ThiTracNghiem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_ThiTracNghiem
{
    public partial class Cauhoi : UserControl
    {
        public Sapxepde ch; 
        public Cauhoi()
        {
            InitializeComponent();
        }

        private void Cauhoi_Load(object sender, EventArgs e)
        {
            lbl_cau.Text = "Câu "+ ch.STT;
            rdb_A.Checked = false;
            rdb_B.Checked = false;
            rdb_C.Checked = false;
            rdb_D.Checked = false;

        }

        private void rdb_A_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_A.Checked)
            {
                ch.dapanchon = "A";
            }
        }

        private void rdb_B_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_B.Checked)
            {
                ch.dapanchon = "B";
            }
        }

        private void rdb_C_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_C.Checked)
            {
                ch.dapanchon = "C";
            }
        }

        private void rdb_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_D.Checked)
            {
                ch.dapanchon = "D";
            }
        }
    }
}
