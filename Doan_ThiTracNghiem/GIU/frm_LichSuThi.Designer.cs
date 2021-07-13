
namespace Doan_ThiTracNghiem.GIU
{
    partial class frm_LichSuThi
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
            this.dgv_lichsu = new System.Windows.Forms.DataGridView();
            this.btn_In = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_lichsu
            // 
            this.dgv_lichsu.AllowUserToAddRows = false;
            this.dgv_lichsu.AllowUserToDeleteRows = false;
            this.dgv_lichsu.AllowUserToOrderColumns = true;
            this.dgv_lichsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lichsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgv_lichsu.Location = new System.Drawing.Point(12, 71);
            this.dgv_lichsu.Name = "dgv_lichsu";
            this.dgv_lichsu.ReadOnly = true;
            this.dgv_lichsu.Size = new System.Drawing.Size(903, 268);
            this.dgv_lichsu.TabIndex = 0;
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(840, 12);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(75, 23);
            this.btn_In.TabIndex = 1;
            this.btn_In.Text = "In đề thi";
            this.btn_In.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgayThi";
            this.Column1.HeaderText = "Ngày thi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMon";
            this.Column2.HeaderText = "Môn thi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Diem";
            this.Column3.HeaderText = "Điểm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoCauDung";
            this.Column4.HeaderText = "Số câu đúng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoCau";
            this.Column6.HeaderText = "Số Câu Trong Đề";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ThoiGian";
            this.Column5.HeaderText = "Thời Gian Làm Bài";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frm_LichSuThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.dgv_lichsu);
            this.Name = "frm_LichSuThi";
            this.Text = "frm_LichSuThi";
            this.Load += new System.EventHandler(this.frm_LichSuThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_lichsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}