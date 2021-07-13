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
    public partial class frm_Taokithi : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        string maLT;
        public frm_Taokithi()
        {
            InitializeComponent();
        }

        private void frm_TaoKiThi_Load(object sender, EventArgs e)
        {
            cbb_TenMon.DataSource = XL.loadMon();
            cbb_TenMon.DisplayMember = "TenMon";
            cbb_TenMon.ValueMember = "MaMon";
            btn_TaoDe.Visible = false;
            cbb_taikhoan.DataSource = XL.loadTaiKhoanTheoLoai("LTK02");
            cbb_taikhoan.DisplayMember = "HoTen";
            cbb_taikhoan.ValueMember = "MaUse";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_inputExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = XL.loadExcel(ofd).Tables[0];
                txt_soccau.Value = dataGridView1.Rows.Count-1;
                
            }
        }

        private void btn_LuuDe_Click(object sender, EventArgs e)
        {
            maLT = XL.themMaLichThi();
            string made = XL.themMaDe();
            if (txt_TenDe.Text == "")
            {
                MessageBox.Show("Hãy Nhập Tên Đề");
                txt_TenDe.Focus();
            }
            else
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu trổng");
            }
            else
            {
                
                XL.themDe(made, txt_TenDe.Text, cbb_TenMon.SelectedValue.ToString(), ((int)txt_thoigian.Value));
                if (cbb_chonloaide.SelectedIndex == 0)
                {
                    bool kt = true;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (item.Cells[0].Value != null)
                        {
                            string ma = XL.themMaCauHoi();
                            string mamon = cbb_TenMon.SelectedValue.ToString();
                            if (!XL.Them_CauHoi(mamon, ma, item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString(), item.Cells[3].Value.ToString(), item.Cells[4].Value.ToString(), item.Cells[5].Value.ToString().ToCharArray()[0]))
                            {
                                kt = false;
                            }
                            XL.themNoidungDe(made, ma);

                        }
                    }
                    if (kt == true)
                    {
                        MessageBox.Show("Thành Công", "Thông Báo");
                    }
                }
                else
                { 
                    bool kt = true;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (item.Cells[0].Value != null)
                        {
                            if (!XL.themNoidungDe(made, item.Cells[0].Value.ToString()))
                                kt = false;
                        }
                    }
                    if (kt == true)
                    {
                        MessageBox.Show("Thành Công", "Thông Báo");
                    }
                }    

            }
            DateTime myDate = dtp_ngaythi.Value.Date +
                    dtp_giothi.Value.TimeOfDay;
            if (XL.themLichThi(maLT,tk.MaUse,made,myDate,txt_tenkythi.Text))
            {
                MessageBox.Show("Thành Công", "Thông Báo");
            }    
        }

        private void cbb_chonloaide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chonloaide.SelectedIndex == 0)
            {
                btn_inputExcel.Enabled = true;
                btn_TaoDe.Visible = false;
            }
            else
            {
                btn_inputExcel.Enabled = false;
                btn_TaoDe.Visible = true;
                dataGridView1.DataSource = XL.loadNganHangCauHoi(cbb_TenMon.SelectedValue.ToString());
                txt_soccau.Focus();
            }    
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void btn_TaoDe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XL.taoDeNgauNhieu(cbb_TenMon.SelectedValue.ToString(),((int)txt_soccau.Value));
        }

        private void btn_AddTS_Click(object sender, EventArgs e)
        {
        }

        private void btn_AddTK_Click(object sender, EventArgs e)
        {
            XL.themNguoiThamGiaThi(maLT, cbb_taikhoan.SelectedValue.ToString());
            dgv_TSThamGia.DataSource = XL.loadTkThamGiaThi();
        }

        private void btn_RemoTK_Click(object sender, EventArgs e)
        {
            XL.xoaNguoiThamGiaThi(dgv_TSThamGia.CurrentRow.Cells[0].Value.ToString());
            dgv_TSThamGia.DataSource = XL.loadTkThamGiaThi();
        }
    }
}
