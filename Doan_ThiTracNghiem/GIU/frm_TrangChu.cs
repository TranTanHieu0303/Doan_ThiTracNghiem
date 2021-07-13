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
        public frm_TrangChu()
        {
            InitializeComponent();
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
        }

        private void btn_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            frm_ThongTinCaNhan frm = new frm_ThongTinCaNhan();
            frm.tk = tk;
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            menu_QuanLy.Show(btn_QuanLy, new Point(0, btn_QuanLy.Height));
        }

        private void stm_TaoKiThi_Click(object sender, EventArgs e)
        {
            frm_Taokithi frm = new frm_Taokithi();
            frm.Show();
        }
    }
}
