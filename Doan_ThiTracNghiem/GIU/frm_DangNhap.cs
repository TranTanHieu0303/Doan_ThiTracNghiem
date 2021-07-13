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
    public partial class frm_DangNhap : Form
    {
        XuLy XL = new XuLy();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string pUse = txt_Use.Text;
            string pPass = txt_Pass.Text;
            TaiKhoan t = XL.ktDangNhap(pUse, pPass);
            if (t != null)
            {
                frm_TrangChu frm = new frm_TrangChu();
                frm.tk = t;
                frm.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chích xác\nVui lòng kiểm tra lại", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy frm = new frm_DangKy();
            frm.ShowDialog();
            
        }
    }
}
