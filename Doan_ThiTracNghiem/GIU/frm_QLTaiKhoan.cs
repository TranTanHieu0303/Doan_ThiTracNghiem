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
        bool openfile = false;
        Form _frm;
        public frm_QLTaiKhoan(Form frm)
        {
            InitializeComponent();
            _frm = frm;
            loadDuLieu();
            
        }

        private void frm_QLTaiKhoan_Load(object sender, EventArgs e)
        {
            setControl(false);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }
        public void loadDuLieu()
        {
            dgv_danhsachtk.AutoGenerateColumns = false;
            dgv_danhsachtk.DataSource = Xl.loadUse();
            cbb_LoaiTK.DataSource = Xl.loadLoai();
            cbb_LoaiTK.DisplayMember = "Tenloai";
            cbb_LoaiTK.ValueMember = "Maloai";
            loadCN();
        }
        public void loadCN()
        {
            flp_manHinhCN.Controls.Clear();
            List<ChucNang> lst = Xl.loadChucNangAll();
            foreach(ChucNang item in lst)
            {
                CheckBox rdb = new CheckBox();
                rdb.Width = flp_manHinhCN.Width/2-10;
                rdb.Text = item.TenCN;
                rdb.Tag = item.MaCN;
                flp_manHinhCN.Controls.Add(rdb);
            }    
        }    
        public void checkChucNang(string pMa)
        {
            List<ChucNangTaiKhoan> lst = Xl.loadQuyen(pMa);
            foreach (Control i in flp_manHinhCN.Controls)
            {
                CheckBox a = (CheckBox)i;
                a.Checked = false;
            }
            foreach (ChucNangTaiKhoan item in lst)
            {
                foreach(Control i in flp_manHinhCN.Controls)
                {
                    CheckBox a = (CheckBox)i;
                    if (a.Tag.ToString() == item.MaCN.ToString())
                        a.Checked = true;
                }    
            }    
        }
        public void hienThiDuLieu(TaiKhoan taiKhoan)
        {
            if (taiKhoan != null)
            {
                txt_HoTen.Text = taiKhoan.HoTen;
                cbb_LoaiTK.SelectedValue = taiKhoan.LoaiTK;
                txt_MaTK.Text = taiKhoan.MaUse;
                txt_NoiSinh.Text = taiKhoan.NoiSinh;
                txt_TenDN.Text = taiKhoan.Usename;
                txt_Pass.Text = taiKhoan.Pass;
                dtp_NgaySinh.Value = (DateTime)taiKhoan.NgaySinh;
                ptb_HinhAnh.ImageLocation = taiKhoan.HinhAnh;
                if (taiKhoan.GioiTinh == "Nam")
                    rdb_Nam.Checked = true;
                else
                    rdb_Nu.Checked = true;
                checkChucNang(taiKhoan.MaUse);
            }
        }
        public void setControl(bool f)
        {
            btn_Them.Enabled = f;
            btn_Nhapexcel.Visible = f;
            btn_LuuExcel.Visible = f;
            btn_Xoa.Enabled = f;
            btn_CapNhat.Enabled = f;
            btn_LuuDaTa.Enabled = f;
            btn_Huy.Visible = f;
            btn_open.Visible = f;
            cbb_LoaiTK.Enabled = f;
            txt_MaTK.Enabled = f;
            txt_HoTen.Enabled = f;
            txt_NoiSinh.Enabled = f;
            txt_Pass.Enabled = f;
            txt_TenDN.Enabled = f;
            dtp_NgaySinh.Enabled = f;
            flp_manHinhCN.Enabled = f;
            rdb_Nam.Enabled = f;
            rdb_Nu.Enabled = f;
        }
        public void setTextNull()
        {
            txt_HoTen.Text = null;
            txt_NoiSinh.Text = null;
            txt_Pass.Text = null;
            txt_TenDN.Text = null;
        }
        public void hienthiexcel(DataGridViewRow dr)
        {
            txt_HoTen.Text = dr.Cells[1].Value.ToString();
            txt_NoiSinh.Text = dr.Cells[3].Value.ToString();
            dtp_NgaySinh.Value = (DateTime.Parse(dr.Cells[2].Value.ToString()));
            if (dr.Cells[4].Value.ToString() == "Nam")
                rdb_Nam.Checked = true;
            else
                rdb_Nu.Checked = true;
        }
        private void dgv_danhsachtk_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_danhsachtk.CurrentRow.Cells[0].Value != null)
            {
                hienThiDuLieu(Xl.loadTaiKhoan(dgv_danhsachtk.CurrentRow.Cells[0].Value.ToString()));
            }
            else
                if(dgv_danhsachtk.CurrentRow.Cells[1].Value != null)
            {
                hienthiexcel(dgv_danhsachtk.CurrentRow);
            }    
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            setTextNull();
            setControl(true);
            btn_Xoa.Enabled = false;
            btn_CapNhat.Enabled = false;
            //btn_Huy.Visible = true;
            btn_LuuExcel.Visible = false;
            txt_MaTK.Text = Xl.themMaUse();
            txt_MaTK.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            loadDuLieu();
            setControl(false);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            setControl(true);
            btn_Xoa.Enabled = false;
            btn_Them.Enabled = false;
            btn_Huy.Visible = true;
            txt_MaTK.Enabled = false;
        }

        private void btn_LuuDaTa_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdb_Nam.Checked)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";
            List<ChucNangTaiKhoan> lst = new List<ChucNangTaiKhoan>();
            foreach(Control item in flp_manHinhCN.Controls)
            {
                CheckBox a = (CheckBox)item;
                if(a.Checked)
                {
                    ChucNangTaiKhoan cn = new ChucNangTaiKhoan();
                    cn.MaCN = a.Tag.ToString();
                    cn.MaTK = txt_MaTK.Text;
                    lst.Add(cn);
                }    
            }    
            if(btn_Them.Enabled)
            {
                if (openfile)    
                    Xl.themUseAsync(txt_MaTK.Text, txt_TenDN.Text, txt_Pass.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value, txt_NoiSinh.Text, ofd_mofile, cbb_LoaiTK.SelectedValue.ToString(),lst);
                else
                    Xl.themUseAsync(txt_MaTK.Text, txt_TenDN.Text, txt_Pass.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value, txt_NoiSinh.Text, null, cbb_LoaiTK.SelectedValue.ToString(),lst);
                
            }
            else
            {
                if (openfile)
                    Xl.suaUseAsync(txt_MaTK.Text, txt_TenDN.Text, txt_Pass.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value, txt_NoiSinh.Text, ofd_mofile, cbb_LoaiTK.SelectedValue.ToString(), lst);
                else
                    Xl.suaUseAsync(txt_MaTK.Text, txt_TenDN.Text, txt_Pass.Text, txt_HoTen.Text, gioitinh, dtp_NgaySinh.Value, txt_NoiSinh.Text, null, cbb_LoaiTK.SelectedValue.ToString(), lst);

            }
            loadDuLieu();
            setControl(false);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            ofd_mofile.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            ofd_mofile.Title = "Open an Image File";
            DialogResult dr = ofd_mofile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ptb_HinhAnh.Image = Image.FromFile(ofd_mofile.FileName);
                openfile = true;
            }
        }

        private void cbb_LoaiTK_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiTK.SelectedValue != null)
            {
                foreach (Control i in flp_manHinhCN.Controls)
                {
                    CheckBox a = (CheckBox)i;
                    a.Checked = false;
                }
                if (cbb_LoaiTK.SelectedValue.ToString() == "LTK01")
                {
                    foreach (Control item in flp_manHinhCN.Controls)
                    {
                        CheckBox a = (CheckBox)item;
                        a.Checked = true;
                    }
                }
                else
                    if (cbb_LoaiTK.SelectedValue.ToString() == "LTK03")
                {
                    foreach (Control item in flp_manHinhCN.Controls)
                    {
                        CheckBox a = (CheckBox)item;
                        if (a.Tag.ToString() == "CN001" || a.Tag.ToString() == "CN002" || a.Tag.ToString() == "CN003"
                            || a.Tag.ToString() == "CN004" || a.Tag.ToString() == "CN006" ||
                            a.Tag.ToString() == "CN007")
                            a.Checked = true;

                    }
                }
                else
                    if (cbb_LoaiTK.SelectedValue.ToString() == "LTK02")
                {
                    foreach (Control item in flp_manHinhCN.Controls)
                    {
                        CheckBox a = (CheckBox)item;
                        if (a.Tag.ToString() == "CN001" || a.Tag.ToString() == "CN002")
                            a.Checked = true;

                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắn muốn xóa tài khoản này ???\nNhấp OK để xác nhận", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                if (!dgv_danhsachtk.MultiSelect)
                {
                    if (Xl.xoaUse(txt_MaTK.Text))
                        MessageBox.Show("Xóa Tài Khoản Thành Công");
                }else
                {
                    int dem = 0; 
                    foreach(DataGridViewRow item in dgv_danhsachtk.SelectedRows)
                    {
                        if (Xl.xoaUse(item.Cells[0].Value.ToString()))
                            dem++;

                    }
                    MessageBox.Show("Xóa "+dem+" Tài Khoản Thành Công");
                }    
            loadDuLieu();
            setControl(false);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void btn_Nhapexcel_Click(object sender, EventArgs e)
        {
            ofd_mofile.Filter = "Excel Workbook| *.xlsx | Excel Workbook 97 - 2003 | *.xls |All file|*.*";
            ofd_mofile.Title = "Open an Excel File";
            DialogResult dr = ofd_mofile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dgv_danhsachtk.DataSource = Xl.loadExcel(ofd_mofile).Tables[0];
                setTextNull();
                txt_MaTK.Text = null;
                btn_LuuExcel.Visible = true;
            }
        }

        private void txt_HoTen_Leave(object sender, EventArgs e)
        {
        }

        private void txt_HoTen_TextChanged(object sender, EventArgs e)
        {
            if(txt_HoTen.Text!="")
            dgv_danhsachtk.CurrentRow.Cells[1].Value = txt_HoTen.Text;
        }

        private void dtp_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dgv_danhsachtk.CurrentRow.Cells[2].Value = dtp_NgaySinh.Value.ToShortDateString();
        }

        private void txt_NoiSinh_TextChanged(object sender, EventArgs e)
        {
            if(txt_NoiSinh.Text!="")
            dgv_danhsachtk.CurrentRow.Cells[3].Value = txt_NoiSinh.Text;
        }

        private void rdb_Nam_CheckedChanged(object sender, EventArgs e)
        {
            dgv_danhsachtk.CurrentRow.Cells[4].Value = "Nam";
        }

        private void rdb_Nu_CheckedChanged(object sender, EventArgs e)
        {
            dgv_danhsachtk.CurrentRow.Cells[4].Value = "Nữ";
        }

        private void btn_LuuExcel_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (DataGridViewRow dgvr in dgv_danhsachtk.Rows)
            {
                List<ChucNangTaiKhoan> lst = new List<ChucNangTaiKhoan>();
                foreach (Control item in flp_manHinhCN.Controls)
                {
                    CheckBox a = (CheckBox)item;
                    if (a.Checked)
                    {
                        ChucNangTaiKhoan cn = new ChucNangTaiKhoan();
                        cn.MaCN = a.Tag.ToString();
                        cn.MaTK = Xl.themMaUse();
                        lst.Add(cn);
                    }
                }
                if (Xl.themTkExcel(cbb_LoaiTK.SelectedValue.ToString(), dgvr, lst))
                    dem++;
            }
            MessageBox.Show("Đã thêm "+dem+" Tài Khoản Thành Công");
            loadDuLieu();
            setControl(false);
            btn_Them.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }
    }
}
