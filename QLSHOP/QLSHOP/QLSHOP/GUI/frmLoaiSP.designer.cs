
namespace GUI
{
    partial class frmLoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.dgLoaiSP = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(115, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(115, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên loại:";
            // 
            // txtLoai
            // 
            this.txtLoai.BackColor = System.Drawing.Color.White;
            this.txtLoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoai.Location = new System.Drawing.Point(221, 97);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(314, 34);
            this.txtLoai.TabIndex = 3;
            // 
            // dgLoaiSP
            // 
            this.dgLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoaiSP.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoaiSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgLoaiSP.Location = new System.Drawing.Point(0, 283);
            this.dgLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgLoaiSP.Name = "dgLoaiSP";
            this.dgLoaiSP.RowHeadersVisible = false;
            this.dgLoaiSP.RowHeadersWidth = 51;
            this.dgLoaiSP.Size = new System.Drawing.Size(695, 261);
            this.dgLoaiSP.TabIndex = 4;
            this.dgLoaiSP.Click += new System.EventHandler(this.dgLoaiSP_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(507, 225);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 50);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(341, 225);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 50);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(190, 225);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 50);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(23, 225);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 50);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.BackColor = System.Drawing.Color.White;
            this.txtLoaiSP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLoaiSP.Location = new System.Drawing.Point(221, 158);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(314, 34);
            this.txtLoaiSP.TabIndex = 26;
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 544);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgLoaiSP);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.DataGridView dgLoaiSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLoaiSP;
    }
}