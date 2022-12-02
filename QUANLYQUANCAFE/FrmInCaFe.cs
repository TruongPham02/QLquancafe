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
    public partial class FrmInCaFe : Form
    {
        public FrmInCaFe()
        {
            InitializeComponent();
        }

        string macf = "";
        public FrmInCaFe(string _macf)
        {
            InitializeComponent();
            macf = _macf;
        }
        private void FrmInCaFe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.CAFE' table. You can move, or remove it, as needed.
            /* this.CAFETableAdapter.Fill(this.QUANLYCAFE3DataSet.CAFE);
             this.CAFETableAdapter.fil
             this.reportViewer1.RefreshReport();*/
            if (macf == "ALL")
            {// TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
                this.CAFETableAdapter.Fill(this.QUANLYCAFE3DataSet.CAFE);
            }
            else
            {
                this.CAFETableAdapter.FillByMaCF(this.QUANLYCAFE3DataSet.CAFE, macf);
            }
            ReportParameter[] param = new ReportParameter[1];
            //ABCD là dữ liệu có thể lấy từ Textbox, Form khác
            param[0] = new ReportParameter("parMaCF", macf);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
