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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        NHANVIEN nv = new NHANVIEN();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var nhanvien = from sp in db.NHANVIENs
                           select new
                           {
                               sp.MaNV,
                               sp.TenNV,
                               sp.DiaChi,
                               sp.SDT,
                               sp.ChucVu,
                               sp.NgayNhanViec,
                               sp.GioiTinh,
                               sp._Admin,
                               sp.MatKhau,
                           };
            dataGridView1.DataSource = nhanvien;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.NHANVIENs select s).ToList();
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
            textBox1.DataBindings.Add("text", Lst, "manv");
            textBox2.DataBindings.Add("text", Lst, "tennv");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "chucvu");
            textBox6.DataBindings.Add("text", Lst, "ngaynhanviec");
            textBox7.DataBindings.Add("text", Lst, "gioitinh");
            textBox8.DataBindings.Add("text", Lst, "_admin");
            textBox9.DataBindings.Add("text", Lst, "matkhau");
        }

        private void button2_Click(object sender, EventArgs e) // them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            nv.MaNV = textBox1.Text;
            nv.TenNV = textBox2.Text;
            nv.DiaChi = textBox3.Text;
            nv.SDT = textBox4.Text;
            nv.ChucVu = textBox5.Text;
            nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
            nv.GioiTinh = bool.Parse(textBox7.Text);
            nv._Admin = bool.Parse(textBox8.Text);
            nv.MatKhau = textBox9.Text;
          
            db.NHANVIENs.InsertOnSubmit(nv);
            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) // sua
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            nv = db.NHANVIENs.Where(s => s.MaNV == textBox1.Text).Single();
            nv.TenNV = textBox2.Text;
            nv.DiaChi = textBox3.Text;
            nv.SDT = textBox4.Text;
            nv.ChucVu = textBox5.Text;
            nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
            nv.GioiTinh = bool.Parse(textBox7.Text);
            nv._Admin = bool.Parse(textBox8.Text);
            nv.MatKhau = textBox9.Text;

            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) // xoa
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            nv = db.NHANVIENs.Where(s => s.MaNV == textBox1.Text).Single();
            nv.TenNV = textBox2.Text;
            nv.DiaChi = textBox3.Text;
            nv.SDT = textBox4.Text;
            nv.ChucVu = textBox5.Text;
            nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
            nv.GioiTinh = bool.Parse(textBox7.Text);
            nv._Admin = bool.Parse(textBox8.Text);
            nv.MatKhau = textBox9.Text;
            db.NHANVIENs.DeleteOnSubmit(nv);
            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.NHANVIENs where (s.MaNV.Contains(textBox10.Text) 
                       || s.TenNV.Contains(textBox10.Text)) select s).ToList();
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
            textBox1.DataBindings.Add("text", Lst, "manv");
            textBox2.DataBindings.Add("text", Lst, "tennv");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "chucvu");
            textBox6.DataBindings.Add("text", Lst, "ngaynhanviec");
            textBox7.DataBindings.Add("text", Lst, "gioitinh");
            textBox8.DataBindings.Add("text", Lst, "_admin");
            textBox9.DataBindings.Add("text", Lst, "matkhau");
        }
    }
}
