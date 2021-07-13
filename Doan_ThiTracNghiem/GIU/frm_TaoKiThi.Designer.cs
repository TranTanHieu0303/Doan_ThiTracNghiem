
namespace Doan_ThiTracNghiem.GIU
{
    partial class frm_Taokithi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_TenMon = new System.Windows.Forms.ComboBox();
            this.dtp_ngaythi = new System.Windows.Forms.DateTimePicker();
            this.dtp_giothi = new System.Windows.Forms.DateTimePicker();
            this.txt_thoigian = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_chonloaide = new System.Windows.Forms.ComboBox();
            this.txt_soccau = new System.Windows.Forms.NumericUpDown();
            this.txt_TenDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RemoTK = new System.Windows.Forms.Button();
            this.btn_AddTK = new System.Windows.Forms.Button();
            this.cbb_taikhoan = new System.Windows.Forms.ComboBox();
            this.dgv_TSThamGia = new System.Windows.Forms.DataGridView();
            this.btn_TaoDe = new System.Windows.Forms.Button();
            this.btn_LuuDe = new System.Windows.Forms.Button();
            this.btn_inputExcel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tenkythi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soccau)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSThamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Kì Thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(363, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian làm bài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(363, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Loại Đề";
            // 
            // cbb_TenMon
            // 
            this.cbb_TenMon.FormattingEnabled = true;
            this.cbb_TenMon.Location = new System.Drawing.Point(139, 87);
            this.cbb_TenMon.Name = "cbb_TenMon";
            this.cbb_TenMon.Size = new System.Drawing.Size(195, 21);
            this.cbb_TenMon.TabIndex = 5;
            // 
            // dtp_ngaythi
            // 
            this.dtp_ngaythi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaythi.Location = new System.Drawing.Point(139, 109);
            this.dtp_ngaythi.Name = "dtp_ngaythi";
            this.dtp_ngaythi.Size = new System.Drawing.Size(100, 20);
            this.dtp_ngaythi.TabIndex = 6;
            // 
            // dtp_giothi
            // 
            this.dtp_giothi.CustomFormat = "";
            this.dtp_giothi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_giothi.Location = new System.Drawing.Point(245, 110);
            this.dtp_giothi.Name = "dtp_giothi";
            this.dtp_giothi.ShowUpDown = true;
            this.dtp_giothi.Size = new System.Drawing.Size(89, 20);
            this.dtp_giothi.TabIndex = 7;
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Location = new System.Drawing.Point(484, 116);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(43, 20);
            this.txt_thoigian.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 264);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbb_chonloaide
            // 
            this.cbb_chonloaide.FormattingEnabled = true;
            this.cbb_chonloaide.Items.AddRange(new object[] {
            "Nhập từ Excel",
            "Lọc từ ngân hàng đề"});
            this.cbb_chonloaide.Location = new System.Drawing.Point(485, 89);
            this.cbb_chonloaide.Name = "cbb_chonloaide";
            this.cbb_chonloaide.Size = new System.Drawing.Size(195, 21);
            this.cbb_chonloaide.TabIndex = 11;
            this.cbb_chonloaide.SelectedIndexChanged += new System.EventHandler(this.cbb_chonloaide_SelectedIndexChanged);
            // 
            // txt_soccau
            // 
            this.txt_soccau.Location = new System.Drawing.Point(604, 117);
            this.txt_soccau.Name = "txt_soccau";
            this.txt_soccau.Size = new System.Drawing.Size(35, 20);
            this.txt_soccau.TabIndex = 13;
            // 
            // txt_TenDe
            // 
            this.txt_TenDe.Location = new System.Drawing.Point(763, 91);
            this.txt_TenDe.Name = "txt_TenDe";
            this.txt_TenDe.Size = new System.Drawing.Size(138, 20);
            this.txt_TenDe.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(694, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên Đề";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(552, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số Câu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RemoTK);
            this.groupBox1.Controls.Add(this.btn_AddTK);
            this.groupBox1.Controls.Add(this.cbb_taikhoan);
            this.groupBox1.Controls.Add(this.dgv_TSThamGia);
            this.groupBox1.Location = new System.Drawing.Point(485, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 274);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Thí Sinh Tham Gia";
            // 
            // btn_RemoTK
            // 
            this.btn_RemoTK.AutoSize = true;
            this.btn_RemoTK.Image = global::Doan_ThiTracNghiem.Properties.Resources.profile_remove_icon;
            this.btn_RemoTK.Location = new System.Drawing.Point(357, 10);
            this.btn_RemoTK.Name = "btn_RemoTK";
            this.btn_RemoTK.Size = new System.Drawing.Size(38, 38);
            this.btn_RemoTK.TabIndex = 22;
            this.btn_RemoTK.UseVisualStyleBackColor = true;
            this.btn_RemoTK.Click += new System.EventHandler(this.btn_RemoTK_Click);
            // 
            // btn_AddTK
            // 
            this.btn_AddTK.AutoSize = true;
            this.btn_AddTK.Image = global::Doan_ThiTracNghiem.Properties.Resources.Actions_contact_new_icon__1_;
            this.btn_AddTK.Location = new System.Drawing.Point(299, 10);
            this.btn_AddTK.Name = "btn_AddTK";
            this.btn_AddTK.Size = new System.Drawing.Size(38, 38);
            this.btn_AddTK.TabIndex = 21;
            this.btn_AddTK.UseVisualStyleBackColor = true;
            this.btn_AddTK.Click += new System.EventHandler(this.btn_AddTK_Click);
            // 
            // cbb_taikhoan
            // 
            this.cbb_taikhoan.FormattingEnabled = true;
            this.cbb_taikhoan.Items.AddRange(new object[] {
            "Nhập từ Excel",
            "Lọc từ ngân hàng đề"});
            this.cbb_taikhoan.Location = new System.Drawing.Point(6, 19);
            this.cbb_taikhoan.Name = "cbb_taikhoan";
            this.cbb_taikhoan.Size = new System.Drawing.Size(260, 21);
            this.cbb_taikhoan.TabIndex = 20;
            // 
            // dgv_TSThamGia
            // 
            this.dgv_TSThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TSThamGia.Location = new System.Drawing.Point(8, 54);
            this.dgv_TSThamGia.Name = "dgv_TSThamGia";
            this.dgv_TSThamGia.Size = new System.Drawing.Size(410, 203);
            this.dgv_TSThamGia.TabIndex = 1;
            // 
            // btn_TaoDe
            // 
            this.btn_TaoDe.AutoSize = true;
            this.btn_TaoDe.Image = global::Doan_ThiTracNghiem.Properties.Resources.button_round_random_icon__1_;
            this.btn_TaoDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoDe.Location = new System.Drawing.Point(394, 142);
            this.btn_TaoDe.Name = "btn_TaoDe";
            this.btn_TaoDe.Size = new System.Drawing.Size(98, 38);
            this.btn_TaoDe.TabIndex = 18;
            this.btn_TaoDe.Text = "Tạo Bộ Đề";
            this.btn_TaoDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TaoDe.UseVisualStyleBackColor = true;
            this.btn_TaoDe.Click += new System.EventHandler(this.btn_TaoDe_Click);
            // 
            // btn_LuuDe
            // 
            this.btn_LuuDe.AutoSize = true;
            this.btn_LuuDe.Image = global::Doan_ThiTracNghiem.Properties.Resources.ok_icon;
            this.btn_LuuDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LuuDe.Location = new System.Drawing.Point(629, 141);
            this.btn_LuuDe.Name = "btn_LuuDe";
            this.btn_LuuDe.Size = new System.Drawing.Size(122, 40);
            this.btn_LuuDe.TabIndex = 14;
            this.btn_LuuDe.Text = "Xác Nhận Chọn";
            this.btn_LuuDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LuuDe.UseVisualStyleBackColor = true;
            this.btn_LuuDe.Click += new System.EventHandler(this.btn_LuuDe_Click);
            // 
            // btn_inputExcel
            // 
            this.btn_inputExcel.AutoSize = true;
            this.btn_inputExcel.Image = global::Doan_ThiTracNghiem.Properties.Resources.excel_xls_icon__1_;
            this.btn_inputExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inputExcel.Location = new System.Drawing.Point(26, 145);
            this.btn_inputExcel.Name = "btn_inputExcel";
            this.btn_inputExcel.Size = new System.Drawing.Size(75, 40);
            this.btn_inputExcel.TabIndex = 12;
            this.btn_inputExcel.Text = "Excel";
            this.btn_inputExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inputExcel.UseVisualStyleBackColor = true;
            this.btn_inputExcel.Click += new System.EventHandler(this.btn_inputExcel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên kỳ thi";
            // 
            // txt_tenkythi
            // 
            this.txt_tenkythi.Location = new System.Drawing.Point(139, 51);
            this.txt_tenkythi.Name = "txt_tenkythi";
            this.txt_tenkythi.Size = new System.Drawing.Size(762, 20);
            this.txt_tenkythi.TabIndex = 21;
            // 
            // frm_Taokithi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 472);
            this.Controls.Add(this.txt_tenkythi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TaoDe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenDe);
            this.Controls.Add(this.btn_LuuDe);
            this.Controls.Add(this.txt_soccau);
            this.Controls.Add(this.btn_inputExcel);
            this.Controls.Add(this.cbb_chonloaide);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_thoigian);
            this.Controls.Add(this.dtp_giothi);
            this.Controls.Add(this.dtp_ngaythi);
            this.Controls.Add(this.cbb_TenMon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Taokithi";
            this.Text = "Tạo Kì Thi";
            this.Load += new System.EventHandler(this.frm_TaoKiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soccau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSThamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_TenMon;
        private System.Windows.Forms.DateTimePicker dtp_ngaythi;
        private System.Windows.Forms.DateTimePicker dtp_giothi;
        private System.Windows.Forms.NumericUpDown txt_thoigian;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_chonloaide;
        private System.Windows.Forms.Button btn_inputExcel;
        private System.Windows.Forms.NumericUpDown txt_soccau;
        private System.Windows.Forms.Button btn_LuuDe;
        private System.Windows.Forms.TextBox txt_TenDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_TaoDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TSThamGia;
        private System.Windows.Forms.Button btn_AddTK;
        private System.Windows.Forms.ComboBox cbb_taikhoan;
        private System.Windows.Forms.Button btn_RemoTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tenkythi;
    }
}