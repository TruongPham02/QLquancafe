using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYQUANCAFE
{
    public partial class FrmQLNhanVien : Form
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
        }

        //QUANLYNHANVIEN ql = new QUANLYNHANVIEN();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var quanlynhanvien = from sp in db.QUANLYNHANVIENs
                                 select new
                                 {
                                     sp.MaQL,
                                     sp.MaNV,
                                     sp.MaCLV,
                                 };
            dataGridView1.DataSource = quanlynhanvien;
        }
        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.QUANLYNHANVIENs select s).ToList();
            dataGridView1.DataSource = Lst;
           /* textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();


            textBox1.DataBindings.Add("text", Lst, "maql");
            textBox2.DataBindings.Add("text", Lst, "manv");
            textBox3.DataBindings.Add("text", Lst, "maclv");*/

        }

        private void button2_Click(object sender, EventArgs e) //them
        {
            QUANLYNHANVIEN ql = new QUANLYNHANVIEN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            ql.MaQL = textBox1.Text;
            ql.MaNV = textBox2.Text;
            ql.MaCLV = textBox3.Text;


            db.QUANLYNHANVIENs.InsertOnSubmit(ql);
            db.SubmitChanges();
            FrmQLNhanVien_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) // sua
        {
            QUANLYNHANVIEN ql = new QUANLYNHANVIEN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            ql = db.QUANLYNHANVIENs.Where(s => s.MaQL == textBox1.Text).Single();

            ql.MaNV = textBox2.Text;
            ql.MaCLV = textBox3.Text;

            db.SubmitChanges();
            FrmQLNhanVien_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //xóa
        {
            QUANLYNHANVIEN ql = new QUANLYNHANVIEN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            ql = db.QUANLYNHANVIENs.Where(s => s.MaQL == textBox1.Text).Single();

            

            db.QUANLYNHANVIENs.DeleteOnSubmit(ql);
            db.SubmitChanges();
            FrmQLNhanVien_Load(sender, e);
        }


        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.QUANLYNHANVIENs
                       where (s.MaQL.Contains(textBox4.Text) ||
                              s.MaNV.Contains(textBox4.Text) ||
                              s.MaCLV.Contains(textBox4.Text))
                       select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();


            textBox1.DataBindings.Add("text", Lst, "maql");
            textBox2.DataBindings.Add("text", Lst, "manv");
            textBox3.DataBindings.Add("text", Lst, "maclv");


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
            FrmChiNhanh frm4= new FrmChiNhanh();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm5 = new FrmHoaDon();
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

        private void button13_Click(object sender, EventArgs e)
        {
            Diendan frm8= new Diendan();
        }
    }
}
