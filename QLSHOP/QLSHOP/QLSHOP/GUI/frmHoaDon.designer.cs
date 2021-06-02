
namespace GUI
{
    partial class frmHoaDon
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
            this.btn_XuatHD = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgChiTietHD = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dgHD = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHD)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XuatHD
            // 
            this.btn_XuatHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XuatHD.Location = new System.Drawing.Point(677, 565);
            this.btn_XuatHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XuatHD.Name = "btn_XuatHD";
            this.btn_XuatHD.Size = new System.Drawing.Size(181, 49);
            this.btn_XuatHD.TabIndex = 8;
            this.btn_XuatHD.Text = "Xuất hóa đơn";
            this.btn_XuatHD.UseVisualStyleBackColor = false;
            this.btn_XuatHD.Click += new System.EventHandler(this.btn_XuatHD_Click);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Location = new System.Drawing.Point(305, 148);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(288, 34);
            this.txtSL.TabIndex = 33;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(305, 95);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(288, 34);
            this.txtMaSP.TabIndex = 32;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(305, 194);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(288, 34);
            this.txtTenSP.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(105, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mã sản phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(105, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 29;
            this.label11.Text = "Số lượng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(105, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 26);
            this.label12.TabIndex = 30;
            this.label12.Text = "Tên mặt hàng:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(213, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(332, 38);
            this.label13.TabIndex = 27;
            this.label13.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgChiTietHD);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(785, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 544);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgChiTietHD
            // 
            this.dgChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgChiTietHD.Location = new System.Drawing.Point(0, 236);
            this.dgChiTietHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgChiTietHD.Name = "dgChiTietHD";
            this.dgChiTietHD.RowHeadersVisible = false;
            this.dgChiTietHD.RowHeadersWidth = 51;
            this.dgChiTietHD.Size = new System.Drawing.Size(728, 308);
            this.dgChiTietHD.TabIndex = 34;
            this.dgChiTietHD.Click += new System.EventHandler(this.dgChiTietHD_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtNgayLap);
            this.panel2.Controls.Add(this.cbMaNV);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.txtTien);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.dgHD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(16, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 544);
            this.panel2.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(557, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(139, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "Thành tiền:";
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayLap.Location = new System.Drawing.Point(318, 278);
            this.dtNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(283, 34);
            this.dtNgayLap.TabIndex = 37;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(318, 187);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(283, 33);
            this.cbMaNV.TabIndex = 36;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(318, 136);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(283, 34);
            this.txtMaKH.TabIndex = 35;
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTien.Location = new System.Drawing.Point(318, 236);
            this.txtTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(231, 34);
            this.txtTien.TabIndex = 34;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(318, 89);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(283, 30);
            this.txtMaHD.TabIndex = 33;
            // 
            // dgHD
            // 
            this.dgHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgHD.Location = new System.Drawing.Point(0, 347);
            this.dgHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgHD.Name = "dgHD";
            this.dgHD.RowHeadersVisible = false;
            this.dgHD.RowHeadersWidth = 51;
            this.dgHD.Size = new System.Drawing.Size(761, 197);
            this.dgHD.TabIndex = 32;
            this.dgHD.Click += new System.EventHandler(this.dgHD_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(139, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 26);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(138, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(139, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(139, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(267, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "HÓA ĐƠN BÁN";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1529, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_XuatHD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_XuatHD;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        public System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgChiTietHD;
    }
}