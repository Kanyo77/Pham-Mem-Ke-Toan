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

namespace QuanLyKeToan.HangHoa
{
    public partial class Frm_PhieuXuat : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;

        public Frm_PhieuXuat()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tPhieuXuatHangHoa";  // lay het du lieu trong bang sinh vien
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
            string sql = "select * from tPhieuXuatHangHoaChiTiet";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void Frm_PhieuXuat_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl2();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["cLoaiChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaKhachHang"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenKhachHang"].FormattedValue.ToString();

                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaSoThue"].FormattedValue.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGiaVon"].FormattedValue.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGiaVon"].FormattedValue.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGiaBan"].FormattedValue.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGTGT"].FormattedValue.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();

                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["cMatHang"].FormattedValue.ToString();
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueSuat"].FormattedValue.ToString();
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueGTGT"].FormattedValue.ToString();
                textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoSeri"].FormattedValue.ToString();
                textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoHoaDon"].FormattedValue.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox19.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaHang"].FormattedValue.ToString();
                textBox20.Text = dataGridView2.Rows[e.RowIndex].Cells["cDonViTinh"].FormattedValue.ToString();
                textBox21.Text = dataGridView2.Rows[e.RowIndex].Cells["nSoLuong"].FormattedValue.ToString();

                textBox23.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaVon"].FormattedValue.ToString();
                textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaVon"].FormattedValue.ToString();
                textBox22.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaBan"].FormattedValue.ToString();
               // textBox24.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaBa"].FormattedValue.ToString();
                textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTuNhap"].FormattedValue.ToString();
                
            }
            }
        }
}
