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
    public partial class Frm_DoanhMucHangHoa : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        public Frm_DoanhMucHangHoa()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tDanhMucHangHoa";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }



        private void Frm_DoanhMucHangHoa_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaHang"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenHang"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["cNhomHang"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["cDonViTinh"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["nSoLuongTonDau"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["nThanhTienTonDau"].FormattedValue.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayTonDau"].FormattedValue.ToString();
             
            }
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sqlINSET = "INSERT INTO tDanhMucHangHoa VALUES(@cMaHang,@cTenHang,@cNhomHang,@cDonViTinh,@nSoLuongTonDau,@nThanhTienTonDau,@dNgayTonDau)";
                SqlCommand cmd = new SqlCommand(sqlINSET, cnn);
                cmd.Parameters.AddWithValue("cMaHang", textBox1.Text);
                cmd.Parameters.AddWithValue("cTenHang", textBox2.Text);
                cmd.Parameters.AddWithValue("cNhomHang", textBox3.Text);
                cmd.Parameters.AddWithValue("cDonViTinh", textBox4.Text);
                cmd.Parameters.AddWithValue("nSoLuongTonDau", textBox5.Text);

                cmd.Parameters.AddWithValue("nThanhTienTonDau", textBox6.Text);
                cmd.Parameters.AddWithValue("dNgayTonDau", textBox7.Text);
                cmd.ExecuteNonQuery();
               
                cnn.Close();
                
            }
            catch
            {
                MessageBox.Show("Không được để trống thông tin");
            }
        }

        private void btt_dele_Click(object sender, EventArgs e)
        {
            try { 
            cnn.Open();
            string sqlDELETE = "DELETE tDanhMucHangHoa WHERE cMaHang=@cMaHang";
            SqlCommand cmd = new SqlCommand(sqlDELETE, cnn);
            cmd.Parameters.AddWithValue("cMaHang", textBox1.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không được để trống thông tin");
            }
}

        private void btt_up_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string sqlINSET = "UPDATE tDanhMucHangHoa SET cTenHang=@cTenHang,cNhomHang=@cNhomHang,cDonViTinh=@cDonViTinh,nSoLuongTonDau=@nSoLuongTonDau,nThanhTienTonDau=@nThanhTienTonDau,dNgayTonDau=@dNgayTonDau  WHERE cMaHang=@cMaHang";
                SqlCommand cmd = new SqlCommand(sqlINSET, cnn);
                cmd.Parameters.AddWithValue("cMaHang", textBox1.Text);
                cmd.Parameters.AddWithValue("cTenHang", textBox2.Text);
                cmd.Parameters.AddWithValue("cNhomHang", textBox3.Text);
                cmd.Parameters.AddWithValue("cDonViTinh", textBox4.Text);
                cmd.Parameters.AddWithValue("nSoLuongTonDau", textBox5.Text);

                cmd.Parameters.AddWithValue("nThanhTienTonDau", textBox6.Text);
                cmd.Parameters.AddWithValue("dNgayTonDau", textBox7.Text);
                cmd.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Không được để trống thông tin");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "select * from tDanhMucHangHoa where cMaHang like '%" + textBox8.Text + "%' ";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
    }
}
