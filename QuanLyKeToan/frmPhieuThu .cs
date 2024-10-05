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
    public partial class frmPhieuThu : Form
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=KANYOGAMU\SQLEXPRESS;Database=DBAccounting;Integrated Security = True");
        SqlConnection sqlConnection = new SqlConnection(strConnection);
        private static string strConnection;
        public frmPhieuThu()
        {
            InitializeComponent();
        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            ketnoicsdl2();
        }
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from tPhieuThuChiTiet";  // lay het du lieu trong bang sinh vien
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
            string sql = "select * from tPhieuThu";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
                textBox2.Text = dataGridView2.Rows[e.RowIndex].Cells["cLoaiChungTu"].FormattedValue.ToString();
                textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells["dNgayChungTu"].FormattedValue.ToString();
                textBox4.Text = dataGridView2.Rows[e.RowIndex].Cells["cSoChungTu"].FormattedValue.ToString();
                textBox5.Text = dataGridView2.Rows[e.RowIndex].Cells["cHoTen"].FormattedValue.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["cDiaChi"].FormattedValue.ToString();
                textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells["cSoChungTuGoc"].FormattedValue.ToString();
                textBox8.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaKhachHang"].FormattedValue.ToString();
                textBox9.Text = dataGridView2.Rows[e.RowIndex].Cells["cTenKhachHang"].FormattedValue.ToString();
                textBox10.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaSoThue"].FormattedValue.ToString();
                textBox11.Text = dataGridView2.Rows[e.RowIndex].Cells["cDienGiai"].FormattedValue.ToString();
                textBox12.Text = dataGridView2.Rows[e.RowIndex].Cells["cBieuThue"].FormattedValue.ToString();
                textBox13.Text = dataGridView2.Rows[e.RowIndex].Cells["cSoSeRi"].FormattedValue.ToString();
                textBox14.Text = dataGridView2.Rows[e.RowIndex].Cells["cSoHoaDon"].FormattedValue.ToString();
                textBox15.Text = dataGridView2.Rows[e.RowIndex].Cells["cMaSoThue"].FormattedValue.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["dNgayHoaDon"].FormattedValue.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["nThueSuat"].FormattedValue.ToString();
                textBox6.Text = dataGridView2.Rows[e.RowIndex].Cells["cMatHang"].FormattedValue.ToString();

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox30.Text = dataGridView1.Rows[e.RowIndex].Cells["cMaChungTu"].FormattedValue.ToString();
            textBox23.Text = dataGridView1.Rows[e.RowIndex].Cells["cDienGiaiChiTiet"].FormattedValue.ToString();
            textBox28.Text = dataGridView1.Rows[e.RowIndex].Cells["nSoTien"].FormattedValue.ToString();
            textBox19.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanNo"].FormattedValue.ToString();
            textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells["cTaiKhoanCo"].FormattedValue.ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sendTo1 = textBox15.Text;
            string sendTo2 = textBox5.Text;
            string sendTo3 = textBox1.Text;
            string sendTo4 = textBox9.Text;
            string sendTo5 = textBox22.Text;
            string sendTo6 = textBox24.Text;
            richTextBox1.SelectionFont = new Font("Lucinda Console", 8);
            richTextBox1.SelectedText = "Công Ty TNHH T-A.\n 168a Văn Thn P8 Q6.\n";
            richTextBox1.SelectedText = "  MST:" + sendTo1 + " \n";

            richTextBox1.SelectedText = "PHIEU THU";
            richTextBox1.SelectionFont = new Font("Lucinda Console", 8);
            richTextBox1.SelectedText = "   Ngay:" + DateTime.Now + " \n";
            richTextBox1.SelectedText = "  Họ tên người nộp:" + sendTo2 + " \n";
            richTextBox1.SelectedText = "Địa chỉ :" + sendTo3 + " \n";
            richTextBox1.SelectedText = "   Lý do thu:" + sendTo4 + " \n";
            richTextBox1.SelectedText = "   Số tiền:" + sendTo5 + " \n";
            richTextBox1.SelectedText = "   Viết bằng chữ:" + sendTo6 + " \n";
            richTextBox1.SelectedText = "   Kèm theo: Chứng từ gốc \n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Người lập phiếu - - - - - Người nộp tiền - - - - - Thử quỹ - - - - - Kế toán trưởng - - - - - Giám đốc\n";

            richTextBox1.Text += "(Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên)\n";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sendTo1 = textBox16.Text;
            string sendTo2 = textBox18.Text;
            string sendTo3 = textBox20.Text;
            string sendTo4 = textBox21.Text;
            string sendTo5 = textBox22.Text;
            string sendTo6 = textBox24.Text;
            richTextBox1.SelectionFont = new Font("Lucinda Console", 8);
            richTextBox1.SelectedText = "Công Ty TNHH T-A.\n 168a Văn Thn P8 Q6.\n";
            richTextBox1.SelectedText = "  MST:" + sendTo1 + " \n";

            richTextBox1.SelectedText = "PHIEU THU";
            richTextBox1.SelectionFont = new Font("Lucinda Console", 8);
            richTextBox1.SelectedText = "   Ngay:" + DateTime.Now + " \n";
            richTextBox1.SelectedText = "  Họ tên người nộp:" + sendTo2 + " \n";
            richTextBox1.SelectedText = "Địa chỉ :" + sendTo3 + " \n";
            richTextBox1.SelectedText = "   Lý do thu:" + sendTo4 + " \n";
            richTextBox1.SelectedText = "   Số tiền:" + sendTo5 + " \n";
            richTextBox1.SelectedText = "   Viết bằng chữ:" + sendTo6 + " \n";
            richTextBox1.SelectedText = "   Kèm theo: Chứng từ gốc \n";
            richTextBox1.Text += "\n";
            richTextBox1.Text += "Người lập phiếu - - - - - Người nộp tiền - - - - - Thử quỹ - - - - - Kế toán trưởng - - - - - Giám đốc\n";

            richTextBox1.Text += "(Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên) - - (Kí ghi rõ họ tên)\n";
        }
    }
}
