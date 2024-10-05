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
    public partial class frm_tDanhMucTaiKhoan : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        public frm_tDanhMucTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_tDanhMucTaiKhoan_Load(object sender, EventArgs e)
        {
                 ketnoicsdl();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tDanhMucTaiKhoan";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void frm_tDanhMucTaiKhoan_Load_1(object sender, EventArgs e)
        {

        }


      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoan"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenTaiKhoan"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["nSoDuNoDau"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["nSoDuCoDau"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["bCoDinhKhoan"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["cCap"].FormattedValue.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgaySoDu"].FormattedValue.ToString();
            }
        }
        
        private void btt_add_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sqlINSET = "INSERT INTO tDanhMucTaiKhoan VALUES(@cTaiKhoan,@cTenTaiKhoan,@nSoDuNoDau,@nSoDuCoDau,@bCoDinhKhoan,@cCap,@dNgaySoDu)";
            SqlCommand cmd = new SqlCommand(sqlINSET, cnn);
            cmd.Parameters.AddWithValue("@cTaiKhoan", textBox1.Text);
            cmd.Parameters.AddWithValue("cTenTaiKhoan", textBox2.Text);
            cmd.Parameters.AddWithValue("@nSoDuNoDa", textBox3.Text);
            cmd.Parameters.AddWithValue("@bCoDinhKhoan", textBox4.Text);
            cmd.Parameters.AddWithValue("@cCap", textBox5.Text);
            cmd.Parameters.AddWithValue("@dNgaySoDu", textBox6.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();

           

        }

        private void btt_dele_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch 
            {
            
            }

        }

        private void btt_up_Click(object sender, EventArgs e)
        {   
            try
            {
                cnn.Open();
                string sqlINSET = "UPDATE  tDanhMucTaiKhoan SET cTenTaiKhoan=@cTenTaiKhoan,nSoDuNoDau=@nSoDuNoDau,nSoDuCoDau=@nSoDuCoDau,bCoDinhKhoan=@bCoDinhKhoan,cCap=@cCap,dNgaySoDu=@dNgaySoDu WHERE cTaiKhoan=@cTaiKhoan";
                SqlCommand cmd = new SqlCommand(sqlINSET, cnn);
                cmd.Parameters.AddWithValue("@cTaiKhoan", textBox1.Text);
                cmd.Parameters.AddWithValue("cTenTaiKhoan", textBox2.Text);
                cmd.Parameters.AddWithValue("@nSoDuNoDa", textBox3.Text);
                cmd.Parameters.AddWithValue("@bCoDinhKhoan", textBox4.Text);
                cmd.Parameters.AddWithValue("@cCap", textBox5.Text);
                cmd.Parameters.AddWithValue("@dNgaySoDu", textBox6.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Cap nhat thanh cong");
            }
            catch
            {
                MessageBox.Show("Hay kiem tra lai");
            }

        }
    }
}
