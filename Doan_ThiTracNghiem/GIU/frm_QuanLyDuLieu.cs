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
    
    public partial class frm_QLDuLieu : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        QLThiTracNghiemDataContext data = new QLThiTracNghiemDataContext();
        int lstLoad = 0;
        Form _frm;
        public frm_QLDuLieu(Form frm)
        {
            InitializeComponent();
            _frm = frm;
            loadDuLieu();
            cbb_lichthi.DataSource = XL.loadLich();
            cbb_lichthi.DisplayMember = "TenKyThi";
            cbb_lichthi.ValueMember = "MaLT";
            dgv_DanhSach.DataSource = XL.loadUse();


        }
        public void setcontrol()
        {
            txt_MaMon.Enabled = false;
            cbb_TenMon.Enabled = false;
            txt_maDe.Enabled = false;
            cbb_TenDe.Enabled = false;
            txt_ThoiGian.Enabled = false;
            txt_SoCau.Enabled = false;
            txt_MaCH.Enabled = false;
            txt_DapAn.Enabled = false;
            txt_NoiDung.Enabled = false;
            txt_A.Enabled = false;
            txt_B.Enabled = false;
            txt_C.Enabled = false;
            txt_D.Enabled = false;
        }
        private void frm_QLDuLieu_Load(object sender, EventArgs e)
        {
            btn_Huy_mon.Visible = false;
            btn_Luu_mon.Visible = false;
            btn_Huy_De.Visible = false;
            btn_Luu_De.Visible = false;
            setcontrol();
        }
        public void loadDuLieu()
        {
            cbb_TenMon.DataSource = XL.loadMon();
            cbb_TenMon.DisplayMember = "TenMon";
            cbb_TenMon.ValueMember = "MaMon";
            cbb_MaMon.DataSource = XL.loadMon();
            cbb_MaMon.DisplayMember = "TenMon";
            cbb_MaMon.ValueMember = "MaMon";
        }

        public void loadCauHoi(DataGridViewRow dgvR)
        {
            txt_MaCH.Text = dgvR.Cells[0].Value.ToString();
            txt_NoiDung.Text = dgvR.Cells[1].Value.ToString();
            txt_A.Text = dgvR.Cells[2].Value.ToString();
            txt_B.Text = dgvR.Cells[3].Value.ToString();
            txt_C.Text = dgvR.Cells[4].Value.ToString();
            txt_D.Text = dgvR.Cells[5].Value.ToString();
            txt_DapAn.Text = dgvR.Cells[6].Value.ToString();
        }
        public void loadGirdView(int a)
        {
            if (a == 0)
            {
                dgv_CauHoi.AutoGenerateColumns = false;
                dgv_CauHoi.DataSource = XL.loadNganHangCauHoi(txt_MaMon.Text);
            }
            else
                if (a == 1)
            {
                dgv_CauHoi.AutoGenerateColumns = false;
                dgv_CauHoi.DataSource = XL.loadNoiDungDe(txt_maDe.Text);
            }    
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbb_TenMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb_TenMon.SelectedValue != null)
            {
                cbb_TenDe.DataSource = XL.loadDetheoMon(cbb_TenMon.SelectedValue.ToString());
                cbb_TenDe.DisplayMember = "TenDe";
                cbb_TenDe.ValueMember = "MaDe";
                txt_MaMon.Text = cbb_TenMon.SelectedValue.ToString();
            }
        }

        private void load_TheoMon_Click(object sender, EventArgs e)
        {
            loadGirdView(0);
            lstLoad = 0;
        }

        private void load_theode_Click(object sender, EventArgs e)
        {
            loadGirdView(1);
            lstLoad = 1;
        }

        private void cbb_TenDe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb_TenDe.SelectedValue != null)
            {
                txt_maDe.Text = cbb_TenDe.SelectedValue.ToString();
                DeThi de = data.DeThis.FirstOrDefault(d => d.MaDe == txt_maDe.Text);
                txt_ThoiGian.Text = de.ThoiGian.ToString();
                txt_SoCau.Text = de.SoCau.ToString();
                if (lstLoad == 1)
                    loadGirdView(1);
            }
        }

        private void dgv_CauHoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_CauHoi.CurrentRow.Cells[0].Value != null)
                if (dgv_CauHoi.CurrentRow.Cells[1].Value != null)
                    loadCauHoi(dgv_CauHoi.CurrentRow);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void btn_them_De_Click(object sender, EventArgs e)
        {
            btn_Xoa_de.Visible = false;
            btn_CapNhat_De.Visible = false;
            btn_Luu_De.Visible = true;
            btn_Huy_De.Visible = true;
            txt_maDe.Text = XL.themMaDe();
            cbb_TenDe.Enabled = true;
            txt_ThoiGian.Enabled = true;
            txt_SoCau.Enabled = true;
            loadGirdView(0);
        }

        private void btn_Huy_De_Click(object sender, EventArgs e)
        {
            btn_Xoa_de.Visible = true;
            btn_CapNhat_De.Visible = true;
            btn_them_De.Visible = true;
            btn_Luu_De.Visible = false;
            btn_Huy_De.Visible = false;
            cbb_TenDe.DataSource = XL.loadDetheoMon(cbb_TenMon.SelectedValue.ToString());
            cbb_TenDe.DisplayMember = "TenDe";
            cbb_TenDe.ValueMember = "MaDe";
            loadGirdView(1);
        }

        private void btn_Xoa_de_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_De_Click(object sender, EventArgs e)
        {
            btn_Xoa_de.Visible = false;
            btn_them_De.Visible = false;
            btn_Luu_De.Visible = true;
            btn_Huy_De.Visible = true;
        }

        private void btn_Them_Mon_Click(object sender, EventArgs e)
        {
            btn_Xoa_Mon.Visible = false;
            btn_CapNhat_Mon.Visible = false;
            btn_Luu_mon.Visible = true;
            btn_Huy_mon.Visible = true;
            txt_MaMon.Text = XL.themMaMon();
            cbb_TenMon.Enabled = true;

        }

        private void btn_CapNhat_Mon_Click(object sender, EventArgs e)
        {
            btn_Xoa_Mon.Visible = false;
            btn_Them_Mon.Visible = false;
            btn_Luu_mon.Visible = true;
            btn_Huy_mon.Visible = true;
            
        }

        private void btn_Huy_mon_Click(object sender, EventArgs e)
        {
            btn_Xoa_Mon.Visible = true;
            btn_CapNhat_Mon.Visible = true;
            btn_Them_Mon.Visible = true;
            btn_Luu_mon.Visible = false;
            btn_Huy_mon.Visible = false;
            loadDuLieu();
        }

        private void btn_Luu_mon_Click(object sender, EventArgs e)
        {
            if (btn_Them_Mon.Visible)
                if (XL.themMonThi(txt_MaMon.Text, cbb_TenMon.Text))
                    MessageBox.Show("Thêm Môn Thi Tành Công");
            else
                if(XL.suaMonThi(txt_MaMon.Text, cbb_TenMon.Text))
                    MessageBox.Show("Cập Nhật Môn Thi Tành Công");
            loadDuLieu();
        }
        public void setnull()
        {
            txt_DapAn.Text = null;
            txt_NoiDung.Text = null;
            txt_A.Text = null;
            txt_B.Text = null;
            txt_C.Text = null;
            txt_D.Text = null;
        }
        private void btn_Them_CauHoi_Click(object sender, EventArgs e)
        {
            txt_MaCH.Text = XL.themMaCauHoi();
            btn_Huy_CauHoi.Visible = true;
            txt_DapAn.Enabled = true;
            txt_NoiDung.Enabled = true;
            txt_A.Enabled = true;
            txt_B.Enabled = true;
            txt_C.Enabled = true;
            txt_D.Enabled = true;
            btn_Xoa_CauHoi.Enabled = false;
            btn_CapNhat_CauHoi.Enabled = false;
            setnull();
        }

        private void btn_Huy_CauHoi_Click(object sender, EventArgs e)
        {
            btn_CapNhat_CauHoi.Enabled = true;
            btn_Xoa_CauHoi.Enabled = true;
            btn_Them_CauHoi.Enabled = true;
            btn_Huy_CauHoi.Visible = false;
            setcontrol();
            loadGirdView(0);
        }

        private void btn_Luu_CauHoi_Click(object sender, EventArgs e)
        {
            if (btn_Them_CauHoi.Enabled)
            {
                if (XL.Them_CauHoi(txt_MaMon.Text, txt_MaCH.Text, txt_NoiDung.Text, txt_A.Text, txt_B.Text, txt_C.Text, txt_D.Text, txt_DapAn.Text.ToCharArray()[0]))
                    MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                if(XL.suaCauHoi(txt_MaMon.Text, txt_MaCH.Text, txt_NoiDung.Text, txt_A.Text, txt_B.Text, txt_C.Text, txt_D.Text, txt_DapAn.Text.ToCharArray()[0]))
                    MessageBox.Show("Cập Nhật Thành Công");
            }
            btn_CapNhat_CauHoi.Enabled = true;
            btn_Xoa_CauHoi.Enabled = true;
            btn_Them_CauHoi.Enabled = true;
            btn_Huy_CauHoi.Visible = false;
            setcontrol();
            loadGirdView(0);
        }

        private void btn_Xoa_CauHoi_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa dữa liệu này không","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                if (XL.xoaCauHoi(txt_MaCH.Text))
                    MessageBox.Show("Xóa Thành Công");
            setcontrol();
            loadGirdView(0);
            
        }

        private void btn_CapNhat_CauHoi_Click(object sender, EventArgs e)
        {
            btn_Huy_CauHoi.Visible = true;
            txt_DapAn.Enabled = true;
            txt_NoiDung.Enabled = true;
            txt_A.Enabled = true;
            txt_B.Enabled = true;
            txt_C.Enabled = true;
            txt_D.Enabled = true;
            btn_Xoa_CauHoi.Enabled = false;
            btn_Them_CauHoi.Enabled = false;
        }

        private void btn_Mofile_Excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dgv_CauHoi.DataSource = XL.loadExcel(ofd).Tables[0];
            }
        }

        private void btn_Luu_Excel_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach(DataGridViewRow item in dgv_CauHoi.Rows)
            {
                string mach = XL.themMaCauHoi();
                if (XL.Them_CauHoi(txt_MaMon.Text, mach, item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString().ToCharArray()[0]))
                    dem++;
            }
            MessageBox.Show("Đã thêm " + dem + " câu vào database");
        }

        private void btn_TronDe_Click(object sender, EventArgs e)
        {
            dgv_CauHoi.DataSource = XL.taoDeNgauNhieu(cbb_TenMon.SelectedValue.ToString(), int.Parse(txt_SoCau.Text));
        }

        private void btn_Luu_De_Click(object sender, EventArgs e)
        {
            XL.themDe(txt_maDe.Text, cbb_TenDe.Text, cbb_TenMon.SelectedValue.ToString(),int.Parse(txt_ThoiGian.Text),int.Parse(txt_SoCau.Text));
            bool kt = true;    
            foreach (DataGridViewRow item in dgv_CauHoi.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        if (!XL.themNoidungDe(txt_maDe.Text, item.Cells[0].Value.ToString()))
                            kt = false;
                    }
                }
                if (kt == true)
                {
                    MessageBox.Show("Thành Công", "Thông Báo");
                }
            btn_Xoa_de.Visible = true;
            btn_CapNhat_De.Visible = true;
            btn_them_De.Visible = true;
            btn_Luu_De.Visible = false;
            btn_Huy_De.Visible = false;
            cbb_TenDe.DataSource = XL.loadDetheoMon(cbb_TenMon.SelectedValue.ToString());
            cbb_TenDe.DisplayMember = "TenDe";
            cbb_TenDe.ValueMember = "MaDe";
            loadGirdView(1);
        }

        private void cbb_lichthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_lichthi.SelectedValue!=null)
            {
                LichThi lt = data.LichThis.FirstOrDefault(t => t.MaLT == cbb_lichthi.SelectedValue.ToString());
                
                if (lt != null)
                {
                    txt_MaLT.Text = cbb_lichthi.SelectedValue.ToString();
                    dtp_ngaythi.Value = lt.NgayThi.Value;
                    dtp_giothi.Value = lt.NgayThi.Value;
                    dataGridView1.DataSource = XL.loadngthamgia(txt_MaLT.Text);
                }

            }    
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txt_MaLT.Text = XL.themMaLichThi();
        }

        private void cbb_MaMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_MaMon.SelectedValue != null)
            {
                Cbb_MaDe.DataSource = XL.loadDetheoMon(cbb_MaMon.SelectedValue.ToString());
                Cbb_MaDe.DisplayMember = "TenDe";
                Cbb_MaDe.ValueMember = "MaDe";
                
            }

        }

        private void cbb_TenMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DateTime myDate = dtp_ngaythi.Value.Date +
                    dtp_giothi.Value.TimeOfDay;
            if (XL.themLichThi(txt_MaLT.Text, tk.MaUse, Cbb_MaDe.SelectedValue.ToString(),myDate, cbb_lichthi.Text))
            {
                MessageBox.Show("Thành Công", "Thông Báo");
            }
            cbb_lichthi.DataSource = XL.loadLich();
            cbb_lichthi.DisplayMember = "TenKyThi";
            cbb_lichthi.ValueMember = "MaLT";

        }

        private void btn_AddTK_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSach.MultiSelect)
            {
                foreach (DataGridViewRow item in dgv_DanhSach.SelectedRows)
                {
                    XL.themNguoiThamGiaThi(txt_MaLT.Text, item.Cells[0].Value.ToString());
                }
            }
            else
            {
                XL.themNguoiThamGiaThi(txt_MaLT.Text, dgv_DanhSach.CurrentRow.Cells[0].Value.ToString());
            }
            dataGridView1.DataSource = XL.loadngthamgia(txt_MaLT.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LichThi lt = data.LichThis.FirstOrDefault(t => t.MaLT == cbb_lichthi.SelectedValue.ToString());
            DateTime myDate = dtp_ngaythi.Value.Date +
                    dtp_giothi.Value.TimeOfDay;
            if (XL.suaLichThi(txt_MaLT.Text, tk.MaUse, lt.MaDe, myDate, cbb_lichthi.Text))
            {
                MessageBox.Show("Thành Công", "Thông Báo");
            }
            cbb_lichthi.DataSource = XL.loadLich();
            cbb_lichthi.DisplayMember = "TenKyThi";
            cbb_lichthi.ValueMember = "MaLT";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void frm_QLDuLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
        }
    }
}
