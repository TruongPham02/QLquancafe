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
    public partial class Diendan : Form
    {
        public Diendan()
        {
            InitializeComponent();
            textBox2.Text = Properties.Settings.Default.S;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmBan frm1= new FrmBan();
            frm1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmCafe frm2= new FrmCafe();
            frm2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm3 = new FrmCaLamViec();
            frm3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm4 = new FrmChiNhanh();
            frm4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm5= new FrmHoaDon();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm6= new FrmKhach();
            frm6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm7= new FrmNhanVien();
            frm7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm8= new FrmQLNhanVien();
            frm8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dangnhap frm = new Dangnhap();
            
            textBox2.Text += Environment.NewLine +"["+ DateTime.Now.ToString()+"]" +" <"+ Properties.Settings.Default.ss +">" + ": " + textBox1.Text;
            Properties.Settings.Default.S = textBox2.Text;
            Properties.Settings.Default.Save();
            textBox1.Text = "";
        }
    }
}
