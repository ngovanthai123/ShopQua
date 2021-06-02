
namespace GUI
{
    partial class frmbcNhanVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLSHOPQUALUUNIEMDataSet = new GUI.QLSHOPQUALUUNIEMDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanvienTableAdapter = new GUI.QLSHOPQUALUUNIEMDataSetTableAdapters.nhanvienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSHOPQUALUUNIEMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.QLSHOPQUALUUNIEMDataSet;
            // 
            // QLSHOPQUALUUNIEMDataSet
            // 
            this.QLSHOPQUALUUNIEMDataSet.DataSetName = "QLSHOPQUALUUNIEMDataSet";
            this.QLSHOPQUALUUNIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // frmbcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmbcNhanVien";
            this.Text = "DANH SÁCH NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmbcNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLSHOPQUALUUNIEMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QLSHOPQUALUUNIEMDataSet QLSHOPQUALUUNIEMDataSet;
        private QLSHOPQUALUUNIEMDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}