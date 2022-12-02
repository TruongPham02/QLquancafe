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
            loadDSMaHD();
        }

        // HOADON hd = new HOADON();
        private void loadDSMaHD()
        {
           
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<HOADON> lstHoadon = db.HOADONs.ToList();
            HOADON HD = new HOADON();
            HD.MaHD = "ALL";

            lstHoadon.Insert(0, HD);

            comboBox1.DataSource = lstHoadon;
            comboBox1.DisplayMember = "mahd";
            comboBox1.ValueMember = "mahd";


        }
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
            /*textBox1.DataBindings.Clear();
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
            textBox12.DataBindings.Add("text", Lst, "maql");*/

        }

        private void button2_Click(object sender, EventArgs e) //them
        {
            HOADON hd = new HOADON();
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd.MaHD = textBox1.Text;
            hd.Ngay = DateTime.Parse(textBox2.Text);
            hd.TongTien = Int32.Parse(textBox3.Text);
            hd.GiamGia = Int32.Parse(textBox4.Text);
            if (textBox5.Text == "")
            {
                hd.DiemTL = 0;
            }
            else
                hd.DiemTL = Int32.Parse(textBox5.Text);
            hd.SoLuong = Int16.Parse(textBox6.Text);
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
            HOADON hd = new HOADON();
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd = db.HOADONs.Where(s => s.MaHD == textBox1.Text).Single();
            hd.Ngay = DateTime.Parse(textBox2.Text);
            hd.TongTien = Int16.Parse(textBox3.Text);
            hd.GiamGia = Int16.Parse(textBox4.Text);
            if (textBox5.Text == "")
            {
                hd.DiemTL = 0;
            }
            else
                hd.DiemTL = Int16.Parse(textBox5.Text);
            hd.SoLuong = Int16.Parse(textBox6.Text);
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
            HOADON hd = new HOADON();
            DataClasses1DataContext db = new DataClasses1DataContext();
            hd = db.HOADONs.Where(s => s.MaHD == textBox1.Text).Single();
           
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
             FrmBaoCao frmbaocao = new FrmBaoCao(comboBox1.SelectedValue.ToString());
            
            
            frmbaocao.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmBan frm1 = new FrmBan();
            frm1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmCafe frm2 = new FrmCafe();
            frm2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm3= new FrmCaLamViec();
            frm3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm4= new FrmChiNhanh();
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm5= new FrmKhach();
            frm5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm6= new FrmNhanVien();
            frm6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm7=new FrmQLNhanVien();
            frm7.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Diendan frm8 = new Diendan();
            frm8.Show();
        }
    }
}

