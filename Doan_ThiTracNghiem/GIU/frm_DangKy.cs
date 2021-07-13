using Doan_ThiTracNghiem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_ThiTracNghiem.GIU
{
    public partial class frm_DangKy : Form
    {
        XuLy XL = new XuLy();
        Task<string> hinh;
        public frm_DangKy()
        {
            InitializeComponent();
        }

        private void frm_DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            dlg_openfile.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            dlg_openfile.Title = "Open an Image File";
            DialogResult dr = dlg_openfile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ptb_HinhAnh.Image = Image.FromFile(dlg_openfile.FileName);
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string gioitinh;
            string pMaLoaitk;
            if (XL.loadUse().Count == 0)
                pMaLoaitk = "LTK01";
            else
                pMaLoaitk = "LTK02";
            if (rdb_Nam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            XL.themUseAsync(XL.themMaUse(), txt_TenDN.Text, txt_MK.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_NoiSinh.Text, dlg_openfile, pMaLoaitk);
        }
        private void QuanLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
