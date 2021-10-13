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
    public partial class frm_TrangChu : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        Form _frm;
        public frm_TrangChu(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            lbl_HoTen.Text = tk.HoTen;
            lbl_matk.Text = tk.MaUse;
            ptb_avatar.ImageLocation = tk.HinhAnh;
            foreach(Button item in flowLayoutPanel1.Controls)
            {
                foreach(ChucNangTaiKhoan cn in XL.loadQuyen(tk.MaUse))
                {
                    if(cn.MaCN==item.Tag.ToString())
                    {
                        item.Visible = true;
                        break;
                    }    
                    else
                        item.Visible = false;
                }    
            } 
            foreach(ToolStripMenuItem i in menu_QuanLy.Items)
            {
                foreach (ChucNangTaiKhoan cn in XL.loadQuyen(tk.MaUse))
                {

                    if (cn.MaCN == i.Tag.ToString())
                    {
                        i.Visible = true;
                        break;
                    }
                    else
                        i.Visible = false;
                }
            }    
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frm_ThongTinCaNhan frm = new frm_ThongTinCaNhan(_frm);
            frm.tk = tk;
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            menu_QuanLy.Show(btn_QuanLy, new Point(0, btn_QuanLy.Height));
        }

        private void stm_TaoKiThi_Click(object sender, EventArgs e)
        {
            frm_Taokithi frm = new frm_Taokithi();
            frm.tk = tk;
            frm.Show();
        }

        private void btn_ThiTheoLich_Click(object sender, EventArgs e)
        {
             
        }

        private void btn_lamBaiThi_Click(object sender, EventArgs e)
        {
            if (XL.loadMonThi(tk.MaUse).Count == 0)
            {
                MessageBox.Show("Hôm Nay bạn Không Có Lịch Thi");
            }
            else
            {
                frm_Chuanbi frm = new frm_Chuanbi(_frm);
                frm.tk = tk;
                frm.Show();
            }
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            frm_LichSuThi frm = new frm_LichSuThi(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void tsm_QLTK_Click(object sender, EventArgs e)
        {
            frm_QLTaiKhoan frm = new frm_QLTaiKhoan(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();

        }

        private void tsm_QLDeThi_Click(object sender, EventArgs e)
        {
            frm_QLDuLieu frm = new frm_QLDuLieu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_thongke frm = new frm_thongke(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }
    }
}
