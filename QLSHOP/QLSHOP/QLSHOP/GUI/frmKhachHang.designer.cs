
namespace GUI
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dgKH = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PapayaWhip;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PapayaWhip;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PapayaWhip;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PapayaWhip;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaKH.Location = new System.Drawing.Point(238, 77);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(273, 34);
            this.txtMaKH.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoten.Location = new System.Drawing.Point(238, 119);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(273, 34);
            this.txtHoten.TabIndex = 2;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNam.Location = new System.Drawing.Point(249, 161);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(81, 30);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNu.Location = new System.Drawing.Point(421, 161);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(64, 30);
            this.rdNu.TabIndex = 3;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(238, 199);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(273, 34);
            this.txtSDT.TabIndex = 2;
            // 
            // dgKH
            // 
            this.dgKH.AllowUserToAddRows = false;
            this.dgKH.AllowUserToDeleteRows = false;
            this.dgKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKH.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKH.Location = new System.Drawing.Point(0, 241);
            this.dgKH.Margin = new System.Windows.Forms.Padding(4);
            this.dgKH.Name = "dgKH";
            this.dgKH.ReadOnly = true;
            this.dgKH.RowHeadersVisible = false;
            this.dgKH.RowHeadersWidth = 51;
            this.dgKH.Size = new System.Drawing.Size(947, 226);
            this.dgKH.TabIndex = 4;
            this.dgKH.Click += new System.EventHandler(this.dgKH_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(538, 105);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 48);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(538, 181);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 48);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(691, 105);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 48);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(694, 181);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 467);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgKH);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dgKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}