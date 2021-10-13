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
    public partial class frm_LamBai : Form
    {
        public TaiKhoan tk;
        public LichThi lt;
        XuLy XL = new XuLy();
        QLThiTracNghiemDataContext data = new QLThiTracNghiemDataContext();
        DeThi deThi;
        MonThi mon;
        int phut = 0;
        int giay= 0;
        Cauhoi uschon;
        List<Sapxepde> sapxepdes;
        Form _frm;
        public frm_LamBai(Form frm)
        {
            InitializeComponent();
            _frm = frm;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_LamBai_Load(object sender, EventArgs e)
        {
            deThi = data.DeThis.FirstOrDefault(d => d.MaDe == lt.MaDe);
            mon = data.MonThis.FirstOrDefault(m => m.MaMon == deThi.MaMon);
            phut = deThi.ThoiGian.Value;
            lbl_KiThi.Text = lt.TenKyThi;
            lbl_MonThi.Text = mon.TenMon;
            lbl_ThgLam.Text = phut + " Phút";
            lbl_Thgcon.Text = phut + " Phút";
            lbl_MaDe.Text = deThi.MaDe;
            ptb_hinhAnh.ImageLocation = tk.HinhAnh;
            lbl_MaTK.Text = tk.MaUse;
            lbl_TenTK.Text = tk.HoTen;
            prb_thg.Maximum = phut * 60000;
            time_prb.Start();
            loadCauHoi(deThi.MaDe);
        }
        public void loadCauHoi(string mde)
        {
            sapxepdes = XL.tronDe(mde);
            foreach(Sapxepde item in sapxepdes)
            {
                Cauhoi cauhoi = new Cauhoi();
                cauhoi.ch = item;
                cauhoi.Tag = item.MaCH;
                cauhoi.rdb_A.Tag = item.MaCH;
                cauhoi.rdb_B.Tag = item.MaCH;
                cauhoi.rdb_C.Tag = item.MaCH;
                cauhoi.rdb_D.Tag = item.MaCH;
                cauhoi.Click += Cauhoi_Click;
                cauhoi.rdb_A.CheckedChanged += Rdb_A_CheckedChanged;
                cauhoi.rdb_B.CheckedChanged += Rdb_B_CheckedChanged;
                cauhoi.rdb_C.CheckedChanged += Rdb_C_CheckedChanged;
                cauhoi.rdb_D.CheckedChanged += Rdb_D_CheckedChanged; 
                if(item.STT==1)
                {
                    loadNoiDungCH(cauhoi);
                    Cauhoi_Click(cauhoi, EventArgs.Empty);
                }
                
                layout_cauhoi.Controls.Add(cauhoi);
            }
        }

        private void Rdb_D_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                if (r.Tag == rdb_CauA.Tag)
                    rdb_CauD.Checked = true;
        }

        private void Rdb_C_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                if (r.Tag == rdb_CauA.Tag)
                rdb_CauC.Checked = true;
        }

        private void Rdb_B_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                if (r.Tag == rdb_CauA.Tag)
                rdb_CauB.Checked = true;
        }

        private void Rdb_A_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
                if (r.Tag == rdb_CauA.Tag)
                rdb_CauA.Checked = true;
        }

        public void loadNoiDungCH(Cauhoi s)
        {
            lbl_STT.Text = "Câu hỏi " + s.ch.STT + " :";
            lbl_noidung.Text = s.ch.NoiDung;
            rdb_CauA.Text = "A:" + s.ch.A;
            rdb_CauA.Tag = s.ch.MaCH;
            rdb_CauB.Text = "B:" + s.ch.B;
            rdb_CauB.Tag = s.ch.MaCH;
            rdb_CauC.Text = "C:" + s.ch.C;
            rdb_CauC.Tag = s.ch.MaCH;
            rdb_CauD.Text = "D:" + s.ch.D;
            rdb_CauD.Tag = s.ch.MaCH;
            if(s.ch.dapanchon!=null)
            {
                if(s.ch.dapanchon=="A")
                    rdb_CauA.Checked = true;
                if (s.ch.dapanchon == "B")
                    rdb_CauB.Checked = true;
                if (s.ch.dapanchon == "C")
                    rdb_CauC.Checked = true;
                if (s.ch.dapanchon == "D")
                    rdb_CauD.Checked = true;
            }
            else
            {
                rdb_CauA.Checked = false;
                rdb_CauB.Checked = false;
                rdb_CauC.Checked = false;
                rdb_CauD.Checked = false;
            }
            

        }
        private void Cauhoi_Click(object sender, EventArgs e)
        {
            Cauhoi cau = (Cauhoi)sender;
            cau.BackColor = Color.Aquamarine;
            loadNoiDungCH(cau);
            if(uschon!=null)
            {
                uschon.BackColor = Color.White;
            }
            uschon = cau;
        }

        private void time_prb_Tick(object sender, EventArgs e)
        {
            if (phut > 0)
            {
                if (giay > 0)
                {
                    giay--;
                }
                else
                {
                    phut--;
                    giay = 59;
                }
            }
            else
            {
                if (phut == 0 && giay == 0)
                {
                    time_prb.Stop();
                    MessageBox.Show("Bạn đã hết thời gian làm bài");
                    if (XL.luuBaiLam(sapxepdes, tk.MaUse, deThi.MaDe, lt.MaLT, DateTime.Now))
                    {
                        MessageBox.Show("Nộp bài thành công.");
                        this.Close();
                        frm_TrangChu frm = new frm_TrangChu(_frm);
                        frm.tk = tk;
                        frm.Show();
                        this.Close();
                    }
                }
            }
            lbl_Thgcon.Text = phut + ":" + giay;
            prb_thg.PerformStep();
        }

        private void rdb_CauA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CauA.Checked)
            {
                foreach (Control item in layout_cauhoi.Controls)
                {
                    Cauhoi c = (Cauhoi)item;
                    if (c.Tag == rdb_CauA.Tag)
                    {
                        c.rdb_A.Checked = true;
                        
                    }
                }
            }
        }

        private void rdb_CauB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CauB.Checked)
            {
                foreach (Control item in layout_cauhoi.Controls)
                {
                    Cauhoi c = (Cauhoi)item;
                    if (c.Tag == rdb_CauB.Tag)
                    {
                        c.rdb_B.Checked = true;
                       
                    }
                }
            }
        }

        private void rdb_CauC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CauC.Checked)
            {
                foreach (Control item in layout_cauhoi.Controls)
                {
                    Cauhoi c = (Cauhoi)item;
                    if (item.Tag == rdb_CauC.Tag)
                    {
                        c.rdb_C.Checked = true;
                        
                    }
                }
            }
        }

        private void rdb_CauD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_CauD.Checked)
            {
                foreach (Control item in layout_cauhoi.Controls)
                {
                    Cauhoi c = (Cauhoi)item;
                    if (item.Tag == rdb_CauD.Tag)
                    {
                        c.rdb_D.Checked = true;
                        
                    }
                }
            }
        }

        private void btn_CauSau_Click(object sender, EventArgs e)
        {
            int stt=0;
            foreach (Control item in layout_cauhoi.Controls)
            {
                Cauhoi cauhoi = (Cauhoi)item;
                if (cauhoi.BackColor == Color.Aquamarine)
                {
                    stt = cauhoi.ch.STT;
                }
            }
            foreach (Control item in layout_cauhoi.Controls)
            {
                Cauhoi cauhoi = (Cauhoi)item;
                if (cauhoi.ch.STT == stt+1)
                {
                    Cauhoi_Click(cauhoi, EventArgs.Empty);
                }
            }
        }

        private void btn_CauTrc_Click(object sender, EventArgs e)
        {
            int stt = 0;
            foreach (Control item in layout_cauhoi.Controls)
            {
                Cauhoi cauhoi = (Cauhoi)item;
                if (cauhoi.BackColor == Color.Aquamarine)
                {
                    stt = cauhoi.ch.STT;
                }
            }
            foreach (Control item in layout_cauhoi.Controls)
            {
                Cauhoi cauhoi = (Cauhoi)item;
                if (cauhoi.ch.STT == stt - 1)
                {
                    Cauhoi_Click(cauhoi, EventArgs.Empty);
                }
            }
        }

        private void btn_NopBai_Click(object sender, EventArgs e)
        {
            if(XL.luuBaiLam(sapxepdes,tk.MaUse,deThi.MaDe,lt.MaLT,DateTime.Now))
            {
                MessageBox.Show("Nộp bài thành công.");
                this.Close();
                frm_TrangChu frm = new frm_TrangChu(_frm);
                frm.tk = tk;
                frm.Show();
                this.Close();
            }    
        }
    }
}
