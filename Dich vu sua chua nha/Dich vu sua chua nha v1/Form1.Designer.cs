namespace Dich_vu_sua_chua_nha_v1
{
    partial class FrmChondichvu
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
            this.lstDichvu = new System.Windows.Forms.ListBox();
            this.lstChondichvu = new System.Windows.Forms.ListBox();
            this.btnChon1 = new System.Windows.Forms.Button();
            this.btnChonhet = new System.Windows.Forms.Button();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnHuyhet = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDichvu
            // 
            this.lstDichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDichvu.ForeColor = System.Drawing.Color.Blue;
            this.lstDichvu.FormattingEnabled = true;
            this.lstDichvu.Items.AddRange(new object[] {
            "Điện",
            "Nước",
            "Điện lạnh",
            "Sơn",
            "Xây dựng"});
            this.lstDichvu.Location = new System.Drawing.Point(54, 66);
            this.lstDichvu.Name = "lstDichvu";
            this.lstDichvu.Size = new System.Drawing.Size(120, 134);
            this.lstDichvu.TabIndex = 1;
            this.lstDichvu.SelectedIndexChanged += new System.EventHandler(this.lstDichvu_SelectedIndexChanged);
            // 
            // lstChondichvu
            // 
            this.lstChondichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstChondichvu.ForeColor = System.Drawing.Color.Lime;
            this.lstChondichvu.FormattingEnabled = true;
            this.lstChondichvu.Location = new System.Drawing.Point(381, 57);
            this.lstChondichvu.Name = "lstChondichvu";
            this.lstChondichvu.Size = new System.Drawing.Size(120, 147);
            this.lstChondichvu.TabIndex = 2;
            // 
            // btnChon1
            // 
            this.btnChon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon1.Location = new System.Drawing.Point(247, 94);
            this.btnChon1.Name = "btnChon1";
            this.btnChon1.Size = new System.Drawing.Size(75, 23);
            this.btnChon1.TabIndex = 3;
            this.btnChon1.Text = ">";
            this.btnChon1.UseVisualStyleBackColor = true;
            this.btnChon1.Click += new System.EventHandler(this.btnChon1_Click);
            // 
            // btnChonhet
            // 
            this.btnChonhet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonhet.Location = new System.Drawing.Point(247, 123);
            this.btnChonhet.Name = "btnChonhet";
            this.btnChonhet.Size = new System.Drawing.Size(75, 23);
            this.btnChonhet.TabIndex = 4;
            this.btnChonhet.Text = "»";
            this.btnChonhet.UseVisualStyleBackColor = true;
            // 
            // btnHuy1
            // 
            this.btnHuy1.Enabled = false;
            this.btnHuy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy1.Location = new System.Drawing.Point(247, 152);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(75, 23);
            this.btnHuy1.TabIndex = 5;
            this.btnHuy1.Text = "<";
            this.btnHuy1.UseVisualStyleBackColor = true;
            // 
            // btnHuyhet
            // 
            this.btnHuyhet.Enabled = false;
            this.btnHuyhet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyhet.Location = new System.Drawing.Point(247, 181);
            this.btnHuyhet.Name = "btnHuyhet";
            this.btnHuyhet.Size = new System.Drawing.Size(75, 23);
            this.btnHuyhet.TabIndex = 6;
            this.btnHuyhet.Text = "«";
            this.btnHuyhet.UseVisualStyleBackColor = true;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(51, 215);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(62, 15);
            this.lblKetqua.TabIndex = 7;
            this.lblKetqua.Text = "Tổng kết";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(426, 259);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Danh sách dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dịch vụ chọn";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(54, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 82);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bạn chưa chọn dịch vụ";
            // 
            // FrmChondichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnHuyhet);
            this.Controls.Add(this.btnHuy1);
            this.Controls.Add(this.btnChonhet);
            this.Controls.Add(this.btnChon1);
            this.Controls.Add(this.lstChondichvu);
            this.Controls.Add(this.lstDichvu);
            this.Controls.Add(this.label1);
            this.Name = "FrmChondichvu";
            this.Text = "Dịch vụ sửa chữa nhà";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDichvu;
        private System.Windows.Forms.ListBox lstChondichvu;
        private System.Windows.Forms.Button btnChon1;
        private System.Windows.Forms.Button btnChonhet;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnHuyhet;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}