
namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(241, 88);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(193, 22);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMK.Location = new System.Drawing.Point(241, 114);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(193, 22);
            this.txtMK.TabIndex = 2;
            this.txtMK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // btnDN
            // 
            this.btnDN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.Brown;
            this.btnDN.Image = ((System.Drawing.Image)(resources.GetObject("btnDN.Image")));
            this.btnDN.Location = new System.Drawing.Point(153, 149);
            this.btnDN.Margin = new System.Windows.Forms.Padding(4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(173, 45);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUY.ForeColor = System.Drawing.Color.Brown;
            this.btnHUY.Image = ((System.Drawing.Image)(resources.GetObject("btnHUY.Image")));
            this.btnHUY.Location = new System.Drawing.Point(348, 149);
            this.btnHUY.Margin = new System.Windows.Forms.Padding(4);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(128, 45);
            this.btnHUY.TabIndex = 3;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHUY.UseVisualStyleBackColor = false;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 107);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(489, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnHUY;
        public System.Windows.Forms.TextBox txtMaNV;
        public System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}