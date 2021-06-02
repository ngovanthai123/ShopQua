
namespace GUI
{
    partial class frmPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhieuNhap = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dgv_ChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(129, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(129, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(129, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(129, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng:";
            // 
            // txtPhieuNhap
            // 
            this.txtPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhieuNhap.Location = new System.Drawing.Point(312, 71);
            this.txtPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhieuNhap.Name = "txtPhieuNhap";
            this.txtPhieuNhap.Size = new System.Drawing.Size(299, 34);
            this.txtPhieuNhap.TabIndex = 2;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayNhap.Location = new System.Drawing.Point(267, 243);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(344, 34);
            this.dtNgayNhap.TabIndex = 3;
            this.dtNgayNhap.Value = new System.DateTime(2021, 5, 5, 10, 5, 33, 0);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.Location = new System.Drawing.Point(267, 126);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(344, 34);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSL.Location = new System.Drawing.Point(267, 189);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(344, 34);
            this.txtSL.TabIndex = 4;
            // 
            // dgv_ChiTietPhieuNhap
            // 
            this.dgv_ChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgv_ChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_ChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuNhap.Location = new System.Drawing.Point(8, 23);
            this.dgv_ChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ChiTietPhieuNhap.Name = "dgv_ChiTietPhieuNhap";
            this.dgv_ChiTietPhieuNhap.ReadOnly = true;
            this.dgv_ChiTietPhieuNhap.RowHeadersVisible = false;
            this.dgv_ChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgv_ChiTietPhieuNhap.Size = new System.Drawing.Size(1082, 169);
            this.dgv_ChiTietPhieuNhap.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MintCream;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(869, 220);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 57);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MintCream;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(682, 220);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 57);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MintCream;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(869, 141);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 57);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MintCream;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(682, 141);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 57);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(802, 66);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(226, 34);
            this.txtTenSP.TabIndex = 4;
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AllowUserToAddRows = false;
            this.dgv_PhieuNhap.AllowUserToDeleteRows = false;
            this.dgv_PhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhap.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(16, 22);
            this.dgv_PhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.ReadOnly = true;
            this.dgv_PhieuNhap.RowHeadersVisible = false;
            this.dgv_PhieuNhap.RowHeadersWidth = 51;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(1074, 189);
            this.dgv_PhieuNhap.TabIndex = 14;
            this.dgv_PhieuNhap.SelectionChanged += new System.EventHandler(this.dgv_PhieuNhap_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_PhieuNhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(13, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1101, 219);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ChiTietPhieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(13, 526);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1101, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm trong phiếu nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(632, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 747);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.txtPhieuNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}