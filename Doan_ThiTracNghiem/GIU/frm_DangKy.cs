using Doan_ThiTracNghiem.BLL;
using Doan_ThiTracNghiem.DAL;
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
        bool openfile = false;
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
                openfile = true;
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
            string maTK = XL.themMaUse();
            List<ChucNangTaiKhoan> lst = new List<ChucNangTaiKhoan>();
            ChucNangTaiKhoan cn = new ChucNangTaiKhoan();
            cn.MaTK = maTK;
            cn.MaCN = "CN001";
            ChucNangTaiKhoan cn2 = new ChucNangTaiKhoan();
            cn2.MaTK = maTK;
            cn2.MaCN = "CN002";
            lst.Add(cn);
            lst.Add(cn2);
            if (openfile)
                XL.themUseAsync(maTK, txt_TenDN.Text, txt_MK.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_NoiSinh.Text, dlg_openfile, pMaLoaitk, lst);
            else
                XL.themUseAsync(maTK, txt_TenDN.Text, txt_MK.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_NoiSinh.Text, null, pMaLoaitk, lst);

        }
        private void QuanLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
