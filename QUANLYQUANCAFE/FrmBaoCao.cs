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

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYCAFE3DataSet.HOADON' table. You can move, or remove it, as needed.
            this.HOADONTableAdapter.Fill(this.QUANLYCAFE3DataSet.HOADON);

            this.reportViewer1.RefreshReport();
            //label2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

      
    }
}
