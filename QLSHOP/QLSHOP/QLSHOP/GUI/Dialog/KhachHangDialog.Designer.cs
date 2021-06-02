
namespace GUI.Dialog
{
    partial class KhachHangDialog
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
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Location = new System.Drawing.Point(29, 182);
            this.dgv_KhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1033, 241);
            this.dgv_KhachHang.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(443, 431);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(201, 44);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // KhachHangDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 490);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgv_KhachHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KhachHangDialog";
            this.Text = "KhachHangDialog";
            this.Load += new System.EventHandler(this.KhachHangDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Button btnXacNhan;
    }
}