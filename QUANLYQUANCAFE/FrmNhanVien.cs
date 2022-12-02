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

        //NHANVIEN nv = new NHANVIEN();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var nhanvien = from sp in db.NHANVIENs
                           select new
                           {
                               
                               sp.TenNV,
                               sp.DiaChi,
                               sp.SDT,
                               sp.ChucVu,
                               sp.NgayNhanViec,
                               sp.GioiTinh,
                              
                           };
            dataGridView1.DataSource = nhanvien;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.NHANVIENs select s).ToList();
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
            textBox1.DataBindings.Add("text", Lst, "manv");
            textBox2.DataBindings.Add("text", Lst, "tennv");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "chucvu");
            textBox6.DataBindings.Add("text", Lst, "ngaynhanviec");
            textBox7.DataBindings.Add("text", Lst, "gioitinh");
            textBox8.DataBindings.Add("text", Lst, "_admin");
            textBox9.DataBindings.Add("text", Lst, "matkhau");*/
        }

        private void button2_Click(object sender, EventArgs e) // them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            NHANVIEN nv = new NHANVIEN();
            
            nv.TenNV = textBox2.Text;
            nv.DiaChi = textBox3.Text;
            nv.SDT = textBox4.Text;
            nv.ChucVu = textBox5.Text;
            nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
            nv.GioiTinh = Boolean.Parse(textBox7.Text);
        
           
          
            db.NHANVIENs.InsertOnSubmit(nv);
            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) // sua
        {
            NHANVIEN nv = new NHANVIEN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            nv = db.NHANVIENs.Where(s => s.MaNV == textBox2.Text).Single();
            nv.TenNV = textBox2.Text;
            nv.DiaChi = textBox3.Text;
            nv.SDT = textBox4.Text;
            nv.ChucVu = textBox5.Text;
            nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
            nv.GioiTinh = Boolean.Parse(textBox7.Text);
           
           
            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) // xoa
        {
            NHANVIEN nv = new NHANVIEN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            nv = db.NHANVIENs.Where(s => s.MaNV == textBox2.Text).Single();
           
            db.NHANVIENs.DeleteOnSubmit(nv);
            db.SubmitChanges();
            FrmNhanVien_Load(sender, e);
        }

        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.NHANVIENs where (s.TenNV.Contains(textBox10.Text) 
                       || s.TenNV.Contains(textBox10.Text)) select s).ToList();
            dataGridView1.DataSource = Lst;
           
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox6.DataBindings.Clear();
            textBox7.DataBindings.Clear();
           
          
        
            textBox2.DataBindings.Add("text", Lst, "tennv");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "chucvu");
            textBox6.DataBindings.Add("text", Lst, "ngaynhanviec");
            textBox7.DataBindings.Add("text", Lst, "gioitinh");
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmBan frm1= new FrmBan();
            frm1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmCafe frm2= new FrmCafe();    
            frm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm3= new FrmCaLamViec();
            frm3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm4  = new FrmChiNhanh();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm5= new FrmHoaDon();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm6= new FrmKhach();
            frm6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm7= new FrmQLNhanVien();
            frm7.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Diendan frm8= new Diendan();
            frm8.Show();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
