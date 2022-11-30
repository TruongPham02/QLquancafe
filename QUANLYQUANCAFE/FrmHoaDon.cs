using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANCAFE
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        HOADON hd = new HOADON();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var hoadon = from sp in db.HOADONs
                         select new
                         {
                             sp.MaHD,
                             sp.Ngay,
                             sp.TongTien,
                             sp.GiamGia,
                             sp.DiemTL,
                             sp.SoLuong,
                             sp.MaBan,
                             sp.MaKH,
                             sp.MaNV,
                             sp.MaCF,
                             sp.MaCLV,
                             sp.MaQL,
                         };
            dataGridView1.DataSource = hoadon;

        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.HOADONs select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox6.DataBindings.Clear();
            textBox7.DataBindings.Clear();
            textBox8.DataBindings.Clear();
            textBox9.DataBindings.Clear();
            textBox10.DataBindings.Clear();
            textBox11.DataBindings.Clear();
            textBox12.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "mahd");
            textBox2.DataBindings.Add("text", Lst, "ngay");
            textBox3.DataBindings.Add("text", Lst, "tongtien");
            textBox4.DataBindings.Add("text", Lst, "giamgia");
            textBox5.DataBindings.Add("text", Lst, "diemtl");
            textBox6.DataBindings.Add("text", Lst, "soluong");
            textBox7.DataBindings.Add("text", Lst, "maban");
            textBox8.DataBindings.Add("text", Lst, "makh");
            textBox9.DataBindings.Add("text", Lst, "manv");
            textBox10.DataBindings.Add("text", Lst, "macf");
            textBox11.DataBindings.Add("text", Lst, "maclv");
            textBox12.DataBindings.Add("text", Lst, "maql");

        }

        private void button2_Click(object sender, EventArgs e) //them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd.MaHD = textBox1.Text;
            hd.Ngay = DateTime.Parse(textBox2.Text);
            hd.TongTien = int.Parse(textBox3.Text);
            hd.GiamGia = int.Parse(textBox4.Text);
            if (textBox5.Text == "")
            {
                hd.DiemTL = 0;
            }
            else
                hd.DiemTL = int.Parse(textBox5.Text);
            hd.SoLuong = int.Parse(textBox6.Text);
            hd.MaBan = textBox7.Text;
            hd.MaKH = textBox8.Text;
            hd.MaNV = textBox9.Text;
            hd.MaCF = textBox10.Text;
            hd.MaCLV = textBox11.Text;
            hd.MaQL = textBox12.Text;
            db.HOADONs.InsertOnSubmit(hd);
            db.SubmitChanges();
            FrmHoaDon_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) // sua
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd = db.HOADONs.Where(s => s.MaHD == textBox1.Text).Single();
            hd.Ngay = DateTime.Parse(textBox2.Text);
            hd.TongTien = int.Parse(textBox3.Text);
            hd.GiamGia = int.Parse(textBox4.Text);
            if (textBox5.Text == "")
            {
                hd.DiemTL = 0;
            }
            else
                hd.DiemTL = int.Parse(textBox5.Text);
            hd.SoLuong = int.Parse(textBox6.Text);
            hd.MaBan = textBox7.Text;
            hd.MaKH = textBox8.Text;
            hd.MaNV = textBox9.Text;
            hd.MaCF = textBox10.Text;
            hd.MaCLV = textBox11.Text;
            hd.MaQL = textBox12.Text;
            db.SubmitChanges();
            FrmHoaDon_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //xoa
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd = db.HOADONs.Where(s => s.MaHD == textBox1.Text).Single();
            hd.Ngay = DateTime.Parse(textBox2.Text);
            hd.TongTien = int.Parse(textBox3.Text);
            hd.GiamGia = int.Parse(textBox4.Text);
            if (textBox5.Text == "")
            {
                hd.DiemTL = 0;
            }
            else
                hd.DiemTL = int.Parse(textBox5.Text);
            hd.SoLuong = int.Parse(textBox6.Text);
            hd.MaBan = textBox7.Text;
            hd.MaKH = textBox8.Text;
            hd.MaNV = textBox9.Text;
            hd.MaCF = textBox10.Text;
            hd.MaCLV = textBox11.Text;
            hd.MaQL = textBox12.Text;
            db.HOADONs.DeleteOnSubmit(hd);
            db.SubmitChanges();
            FrmHoaDon_Load(sender, e);
        }

        private void textBox13_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.HOADONs
                       where (s.MaHD.Contains(textBox13.Text) ||
                                                   s.MaCLV.Contains(textBox13.Text) ||
                                                   s.MaBan.Contains(textBox13.Text))
                       select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox6.DataBindings.Clear();
            textBox7.DataBindings.Clear();
            textBox8.DataBindings.Clear();
            textBox9.DataBindings.Clear();
            textBox10.DataBindings.Clear();
            textBox11.DataBindings.Clear();
            textBox12.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "mahd");
            textBox2.DataBindings.Add("text", Lst, "ngay");
            textBox3.DataBindings.Add("text", Lst, "tongtien");
            textBox4.DataBindings.Add("text", Lst, "giamgia");
            textBox5.DataBindings.Add("text", Lst, "diemtl");
            textBox6.DataBindings.Add("text", Lst, "soluong");
            textBox7.DataBindings.Add("text", Lst, "maban");
            textBox8.DataBindings.Add("text", Lst, "makh");
            textBox9.DataBindings.Add("text", Lst, "manv");
            textBox10.DataBindings.Add("text", Lst, "macf");
            textBox11.DataBindings.Add("text", Lst, "maclv");
            textBox12.DataBindings.Add("text", Lst, "maql");

        }

        private void button5_Click(object sender, EventArgs e) // in
        {
            FrmBaoCao frmbaocao = new FrmBaoCao();
            frmbaocao.Show();
        }
    }
}

