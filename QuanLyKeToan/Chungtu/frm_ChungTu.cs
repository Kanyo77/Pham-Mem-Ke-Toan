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

namespace QuanLyKeToan.Chungtu
{
    public partial class frm_ChungTu : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        public frm_ChungTu()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tChungTuGhiSo";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void ketnoicsdl2()
        {
            cnn.Open();
            string sql = "select * from tChungTuGhiSoChiTiet";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }
      
        private void tabPage1_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cLoaiChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaKhachHangNo"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenKhachHangNo"].FormattedValue.ToString();

                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaSoThueNo"].FormattedValue.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaKhachHangCo"].FormattedValue.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenKhachHangCo"].FormattedValue.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaSoThueCo"].FormattedValue.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["cBieuThue"].FormattedValue.ToString();

                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoSeRi"].FormattedValue.ToString();
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoHoaDon"].FormattedValue.ToString();
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayHoaDon"].FormattedValue.ToString();
                textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueSuat"].FormattedValue.ToString();
                textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueGTGT"].FormattedValue.ToString();
                textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells["cMatHang"].FormattedValue.ToString();

            }
        }

        private void frm_ChungTu_Load_1(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl2();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;

                textBox19.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox20.Text = dataGridView2.Rows[e.RowIndex].Cells["nMaSo"].FormattedValue.ToString();
                textBox21.Text = dataGridView2.Rows[e.RowIndex].Cells["cDienGiaiChiTiet"].FormattedValue.ToString();

                textBox24.Text = dataGridView2.Rows[e.RowIndex].Cells["nSoTien"].FormattedValue.ToString();
                textBox23.Text = dataGridView2.Rows[e.RowIndex].Cells["cTaiKhoanNo"].FormattedValue.ToString();
                textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells["cTaiKhoanCo"].FormattedValue.ToString();
            }

        }
    }
}
