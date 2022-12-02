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
    public partial class FrmInBan : Form
    {
        public FrmInBan()
        {
            InitializeComponent();
        }
        string maban = "";
        public FrmInBan(string _maban)
        {
            InitializeComponent();
            maban = _maban;
        }
        private void FrmInBan_Load(object sender, EventArgs e)
        {
            
       
            if (maban == "ALL")
            {// TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
                this.BANTableAdapter.Fill(this.QUANLYCAFE3DataSet.BAN);
            }
            else
            {
                this.BANTableAdapter.FillByMaBan(this.QUANLYCAFE3DataSet.BAN, maban);
            }
            ReportParameter[] param = new ReportParameter[1];
            //ABCD là dữ liệu có thể lấy từ Textbox, Form khác
            param[0] = new ReportParameter("parMaBan", maban);
            reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }
    }
}
