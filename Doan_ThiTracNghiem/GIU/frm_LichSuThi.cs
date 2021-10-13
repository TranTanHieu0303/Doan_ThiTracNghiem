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
    public partial class frm_LichSuThi : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        Form _frm;
        public frm_LichSuThi(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void frm_LichSuThi_Load(object sender, EventArgs e)
        {
            dgv_lichsu.AutoGenerateColumns = false;
            dgv_lichsu.DataSource = XL.loadLichSuThi(tk.MaUse);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void frm_LichSuThi_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
