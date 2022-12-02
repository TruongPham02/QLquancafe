namespace QUANLYQUANCAFE
{
    partial class FrmInCaFe
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
            this.CAFEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYCAFE3DataSet = new QUANLYQUANCAFE.QUANLYCAFE3DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CAFETableAdapter = new QUANLYQUANCAFE.QUANLYCAFE3DataSetTableAdapters.CAFETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CAFEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CAFEBindingSource
            // 
            this.CAFEBindingSource.DataMember = "CAFE";
            this.CAFEBindingSource.DataSource = this.QUANLYCAFE3DataSet;
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
            reportDataSource1.Value = this.CAFEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYQUANCAFE.cafe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(9, 10);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(582, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // CAFETableAdapter
            // 
            this.CAFETableAdapter.ClearBeforeFill = true;
            // 
            // FrmInCaFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInCaFe";
            this.Text = "In Cafe";
            this.Load += new System.EventHandler(this.FrmInCaFe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CAFEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYCAFE3DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CAFEBindingSource;
        private QUANLYCAFE3DataSet QUANLYCAFE3DataSet;
        private QUANLYCAFE3DataSetTableAdapters.CAFETableAdapter CAFETableAdapter;
    }
}