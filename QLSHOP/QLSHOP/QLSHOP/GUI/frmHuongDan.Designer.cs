
namespace GUI
{
    partial class frmHuongDan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Đăng nhập");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Đăng xuất");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Hướng dẫn sử dụng", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "DN";
            treeNode1.Text = "Đăng nhập";
            treeNode2.Name = "DX";
            treeNode2.Text = "Đăng xuất";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Hướng dẫn sử dụng";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(378, 544);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(398, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1275, 544);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 580);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmHuongDan";
            this.Text = "frmHuongDan";
            this.Load += new System.EventHandler(this.frmHuongDan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}