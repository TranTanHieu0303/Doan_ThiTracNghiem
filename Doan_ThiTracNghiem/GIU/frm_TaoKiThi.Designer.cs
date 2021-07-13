
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
            this.dgv_TSThamGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_TatCacTS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_AddTS = new System.Windows.Forms.Button();
            this.btn_TaoDe = new System.Windows.Forms.Button();
            this.btn_LuuDe = new System.Windows.Forms.Button();
            this.btn_inputExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thoigian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soccau)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSThamGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TatCacTS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo Kì Thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(371, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian làm bài";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(371, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn Loại Đề";
            // 
            // cbb_TenMon
            // 
            this.cbb_TenMon.FormattingEnabled = true;
            this.cbb_TenMon.Location = new System.Drawing.Point(147, 50);
            this.cbb_TenMon.Name = "cbb_TenMon";
            this.cbb_TenMon.Size = new System.Drawing.Size(195, 21);
            this.cbb_TenMon.TabIndex = 5;
            // 
            // dtp_ngaythi
            // 
            this.dtp_ngaythi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaythi.Location = new System.Drawing.Point(147, 72);
            this.dtp_ngaythi.Name = "dtp_ngaythi";
            this.dtp_ngaythi.Size = new System.Drawing.Size(100, 20);
            this.dtp_ngaythi.TabIndex = 6;
            // 
            // dtp_giothi
            // 
            this.dtp_giothi.CustomFormat = "";
            this.dtp_giothi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_giothi.Location = new System.Drawing.Point(253, 73);
            this.dtp_giothi.Name = "dtp_giothi";
            this.dtp_giothi.ShowUpDown = true;
            this.dtp_giothi.Size = new System.Drawing.Size(89, 20);
            this.dtp_giothi.TabIndex = 7;
            // 
            // txt_thoigian
            // 
            this.txt_thoigian.Location = new System.Drawing.Point(492, 79);
            this.txt_thoigian.Name = "txt_thoigian";
            this.txt_thoigian.Size = new System.Drawing.Size(43, 20);
            this.txt_thoigian.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 204);
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
            this.cbb_chonloaide.Location = new System.Drawing.Point(493, 52);
            this.cbb_chonloaide.Name = "cbb_chonloaide";
            this.cbb_chonloaide.Size = new System.Drawing.Size(195, 21);
            this.cbb_chonloaide.TabIndex = 11;
            this.cbb_chonloaide.SelectedIndexChanged += new System.EventHandler(this.cbb_chonloaide_SelectedIndexChanged);
            // 
            // txt_soccau
            // 
            this.txt_soccau.Location = new System.Drawing.Point(612, 80);
            this.txt_soccau.Name = "txt_soccau";
            this.txt_soccau.Size = new System.Drawing.Size(35, 20);
            this.txt_soccau.TabIndex = 13;
            // 
            // txt_TenDe
            // 
            this.txt_TenDe.Location = new System.Drawing.Point(771, 54);
            this.txt_TenDe.Name = "txt_TenDe";
            this.txt_TenDe.Size = new System.Drawing.Size(138, 20);
            this.txt_TenDe.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(702, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên Đề";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(560, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Số Câu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_TSThamGia);
            this.groupBox1.Location = new System.Drawing.Point(479, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 206);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Thí Sinh Tham Gia";
            // 
            // dgv_TSThamGia
            // 
            this.dgv_TSThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TSThamGia.Location = new System.Drawing.Point(6, 19);
            this.dgv_TSThamGia.Name = "dgv_TSThamGia";
            this.dgv_TSThamGia.Size = new System.Drawing.Size(416, 181);
            this.dgv_TSThamGia.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_TatCacTS);
            this.groupBox2.Location = new System.Drawing.Point(29, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 206);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tất Cả Thí Sinh";
            // 
            // dgv_TatCacTS
            // 
            this.dgv_TatCacTS.AllowUserToAddRows = false;
            this.dgv_TatCacTS.AllowUserToOrderColumns = true;
            this.dgv_TatCacTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TatCacTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_TatCacTS.Location = new System.Drawing.Point(6, 19);
            this.dgv_TatCacTS.Name = "dgv_TatCacTS";
            this.dgv_TatCacTS.ReadOnly = true;
            this.dgv_TatCacTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TatCacTS.Size = new System.Drawing.Size(372, 181);
            this.dgv_TatCacTS.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaUse";
            this.Column1.HeaderText = "Mã Tài Khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Tên Tài Khoản";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 109;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Doan_ThiTracNghiem.Properties.Resources.button_round_dark_arrow_left_icon;
            this.button3.Location = new System.Drawing.Point(419, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 54);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_AddTS
            // 
            this.btn_AddTS.AutoSize = true;
            this.btn_AddTS.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddTS.FlatAppearance.BorderSize = 0;
            this.btn_AddTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTS.Image = global::Doan_ThiTracNghiem.Properties.Resources.button_round_dark_arrow_right_icon__1_;
            this.btn_AddTS.Location = new System.Drawing.Point(419, 421);
            this.btn_AddTS.Name = "btn_AddTS";
            this.btn_AddTS.Size = new System.Drawing.Size(54, 54);
            this.btn_AddTS.TabIndex = 21;
            this.btn_AddTS.UseVisualStyleBackColor = false;
            this.btn_AddTS.Click += new System.EventHandler(this.btn_AddTS_Click);
            // 
            // btn_TaoDe
            // 
            this.btn_TaoDe.AutoSize = true;
            this.btn_TaoDe.Image = global::Doan_ThiTracNghiem.Properties.Resources.button_round_random_icon__1_;
            this.btn_TaoDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoDe.Location = new System.Drawing.Point(402, 105);
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
            this.btn_LuuDe.Location = new System.Drawing.Point(637, 104);
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
            this.btn_inputExcel.Location = new System.Drawing.Point(34, 108);
            this.btn_inputExcel.Name = "btn_inputExcel";
            this.btn_inputExcel.Size = new System.Drawing.Size(75, 40);
            this.btn_inputExcel.TabIndex = 12;
            this.btn_inputExcel.Text = "Excel";
            this.btn_inputExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inputExcel.UseVisualStyleBackColor = true;
            this.btn_inputExcel.Click += new System.EventHandler(this.btn_inputExcel_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Doan_ThiTracNghiem.Properties.Resources.ok_icon;
            this.button1.Location = new System.Drawing.Point(419, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frm_Taokithi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_AddTS);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TSThamGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TatCacTS)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_TatCacTS;
        private System.Windows.Forms.Button btn_AddTS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}