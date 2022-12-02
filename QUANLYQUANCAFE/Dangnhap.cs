using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QUANLYQUANCAFE
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
       
       
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-UBJFF1FB;Initial Catalog=QUANLYCAFE3;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            // ẩn từ đây    
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
                    Properties.Settings.Default.ss = textBox1.Text;
                    MessageBox.Show("Đăng nhập thành công");
                    Option frm = new Option();
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
            // đến đây để bỏ đăng nhập + bắt buộc mở 6 dòng dưới

            
            //Properties.Settings.Default.ss = textBox1.Text;
            //MessageBox.Show("Đăng nhập thành công");
            //Option frm = new Option();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
        }
        private void Timer(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else textBox2.UseSystemPasswordChar = true;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            private void textBox1_Click(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;   
            }    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Signup fm = new Signup();
            fm.ShowDialog();
        }
    }
}
