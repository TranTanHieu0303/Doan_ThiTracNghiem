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
    public partial class frm_Chuanbi : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        QLThiTracNghiemDataContext data = new QLThiTracNghiemDataContext();
        LichThi licht;
        Form _frm;
        public frm_Chuanbi(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }

        private void frm_Chuanbi_Load(object sender, EventArgs e)
        {
            
        }

        private void cbb_LichThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LichThi.SelectedValue != null)
            {
                LichThi lt = data.LichThis.FirstOrDefault(t => t.MaLT == cbb_LichThi.SelectedValue.ToString());
                if (lt != null)
                {
                    licht = lt;
                    lbl_NgayThi.Text = licht.NgayThi.Value.ToLongDateString();
                    timer1.Start();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan thgian = (licht.NgayThi.Value - DateTime.Now);
            if (thgian.Hours > 0)
                lbl_Tgconlai.Text = thgian.Hours.ToString() + " Giờ " + thgian.Minutes.ToString() + " Phút " + thgian.Seconds.ToString() + " Giây";
            else
                if (thgian.Minutes > 0)
                lbl_Tgconlai.Text = thgian.Minutes.ToString() + " Phút " + thgian.Seconds.ToString() + " Giây";
            else

                    if (thgian.Seconds > 0)
                lbl_Tgconlai.Text = thgian.Seconds.ToString() + " Giây";
            else
            {
                timer1.Stop();
                DialogResult dr= MessageBox.Show("Bạn Có Thể Bắt đầu làm bài.\nNhấn OK Để Bắt Đầu", "Bắt Đầu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(dr== DialogResult.OK)
                {
                    frm_LamBai frm = new frm_LamBai(_frm);
                    frm.tk = tk;
                    frm.lt = licht;
                    frm.Show();
                    this.Close();
                }    
            }    
        }

        private void cbb_LichThi_DropDown(object sender, EventArgs e)
        {
            cbb_LichThi.DataSource = XL.loadMonThi(tk.MaUse, DateTime.Now);
            cbb_LichThi.DisplayMember = "TenKyThi";
            cbb_LichThi.ValueMember = "MaLT";
        }

        private void frm_Chuanbi_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
