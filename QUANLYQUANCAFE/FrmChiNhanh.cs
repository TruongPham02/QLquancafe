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
    public partial class FrmChiNhanh : Form
    {
        public FrmChiNhanh()
        {
            InitializeComponent();
            loadDSMaCN();
        }

        //CHINHANH cn = new CHINHANH();
        private void button1_Click(object sender, EventArgs e) // xem
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var chinhanh = from sp in db.CHINHANHs
                           select new
                           {
                               sp.MaCN,
                               sp.TenCN,
                               sp.TrangThai,
                           };
            dataGridView1.DataSource = chinhanh;

        }
        private void loadDSMaCN()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            List<CHINHANH> lstCN = db.CHINHANHs.ToList();
            CHINHANH CN = new CHINHANH();
            CN.MaCN = "ALL";

            lstCN.Insert(0, CN);

            comboBox1.DataSource = lstCN;
            comboBox1.DisplayMember = "maCN";
            comboBox1.ValueMember = "maCN";


        }
        private void FrmChiNhanh_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CHINHANHs select s).ToList();
            dataGridView1.DataSource = Lst;
            /*textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            checkBox1.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "macn");
            textBox2.DataBindings.Add("text", Lst, "tencn");
            checkBox1.DataBindings.Add("checked", Lst, "trangthai");*/

        }

        private void Add_Click(object sender, EventArgs e)
        {
            CHINHANH cn = new CHINHANH();
            DataClasses1DataContext db = new DataClasses1DataContext();
            cn.MaCN = textBox1.Text;
            cn.TenCN = textBox2.Text;
            if (checkBox1.Checked)
            {
                cn.TrangThai = checkBox1.Checked;
            }
            db.CHINHANHs.InsertOnSubmit(cn);
            db.SubmitChanges();
            FrmChiNhanh_Load(sender, e);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            CHINHANH cn = new CHINHANH();
            DataClasses1DataContext db = new DataClasses1DataContext();
            cn = db.CHINHANHs.Where(s => s.MaCN == textBox1.Text).Single();
            cn.MaCN = textBox1.Text;
            cn.TenCN = textBox2.Text;
            if (checkBox1.Checked)
            {
                cn.TrangThai = checkBox1.Checked;
            }

            db.SubmitChanges();
            FrmChiNhanh_Load(sender, e);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            CHINHANH cn = new CHINHANH();
            cn = db.CHINHANHs.Where(s => s.MaCN == textBox1.Text).Single();
            cn.MaCN = textBox1.Text;

            db.CHINHANHs.DeleteOnSubmit(cn);

            db.SubmitChanges();
            FrmChiNhanh_Load(sender, e);

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e) // tim kiem
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CHINHANHs
                       where (s.MaCN.Contains(textBox3.Text))
                       select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "macn");
            textBox2.DataBindings.Add("text", Lst, "tencn");
            //checkBox1.DataBindings.Add("checked", Lst, "trangthai");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInChiNhanh frmichinhanh = new FrmInChiNhanh(comboBox1.SelectedValue.ToString());
            frmichinhanh.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBan frm1 = new FrmBan();
            frm1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmCafe frm8 = new FrmCafe();
            frm8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm2= new FrmCaLamViec();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm3 = new FrmHoaDon();   
            frm3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm4 = new FrmKhach();
            frm4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm5= new FrmNhanVien();
            frm5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm6= new FrmQLNhanVien();
            frm6.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Diendan frm7= new Diendan();
            frm7.Show();
        }
    }
}
