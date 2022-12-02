namespace QUANLYQUANCAFE
{
    partial class FrmInCaLamViec
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
            this.CALAMVIECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYCAFE3DataSet = new QUANLYQUANCAFE.QUANLYCAFE3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CALAMVIECTableAdapter = new QUANLYQUANCAFE.QUANLYCAFE3DataSetTableAdapters.CALAMVIECTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CALAMVIECBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CALAMVIECBindingSource
            // 
            this.CALAMVIECBindingSource.DataMember = "CALAMVIEC";
            this.CALAMVIECBindingSource.DataSource = this.QUANLYCAFE3DataSet;
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
            reportDataSource1.Value = this.CALAMVIECBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYQUANCAFE.calamviec.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(582, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // CALAMVIECTableAdapter
            // 
            this.CALAMVIECTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInCaLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInCaLamViec";
            this.Text = "In ca làm việc";
            this.Load += new System.EventHandler(this.FrmInCaLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CALAMVIECBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CALAMVIECBindingSource;
        private QUANLYCAFE3DataSet QUANLYCAFE3DataSet;
        private QUANLYCAFE3DataSetTableAdapters.CALAMVIECTableAdapter CALAMVIECTableAdapter;
    }
}