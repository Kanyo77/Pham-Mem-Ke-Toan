using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKeToan
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                String username, password;
                username = textBox1.Text;
                password = textBox4.Text;

                try
                {
                    String querry = "Select * from tLogin where Id='" + textBox1.Text + "' and Passwork='" + textBox4.Text + "'";
                    // String querry = "Select * from DangKyUser where username='" + textBox1.Text + "' and password='" + textBox4.Text + "'";
                    SqlDataAdapter ada = new SqlDataAdapter(querry, cnn);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = textBox1.Text;
                        password = textBox4.Text;

                        MessageBox.Show("Đăng Nhập thành công ");

                        this.Hide();

                        Frm_Menu menu_From = new Frm_Menu();
                        menu_From.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                        textBox4.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Không được để trống thông tin");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
