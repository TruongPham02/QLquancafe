using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANCAFE
{
    public partial class FrmInChiNhanh : Form
    {
        public FrmInChiNhanh()
        {
            InitializeComponent();
        }
        string macn = "";
        public FrmInChiNhanh(string _macn)
        {
            InitializeComponent();
            macn = _macn;
        }
        private void FrmInChiNhanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.CHINHANH' table. You can move, or remove it, as needed.
            /*this.CHINHANHTableAdapter.Fill(this.QUANLYCAFE3DataSet.CHINHANH);

            this.reportViewer1.RefreshReport();*/
            if (macn == "ALL")
            {// TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
                this.CHINHANHTableAdapter.Fill(this.QUANLYCAFE3DataSet.CHINHANH);
            }
            else
            {
                this.CHINHANHTableAdapter.FillBy(this.QUANLYCAFE3DataSet.CHINHANH,macn);
            }
            ReportParameter[] param = new ReportParameter[1];
            //ABCD là dữ liệu có thể lấy từ Textbox, Form khác
            param[0] = new ReportParameter("parMaCN", macn);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
