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
            loadDSMaCF();
        }


        

        //CAFE cf = new CAFE();
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
        private void loadDSMaCF()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            List<CAFE> lstCAFE = db.CAFEs.ToList();
            CAFE CF = new CAFE();
            CF.MaCF = "ALL";

            lstCAFE.Insert(0, CF);

            comboBox1.DataSource = lstCAFE;
            comboBox1.DisplayMember = "maCF";
            comboBox1.ValueMember = "macf";


        }
        private void FrmCafe_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CAFEs select s).ToList();
           dataGridView1.DataSource = Lst;
           /* textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            textBox1.DataBindings.Add("text", Lst, "macf");
            textBox2.DataBindings.Add("text", Lst, "tencf");
            textBox3.DataBindings.Add("text", Lst, "soluong");
            textBox4.DataBindings.Add("text", Lst, "gia");
            textBox5.DataBindings.Add("text", Lst, "hinhanh");*/

        }

        private void Add_Click(object sender, EventArgs e)
        {
            CAFE cf = new CAFE();
            DataClasses1DataContext db = new DataClasses1DataContext();
            cf.MaCF = textBox1.Text;
            cf.TenCF = textBox2.Text;
            if (textBox3.Text == "")
            {
                cf.SoLuong = 0;
            }
            else
                cf.SoLuong =Int16.Parse(textBox3.Text);
            if (textBox4.Text == "")
            {
                cf.Gia = 0;
            }
            else
                cf.Gia = Int16.Parse(textBox4.Text);
            //cf.HinhAnh = ;
            db.CAFEs.InsertOnSubmit(cf);
            db.SubmitChanges();
            FrmCafe_Load(sender, e);

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            CAFE cf = new CAFE();
            DataClasses1DataContext db = new DataClasses1DataContext();
            cf = db.CAFEs.Where(s => s.MaCF == textBox1.Text).Single();
            cf.MaCF = textBox1.Text;
            cf.TenCF = textBox2.Text;
            if (textBox3.Text != "")
                cf.SoLuong = Int16.Parse(textBox3.Text);
            if (textBox4.Text != "")
                cf.SoLuong = Int16.Parse(textBox4.Text);
            //cf.HinhAnh = ;
            db.SubmitChanges();
            FrmCafe_Load(sender, e);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            CAFE cf = new CAFE();
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

        private void button2_Click(object sender, EventArgs e)
        {
            FrmInCaFe frmincafe = new FrmInCaFe(comboBox1.SelectedValue.ToString());
            frmincafe.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmBan frm1 = new FrmBan();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCaLamViec frm2 = new FrmCaLamViec();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmChiNhanh frm3= new FrmChiNhanh();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm4= new FrmHoaDon();    
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKhach frm5= new FrmKhach();
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
