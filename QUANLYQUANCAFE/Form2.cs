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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBan frm3 = new FrmBan();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCafe frm4 = new FrmCafe();
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm5 = new FrmCaLamViec();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm6 = new FrmChiNhanh();
            frm6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm7 = new FrmHoaDon();
            frm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm8 = new FrmKhach();
            frm8.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm9 = new FrmNhanVien();
            frm9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm10 = new FrmQLNhanVien();
            frm10.Show();
        }
    }
}
