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
    public partial class FrmKhach : Form
    {
        public FrmKhach()
        {
            InitializeComponent();
        }
       
        //KHACH kh = new KHACH();
        private void button1_Click(object sender, EventArgs e) //xem
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            var khach = from sp in db.KHACHes
                        select new
                        {
                            sp.MaKH,
                            sp.TenKH,
                            sp.DiaChi,
                            sp.SDT,
                            sp.DiemTL,
                        };
            dataGridView1.DataSource = khach;
        }

        private void FrmKhach_Load(object sender, EventArgs e)
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.KHACHes select s).ToList();
            dataGridView1.DataSource = Lst;
          /*textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox1.DataBindings.Add("text", Lst, "makh");
            textBox2.DataBindings.Add("text", Lst, "tenkh");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "diemtl");*/


        }

        private void button2_Click(object sender, EventArgs e) //them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            KHACH kh = new KHACH();
            kh.MaKH = textBox1.Text;
            kh.TenKH = textBox2.Text;
            kh.DiaChi = textBox3.Text;
            kh.SDT = textBox4.Text;
            if (textBox5.Text == "")
            {
                kh.DiemTL = 0;
            }
            else
                kh.DiemTL = Int16.Parse(textBox5.Text);
            db.KHACHes.InsertOnSubmit(kh);
            db.SubmitChanges();
            FrmKhach_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e) // sua
        {
            KHACH kh = new KHACH();
            DataClasses1DataContext db = new DataClasses1DataContext();
            kh = db.KHACHes.Where(s => s.MaKH == textBox1.Text).Single();
            kh.TenKH = textBox2.Text;
            kh.DiaChi = textBox3.Text;
            kh.SDT = textBox4.Text;
            if (textBox5.Text != "")
                kh.DiemTL = Int16.Parse(textBox5.Text);
           
            db.SubmitChanges();
            FrmKhach_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //xoa
        {
            KHACH kh = new KHACH();
            DataClasses1DataContext db = new DataClasses1DataContext();
            kh = db.KHACHes.Where(s => s.MaKH == textBox1.Text).Single();
            
            db.KHACHes.DeleteOnSubmit(kh);
            db.SubmitChanges();
            FrmKhach_Load(sender, e);
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.KHACHes where (s.MaKH.Contains(textBox6.Text) || 
                                                   s.TenKH.Contains(textBox6.Text) || 
                                                   s.DiaChi.Contains(textBox6.Text)) select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox1.DataBindings.Add("text", Lst, "makh");
            textBox2.DataBindings.Add("text", Lst, "tenkh");
            textBox3.DataBindings.Add("text", Lst, "diachi");
            textBox4.DataBindings.Add("text", Lst, "sdt");
            textBox5.DataBindings.Add("text", Lst, "diemtl");
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
            FrmHoaDon frm5= new FrmHoaDon();
            frm5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm6= new FrmNhanVien();
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
    }
}
