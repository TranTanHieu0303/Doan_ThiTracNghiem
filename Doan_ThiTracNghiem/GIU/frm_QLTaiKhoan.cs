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

namespace Doan_ThiTracNghiem.GIU
{
    public partial class frm_QLTaiKhoan : Form
    {
        public TaiKhoan tk;
        XuLy Xl = new XuLy();
        public frm_QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgv_danhsachtk.AutoGenerateColumns = false;
            dgv_danhsachtk.DataSource = Xl.loadUse();
        }
    }
}
