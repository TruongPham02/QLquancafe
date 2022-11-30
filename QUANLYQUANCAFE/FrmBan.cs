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
    public partial class FrmBan : Form
    {
        public FrmBan()
        {
            InitializeComponent();
        }
       
        BAN bn = new BAN();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var BAN = from sp in db.BANs
                      select new
                      {
                          sp.MaBan,
                          sp.TenBan,
                          sp.TrangThai,
                          sp.MaCN,
                      };
            dataGridView1.DataSource = BAN;


        }

        private void FrmBan_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.BANs select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
           
            textBox1.DataBindings.Add("text", Lst, "maban");
            textBox2.DataBindings.Add("text", Lst, "tenban");
            textBox3.DataBindings.Add("text", Lst, "trangthai");
            textBox4.DataBindings.Add("text", Lst, "macn");
            
        }

        private void button2_Click(object sender, EventArgs e)//them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            bn.MaBan = textBox1.Text;
            bn.TenBan = textBox2.Text;
            bn.TrangThai = bool.Parse(textBox3.Text);
            bn.MaCN = textBox4.Text;
            
            db.BANs.InsertOnSubmit(bn);
            db.SubmitChanges();
            FrmBan_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)//sua
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            bn = db.BANs.Where(s => s.MaBan == textBox1.Text).Single();
            bn.TenBan = textBox2.Text;
            bn.TrangThai = bool.Parse(textBox3.Text);
            bn.MaCN = textBox4.Text;
            
            db.SubmitChanges();
            FrmBan_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //xoa
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            bn = db.BANs.Where(s => s.MaBan == textBox1.Text).Single();

            bn.TenBan = textBox2.Text;
            bn.TrangThai = bool.Parse(textBox3.Text);
            bn.MaCN = textBox4.Text;
            db.BANs.DeleteOnSubmit(bn);
            db.SubmitChanges();
            FrmBan_Load(sender, e);
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.BANs
                       where (s.MaBan.Contains(textBox5.Text) ||
                              s.TenBan.Contains(textBox5.Text)) select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();

            textBox1.DataBindings.Add("text", Lst, "maban");
            textBox2.DataBindings.Add("text", Lst, "tenban");
            textBox3.DataBindings.Add("text", Lst, "trangthai");
            textBox4.DataBindings.Add("text", Lst, "macn");
        }
    }
}
