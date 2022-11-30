using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QUANLYQUANCAFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UBJFF1FB;Initial Catalog=QUANLYCAFE3;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String tk = textBox1.Text;
                String mk = textBox2.Text;
                String sql = "SELECT * FROM NHANVIEN WHERE MaNV = '" + textBox1.Text + "' AND MatKhau = '" + textBox2.Text + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(sql, conn);
                DataTable dta = new DataTable();
                cmd.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Form2 frm = new Form2();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        private void Timer(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else textBox2.UseSystemPasswordChar = true;
        }
    }
}
