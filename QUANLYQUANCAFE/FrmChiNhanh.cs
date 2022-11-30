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
        }

        CHINHANH cn = new CHINHANH();
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

        private void FrmChiNhanh_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CHINHANHs select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            checkBox1.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "macn");
            textBox2.DataBindings.Add("text", Lst, "tencn");
            checkBox1.DataBindings.Add("checked", Lst, "trangthai");

        }

        private void Add_Click(object sender, EventArgs e)
        {
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
    }
}
