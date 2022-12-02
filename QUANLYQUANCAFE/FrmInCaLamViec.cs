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
    public partial class FrmInCaLamViec : Form
    {
        public FrmInCaLamViec()
        {
            InitializeComponent();
        }
        string maclv = "";
        public FrmInCaLamViec(string _maclv)
        {
            InitializeComponent();
            maclv = _maclv;
        }
        private void FrmInCaLamViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.CALAMVIEC' table. You can move, or remove it, as needed.
            /*this.CALAMVIECTableAdapter.Fill(this.QUANLYCAFE3DataSet.CALAMVIEC);
            this.CALAMVIECTableAdapter.FillBy
            this.reportViewer1.RefreshReport();*/
            if (maclv == "ALL")
            {// TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
                this.CALAMVIECTableAdapter.Fill(this.QUANLYCAFE3DataSet.CALAMVIEC);
            }
            else
            {
                this.CALAMVIECTableAdapter.FillBy(this.QUANLYCAFE3DataSet.CALAMVIEC,maclv);
            }
            ReportParameter[] param = new ReportParameter[1];
            //ABCD là dữ liệu có thể lấy từ Textbox, Form khác
            param[0] = new ReportParameter("parMaCLV", maclv);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
