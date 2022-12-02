namespace QUANLYQUANCAFE
{
    partial class FrmInChiNhanh
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
            this.CHINHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYCAFE3DataSet = new QUANLYQUANCAFE.QUANLYCAFE3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHINHANHTableAdapter = new QUANLYQUANCAFE.QUANLYCAFE3DataSetTableAdapters.CHINHANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CHINHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CHINHANHBindingSource
            // 
            this.CHINHANHBindingSource.DataMember = "CHINHANH";
            this.CHINHANHBindingSource.DataSource = this.QUANLYCAFE3DataSet;
            // 
            // QUANLYCAFE3DataSet
            // 
            this.QUANLYCAFE3DataSet.DataSetName = "QUANLYCAFE3DataSet";
            this.QUANLYCAFE3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CHINHANHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYQUANCAFE.chinhanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(586, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // CHINHANHTableAdapter
            // 
            this.CHINHANHTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInChiNhanh";
            this.Text = "In chi nhánh";
            this.Load += new System.EventHandler(this.FrmInChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHINHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CHINHANHBindingSource;
        private QUANLYCAFE3DataSet QUANLYCAFE3DataSet;
        private QUANLYCAFE3DataSetTableAdapters.CHINHANHTableAdapter CHINHANHTableAdapter;
    }
}