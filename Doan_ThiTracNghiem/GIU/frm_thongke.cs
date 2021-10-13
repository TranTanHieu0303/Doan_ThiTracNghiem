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
    public partial class frm_thongke : Form
    {
        XuLy XL = new XuLy();
        public TaiKhoan tk;
        Form _frm;
        QLThiTracNghiemDataContext data = new QLThiTracNghiemDataContext();
        public frm_thongke(Form frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        private void frm_thongke_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XL.loaddulieuThongKe();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Cells[0].Value!=null)
            {
                XuLy.KetquaThongKe kq = XL.chisoKho(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                textBox1.Text = kq.chisokho.ToString();
                textBox2.Text = kq.chisophanbiet.ToString();
                textBox3.Text = kq.ketqua;
                NganHangCauHoi cauhoi = data.NganHangCauHois.FirstOrDefault(t => t.MaCH == dataGridView1.CurrentRow.Cells[0].Value.ToString());
                txt_noidung.Text = cauhoi.NoiDung;
                txt_A.Text = cauhoi.A;
                txt_B.Text = cauhoi.B;
                txt_C.Text = cauhoi.C;
                txt_D.Text = cauhoi.D;
            }    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_TrangChu frm = new frm_TrangChu(_frm);
            frm.tk = tk;
            frm.Show();
            this.Close();
        }
    }
}
