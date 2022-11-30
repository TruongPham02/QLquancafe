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
    public partial class FrmCaLamViec : Form
    {
        public FrmCaLamViec()
        {
            InitializeComponent();
        }
        CALAMVIEC clv = new CALAMVIEC();
        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var calamviec = from sp in db.CALAMVIECs
                            select new
                            {
                                sp.MaCLV,
                                sp.TenCLV,
                                sp.GioBD,
                                sp.GioKT,
                                sp.SoTien,
                            };
            dataGridView1.DataSource = calamviec;
        }

        private void FrmCaLamViec_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CALAMVIECs select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();
            

            textBox1.DataBindings.Add("text", Lst, "maclv");
            textBox2.DataBindings.Add("text", Lst, "tenclv");
            textBox3.DataBindings.Add("text", Lst, "giobd");
            textBox4.DataBindings.Add("text", Lst, "giokt");
            textBox5.DataBindings.Add("text", Lst, "sotien");
           
        }

        private void button2_Click(object sender, EventArgs e) // them
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            clv.MaCLV = textBox1.Text;
            clv.TenCLV = textBox2.Text;
            clv.GioBD = DateTime.Parse(textBox3.Text);
            clv.GioKT = DateTime.Parse(textBox4.Text);
            clv.SoTien = int.Parse(textBox5.Text);
           
            db.CALAMVIECs.InsertOnSubmit(clv);
            db.SubmitChanges();
            FrmCaLamViec_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)//sua
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            clv = db.CALAMVIECs.Where(s => s.MaCLV == textBox1.Text).Single();
            clv.TenCLV = textBox2.Text;
            clv.GioBD = DateTime.Parse(textBox3.Text);
            clv.GioKT = DateTime.Parse(textBox4.Text);
            clv.SoTien = int.Parse(textBox5.Text);

            
            db.SubmitChanges();
            FrmCaLamViec_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e) // xóa
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            clv = db.CALAMVIECs.Where(s => s.MaCLV == textBox1.Text).Single();
            clv.TenCLV = textBox2.Text;
            clv.GioBD = DateTime.Parse(textBox3.Text);
            clv.GioKT = DateTime.Parse(textBox4.Text);
            clv.SoTien = int.Parse(textBox5.Text);
            db.CALAMVIECs.DeleteOnSubmit(clv);

            db.SubmitChanges();
            FrmCaLamViec_Load(sender, e);
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e) // tim kiem
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var Lst = (from s in db.CALAMVIECs where (s.MaCLV.Contains(textBox6.Text)||
                       s.TenCLV.Contains(textBox6.Text)) select s).ToList();
            dataGridView1.DataSource = Lst;
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Clear();


            textBox1.DataBindings.Add("text", Lst, "maclv");
            textBox2.DataBindings.Add("text", Lst, "tenclv");
            textBox3.DataBindings.Add("text", Lst, "giobd");
            textBox4.DataBindings.Add("text", Lst, "giokt");
            textBox5.DataBindings.Add("text", Lst, "sotien");
        }
    }
}
