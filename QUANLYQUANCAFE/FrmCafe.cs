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
    public partial class FrmCafe : Form
    {
        public FrmCafe()
        {
            InitializeComponent();
        }


        

        CAFE cf = new CAFE();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var CAFE = from sp in db.CAFEs
                       select new
                       {
                           sp.MaCF,
                           sp.TenCF,
                           sp.SoLuong,
                           sp.HinhAnh,
                       };
            dataGridView1.DataSource = CAFE;
            
        }

        private void FrmCafe_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CAFEs select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox1.DataBindings.Add("text", Lst, "macf");
            textBox2.DataBindings.Add("text", Lst, "tencf");
            textBox3.DataBindings.Add("text", Lst, "soluong");
            textBox4.DataBindings.Add("text", Lst, "gia");
            textBox5.DataBindings.Add("text", Lst, "hinhanh");

        }

        private void Add_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            cf.MaCF = textBox1.Text;
            cf.TenCF = textBox2.Text;
            if (textBox3.Text == "")
            {
                cf.SoLuong = 0;
            }
            else
                cf.SoLuong = int.Parse(textBox3.Text);
            if (textBox4.Text == "")
            {
                cf.Gia = 0;
            }
            else
                cf.SoLuong = int.Parse(textBox4.Text);
            //cf.HinhAnh = ;
            db.CAFEs.InsertOnSubmit(cf);
            db.SubmitChanges();
            FrmCafe_Load(sender, e);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            cf = db.CAFEs.Where(s => s.MaCF == textBox1.Text).Single();
            cf.MaCF = textBox1.Text;
            cf.TenCF = textBox2.Text;
            if (textBox3.Text != "")
                cf.SoLuong = int.Parse(textBox3.Text);
            if (textBox4.Text != "")
                cf.SoLuong = int.Parse(textBox4.Text);
            //cf.HinhAnh = ;
            db.SubmitChanges();
            FrmCafe_Load(sender, e);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            cf = db.CAFEs.Where(s => s.MaCF == textBox1.Text).Single();
            cf.MaCF = textBox1.Text;

            db.CAFEs.DeleteOnSubmit(cf);

            db.SubmitChanges();
            FrmCafe_Load(sender, e);

        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CAFEs
                       where (s.MaCF.Contains(Search.Text))
                       select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox1.DataBindings.Add("text", Lst, "macf");
            textBox2.DataBindings.Add("text", Lst, "tencf");
            textBox3.DataBindings.Add("text", Lst, "soluong");
            textBox4.DataBindings.Add("text", Lst, "gia");
            textBox5.DataBindings.Add("text", Lst, "hinhanh");

        }
    }
}
