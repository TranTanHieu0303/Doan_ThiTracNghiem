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
    public partial class frm_LichSuThi : Form
    {
        public TaiKhoan tk;
        XuLy XL = new XuLy();
        public frm_LichSuThi()
        {
            InitializeComponent();
        }

        private void frm_LichSuThi_Load(object sender, EventArgs e)
        {
            dgv_lichsu.AutoGenerateColumns = false;
            dgv_lichsu.DataSource = XL.loadLichSuThi(tk.MaUse);
            
        }
    }
}
