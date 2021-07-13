
namespace Doan_ThiTracNghiem
{
    partial class Cauhoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_cau = new System.Windows.Forms.Label();
            this.rdb_A = new System.Windows.Forms.RadioButton();
            this.rdb_B = new System.Windows.Forms.RadioButton();
            this.rdb_C = new System.Windows.Forms.RadioButton();
            this.rdb_D = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_cau
            // 
            this.lbl_cau.AutoSize = true;
            this.lbl_cau.Location = new System.Drawing.Point(3, 10);
            this.lbl_cau.Name = "lbl_cau";
            this.lbl_cau.Size = new System.Drawing.Size(38, 13);
            this.lbl_cau.TabIndex = 0;
            this.lbl_cau.Text = "Câu 1:";
            // 
            // rdb_A
            // 
            this.rdb_A.AutoSize = true;
            this.rdb_A.Location = new System.Drawing.Point(49, 8);
            this.rdb_A.Name = "rdb_A";
            this.rdb_A.Size = new System.Drawing.Size(32, 17);
            this.rdb_A.TabIndex = 1;
            this.rdb_A.TabStop = true;
            this.rdb_A.Text = "A";
            this.rdb_A.UseVisualStyleBackColor = true;
            this.rdb_A.CheckedChanged += new System.EventHandler(this.rdb_A_CheckedChanged);
            // 
            // rdb_B
            // 
            this.rdb_B.AutoSize = true;
            this.rdb_B.Location = new System.Drawing.Point(125, 8);
            this.rdb_B.Name = "rdb_B";
            this.rdb_B.Size = new System.Drawing.Size(32, 17);
            this.rdb_B.TabIndex = 2;
            this.rdb_B.TabStop = true;
            this.rdb_B.Text = "B";
            this.rdb_B.UseVisualStyleBackColor = true;
            this.rdb_B.CheckedChanged += new System.EventHandler(this.rdb_B_CheckedChanged);
            // 
            // rdb_C
            // 
            this.rdb_C.AutoSize = true;
            this.rdb_C.Location = new System.Drawing.Point(218, 8);
            this.rdb_C.Name = "rdb_C";
            this.rdb_C.Size = new System.Drawing.Size(32, 17);
            this.rdb_C.TabIndex = 3;
            this.rdb_C.TabStop = true;
            this.rdb_C.Text = "C";
            this.rdb_C.UseVisualStyleBackColor = true;
            this.rdb_C.CheckedChanged += new System.EventHandler(this.rdb_C_CheckedChanged);
            // 
            // rdb_D
            // 
            this.rdb_D.AutoSize = true;
            this.rdb_D.Location = new System.Drawing.Point(321, 8);
            this.rdb_D.Name = "rdb_D";
            this.rdb_D.Size = new System.Drawing.Size(33, 17);
            this.rdb_D.TabIndex = 4;
            this.rdb_D.TabStop = true;
            this.rdb_D.Text = "D";
            this.rdb_D.UseVisualStyleBackColor = true;
            this.rdb_D.CheckedChanged += new System.EventHandler(this.rdb_D_CheckedChanged);
            // 
            // Cauhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rdb_D);
            this.Controls.Add(this.rdb_C);
            this.Controls.Add(this.rdb_B);
            this.Controls.Add(this.rdb_A);
            this.Controls.Add(this.lbl_cau);
            this.Name = "Cauhoi";
            this.Size = new System.Drawing.Size(366, 30);
            this.Load += new System.EventHandler(this.Cauhoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cau;
        public System.Windows.Forms.RadioButton rdb_A;
        public System.Windows.Forms.RadioButton rdb_B;
        public System.Windows.Forms.RadioButton rdb_C;
        public System.Windows.Forms.RadioButton rdb_D;
    }
}
