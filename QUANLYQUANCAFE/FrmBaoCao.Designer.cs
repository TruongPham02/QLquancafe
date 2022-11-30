namespace QUANLYQUANCAFE
{
    partial class FrmBaoCao
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
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYCAFE3DataSet = new QUANLYQUANCAFE.QUANLYCAFE3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONTableAdapter = new QUANLYQUANCAFE.QUANLYCAFE3DataSetTableAdapters.HOADONTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.QUANLYCAFE3DataSet;
            // 
            // QUANLYCAFE3DataSet
            // 
            this.QUANLYCAFE3DataSet.DataSetName = "QUANLYCAFE3DataSet";
            this.QUANLYCAFE3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "dataHOADON";
            reportDataSource1.Value = this.HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYQUANCAFE.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1211, 533);
            this.reportViewer1.TabIndex = 0;
        
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1235, 571);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private QUANLYCAFE3DataSet QUANLYCAFE3DataSet;
        private QUANLYCAFE3DataSetTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}