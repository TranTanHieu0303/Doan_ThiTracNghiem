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
    public partial class frm_ThongTinCaNhan : Form
    {
        public TaiKhoan tk;
        bool fileoen = false;
        XuLy XL = new XuLy();
        Form _frm;
        public frm_ThongTinCaNhan(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void frm_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadDUlieu();
        }
        public void loadDUlieu()
        {
            txt_TenDN.Text = tk.Usename;
            txt_MK.Text = tk.Pass;
            txt_HoTen.Text = tk.HoTen;
            txt_NoiSinh.Text = tk.NoiSinh;
            if (tk.GioiTinh == "Nam")
                rdb_Nam.Checked = true;
            else
                rdb_Nu.Checked = true;
            dtp_NgaySinh.Value = tk.NgaySinh.Value;
            ptb_HinhAnh.ImageLocation = tk.HinhAnh;
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            dlg_openfile.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            dlg_openfile.Title = "Open an Image File";
            DialogResult dr = dlg_openfile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ptb_HinhAnh.Image = Image.FromFile(dlg_openfile.FileName);
                fileoen = true;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdb_Nam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            List<ChucNangTaiKhoan> lst = XL.loadQuyen(tk.MaUse);
            if (fileoen)
                XL.suaUseAsync(tk.MaUse, txt_TenDN.Text, txt_MK.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_NoiSinh.Text, dlg_openfile, tk.LoaiTK,lst);
            else
                XL.suaUseAsync(tk.MaUse, txt_TenDN.Text, txt_MK.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_NoiSinh.Text, null, tk.LoaiTK,lst);
        }

        private void QuanLai_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void frm_ThongTinCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
