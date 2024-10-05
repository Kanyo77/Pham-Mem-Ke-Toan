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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKeToan.Chungtu
{
    public partial class frm_ChungTuKetChuyen : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;

        public frm_ChungTuKetChuyen()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tChungTuKetChuyen";  // lay het du lieu trong bang sinh vien
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
            string sql = "select * from tChungTuKetChuyenChiTiet";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void frm_ChungTuKetChuyen_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cLoaiChungTu"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();
              

            }
            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells["cDienGiaiChiTiet"].FormattedValue.ToString();
                textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells["cTaiKhoanNo"].FormattedValue.ToString();
                textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells["cTaiKhoanCo"].FormattedValue.ToString();
                textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells["nSoTien"].FormattedValue.ToString();


            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
