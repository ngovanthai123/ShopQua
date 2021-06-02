
namespace QLCH
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.dgDSnv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.Dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSnv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDSnv
            // 
            this.dgDSnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSnv.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgDSnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSnv.Location = new System.Drawing.Point(-2, 221);
            this.dgDSnv.Name = "dgDSnv";
            this.dgDSnv.RowHeadersVisible = false;
            this.dgDSnv.Size = new System.Drawing.Size(733, 182);
            this.dgDSnv.TabIndex = 0;
         
            this.dgDSnv.Click += new System.EventHandler(this.dgDSnv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(43, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(446, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số CMND:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(446, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(446, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(43, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày sinh:";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(148, 63);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(101, 20);
            this.txtManv.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(148, 102);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(133, 20);
            this.txtHoten.TabIndex = 3;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(148, 137);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(224, 137);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // Dtngaysinh
            // 
            this.Dtngaysinh.Location = new System.Drawing.Point(148, 178);
            this.Dtngaysinh.Name = "Dtngaysinh";
            this.Dtngaysinh.Size = new System.Drawing.Size(200, 20);
            this.Dtngaysinh.TabIndex = 5;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(546, 100);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(116, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(546, 135);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(133, 20);
            this.txtDiachi.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(546, 173);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(133, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(446, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chức vụ";
            // 
            // cbChucvu
            // 
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(546, 59);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(121, 21);
            this.cbChucvu.TabIndex = 6;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(729, 402);
            this.Controls.Add(this.cbChucvu);
            this.Controls.Add(this.Dtngaysinh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDSnv);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDSnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.DateTimePicker Dtngaysinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbChucvu;
    }
}