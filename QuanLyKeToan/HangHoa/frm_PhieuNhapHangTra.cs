using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKeToan.HangHoa
{
    public partial class frm_PhieuNhapHangTra : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        Bitmap bitmap;
        public frm_PhieuNhapHangTra()
        {
            InitializeComponent();
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
            string sql = "select * from tPhieuNhapHangTraLaiChiTiet";  // lay het du lieu trong bang sinh vien
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

        }

        private void frm_PhieuNhapHangTra_Load(object sender, EventArgs e)
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
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaKhachHang"].FormattedValue.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["cTenKhachHang"].FormattedValue.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaSoThue"].FormattedValue.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGiaVon"].FormattedValue.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGiaVon"].FormattedValue.ToString();

                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNoGTGT"].FormattedValue.ToString();
                textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCoGiaBan"].FormattedValue.ToString();
                textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells["cBieuThue"].FormattedValue.ToString();
                textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoSeRi"].FormattedValue.ToString();
                textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells["cSoHoaDon"].FormattedValue.ToString();
                textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells["dNgayHoaDon"].FormattedValue.ToString();
                textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueSuat"].FormattedValue.ToString();
                textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells["nThueGTGT"].FormattedValue.ToString();
                
            
        }
            }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
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
                textBox27.Text = dataGridView2.Rows[e.RowIndex].Cells["nSoLuong"].FormattedValue.ToString();

                textBox23.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaVon"].FormattedValue.ToString();
                textBox24.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaVon"].FormattedValue.ToString();
                textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells["nDonGiaBan"].FormattedValue.ToString();
                textBox26.Text = dataGridView2.Rows[e.RowIndex].Cells["nThanhTienGiaBan"].FormattedValue.ToString();
            }
            }
       
       

       

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectedText = "PHIEU THU";
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            /*
            //using (frm_PhieuNhapHangTra frm=new frm_PhieuNhapHangTra( )) ;
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0,0, dataGridView1.Width, dataGridView1.Height));
            // printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            // printPreviewDialog1.ShowDialog();
            //dataGridView1.Height = height;
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
            */
            /*
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();
            */

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
          
            string sql = "SELECT * FROM tPhieuNhapHangTraLai";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tPhieuNhapHangTraLai");
            connection.Close();
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "tPhieuNhapHangTraLai";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            printDocument1.Print();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");

            string sql = "SELECT * FROM from tPhieuNhapHangTraLaiChiTiet";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tPhieuNhapHangTraLaiChiTiet");
            connection.Close();
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "tPhieuNhapHangTraLaiChiTiet";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");

            string sql = "SELECT * FROM tPhieuNhapHangTraLai";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "tPhieuNhapHangTraLai");
            connection.Close();
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "tPhieuNhapHangTraLai";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
