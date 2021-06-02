
namespace GUI
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bthThemKH = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnBILL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowUserToAddRows = false;
            this.dgv_SanPham.AllowUserToDeleteRows = false;
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(43, 23);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.ReadOnly = true;
            this.dgv_SanPham.RowHeadersVisible = false;
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.Size = new System.Drawing.Size(1345, 185);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellContentClick);
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.AllowUserToAddRows = false;
            this.dgv_GioHang.AllowUserToDeleteRows = false;
            this.dgv_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(43, 32);
            this.dgv_GioHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.ReadOnly = true;
            this.dgv_GioHang.RowHeadersVisible = false;
            this.dgv_GioHang.RowHeadersWidth = 51;
            this.dgv_GioHang.Size = new System.Drawing.Size(1340, 185);
            this.dgv_GioHang.TabIndex = 0;
            this.dgv_GioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GioHang_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_GioHang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1440, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "BÁN HÀNG";
            // 
            // bthThemKH
            // 
            this.bthThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bthThemKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bthThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bthThemKH.Image = ((System.Drawing.Image)(resources.GetObject("bthThemKH.Image")));
            this.bthThemKH.Location = new System.Drawing.Point(992, 284);
            this.bthThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.bthThemKH.Name = "bthThemKH";
            this.bthThemKH.Size = new System.Drawing.Size(407, 50);
            this.bthThemKH.TabIndex = 5;
            this.bthThemKH.Text = "Thêm khách hàng thanh toán";
            this.bthThemKH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bthThemKH.UseVisualStyleBackColor = false;
            this.bthThemKH.Click += new System.EventHandler(this.bthThemKH_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(670, 284);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(266, 55);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(406, 284);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(162, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(59, 284);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(304, 50);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Chọn Sản phẩm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_SanPham);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(16, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1440, 222);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(706, 599);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(230, 34);
            this.txtTen.TabIndex = 38;
            // 
            // btnBILL
            // 
            this.btnBILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBILL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBILL.Image = ((System.Drawing.Image)(resources.GetObject("btnBILL.Image")));
            this.btnBILL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBILL.Location = new System.Drawing.Point(293, 595);
            this.btnBILL.Name = "btnBILL";
            this.btnBILL.Size = new System.Drawing.Size(126, 38);
            this.btnBILL.TabIndex = 39;
            this.btnBILL.Text = "In bill";
            this.btnBILL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBILL.UseVisualStyleBackColor = false;
            this.btnBILL.Click += new System.EventHandler(this.btnBILL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(519, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(961, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nhân viên lập:";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVien.Location = new System.Drawing.Point(1119, 599);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(230, 34);
            this.txtNhanVien.TabIndex = 38;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1472, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBILL);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bthThemKH);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button bthThemKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnBILL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhanVien;
    }
}