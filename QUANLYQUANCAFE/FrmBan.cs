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
            loadDSMaBan();
        }
       
       // BAN bn = new BAN();
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
        private void loadDSMaBan()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            List<BAN> lstBAN = db.BANs.ToList();
            BAN BN = new BAN();
            BN.MaBan = "ALL";

            lstBAN.Insert(0, BN);

            comboBox1.DataSource = lstBAN;
            comboBox1.DisplayMember = "maban";
            comboBox1.ValueMember = "maban";


        }
        private void FrmBan_Load(object sender, EventArgs e)
        {
            
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.BANs select s).ToList();
            dataGridView1.DataSource = Lst;
           /* textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
           
            textBox1.DataBindings.Add("text", Lst, "maban");
            textBox2.DataBindings.Add("text", Lst, "tenban");
            textBox3.DataBindings.Add("text", Lst, "trangthai");
            textBox4.DataBindings.Add("text", Lst, "macn");*/
            
        }

        private void button2_Click(object sender, EventArgs e)//them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            BAN bn = new BAN();
            bn.MaBan = textBox1.Text;
            bn.TenBan = textBox2.Text;
            bn.TrangThai = Boolean.Parse(textBox3.Text);
            bn.MaCN = textBox4.Text;
            
            db.BANs.InsertOnSubmit(bn);
            db.SubmitChanges();
            FrmBan_Load(sender, e);
        }
       

        private void button3_Click(object sender, EventArgs e)//sua
        {
            BAN bn = new BAN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            bn = db.BANs.Where(s => s.MaBan == textBox1.Text).Single();
            bn.TenBan = textBox2.Text;
            bn.TrangThai = Boolean.Parse(textBox3.Text);
            bn.MaCN = textBox4.Text;
            
            db.SubmitChanges();
            FrmBan_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) //xoa
        {
            BAN bn = new BAN();
            DataClasses1DataContext db = new DataClasses1DataContext();
            bn = db.BANs.Where(s => s.MaBan == textBox1.Text).Single();

           
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

        private void button5_Click(object sender, EventArgs e)
        {
            FrmInBan frminban = new FrmInBan(comboBox1.SelectedValue.ToString());
            frminban.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
                FrmCafe frm1 = new FrmCafe();
                frm1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm2 = new FrmCaLamViec();
            frm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm3 = new FrmChiNhanh();
            frm3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm4 = new FrmHoaDon();
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm5 = new FrmKhach();
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

        private void button14_Click(object sender, EventArgs e)
        {
            Diendan frm8= new Diendan();   
            frm8.Show();
        }
    }
}
