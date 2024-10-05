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

namespace QuanLyKeToan.HangHoa
{
    public partial class frm_PhieuXuatHangTra : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        public frm_PhieuXuatHangTra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tPhieuNhapHangTraLai";  // lay het du lieu trong bang sinh vien
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
            string sql = "select * from tPhieuXuatHangTraLaiChiTiet";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void frm_PhieuXuatHangTra_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl2();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cLoaiChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaKhachHang"].FormattedValue.ToString();

                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenKhachHang"].FormattedValue.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaSoThue"].FormattedValue.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGTGT"].FormattedValue.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGiaVon"].FormattedValue.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGiaVon"].FormattedValue.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGiaBan"].FormattedValue.ToString();

                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGTGT"].FormattedValue.ToString();
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGiaBan"].FormattedValue.ToString();
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoSeRi"].FormattedValue.ToString();
                textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoHoaDon"].FormattedValue.ToString();
                textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayHoaDon"].FormattedValue.ToString();
            }
            }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                textBox19.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox20.Text = dataGridView2.Rows[e.RowIndex].Cells["nMaSo"].FormattedValue.ToString();
                textBox21.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaHang"].FormattedValue.ToString();
                textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells["cDonViTinh"].FormattedValue.ToString();
                textBox23.Text = dataGridView2.Rows[e.RowIndex].Cells["nSoLuong"].FormattedValue.ToString();
                textBox24.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaVon"].FormattedValue.ToString();
                textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaVon"].FormattedValue.ToString();
                textBox26.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaVon"].FormattedValue.ToString();
                textBox27.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaMua"].FormattedValue.ToString();
                textBox28.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaMua"].FormattedValue.ToString();
                textBox29.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTuNhap"].FormattedValue.ToString();
            }
            }
        }
}
