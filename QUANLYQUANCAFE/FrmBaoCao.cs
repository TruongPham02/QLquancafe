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
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }
        string mahd = "";
        public FrmBaoCao(string _mahd)
        {
            InitializeComponent();
            mahd = _mahd;
        }
        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            if (mahd == "ALL")
            {// TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
                this.HOADONTableAdapter.Fill(this.QUANLYCAFE3DataSet.HOADON);
            }
            else
            {
                this.HOADONTableAdapter.FillByMaHD(this.QUANLYCAFE3DataSet.HOADON, mahd);
            }
            ReportParameter[] param = new ReportParameter[1];
            //ABCD là dữ liệu có thể lấy từ Textbox, Form khác
            param[0] = new ReportParameter("parMaHD", mahd);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
            //label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //this.reportViewer1.RefreshReport();
        }
    }
    
}