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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                DataClasses1DataContext db = new DataClasses1DataContext();
                NHANVIEN nv = new NHANVIEN();
                nv.MaNV = textBox8.Text;
                nv.TenNV = textBox2.Text;
                nv.DiaChi = textBox3.Text;
                nv.SDT = textBox4.Text;
                nv.ChucVu = textBox5.Text;
                if (textBox6.Text == "")
                    nv.NgayNhanViec = DateTime.Now;
                else
                    nv.NgayNhanViec = DateTime.Parse(textBox6.Text);
                nv.GioiTinh = Boolean.Parse(textBox7.Text);
               
                nv.MatKhau = textBox9.Text;
                if (textBox9.Text != textBox10.Text)
                    MessageBox.Show("mat khau ban nhap khong khop");
                else
                {
                    db.NHANVIENs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    //DANGKI_Load(sender, e);
                    MessageBox.Show("tao tai khoan thanh cong");
                }
            

        }

       
    }
}
