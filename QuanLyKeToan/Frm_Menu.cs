using QuanLyKeToan.Chungtu;
using QuanLyKeToan.HangHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKeToan.Chuong2;

namespace QuanLyKeToan
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan1 taikhoan = new Frm_TaiKhoan1();
            taikhoan.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_DoanhMucHangHoa hangHoa = new Frm_DoanhMucHangHoa();
            hangHoa.ShowDialog();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Menu_From menu_From = new Menu_From();
            //menu_From.ShowDialog();
            frm_ChungTuNganHang frm_NganHang = new frm_ChungTuNganHang();
            frm_NganHang.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frm_ChungTuKetChuyen frm_KetChuyen =new frm_ChungTuKetChuyen();
            frm_KetChuyen.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_Khachhang KhachHang = new frm_Khachhang();
            KhachHang.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            frm_PhieuNhapHangTra phieuchi = new frm_PhieuNhapHangTra();

            phieuchi.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHangHoa NhapHang = new frmPhieuNhapHangHoa();
            NhapHang.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm_PhieuXuatHangTra XuatHang = new frm_PhieuXuatHangTra();
            XuatHang.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmPhieuThu phieuThu = new frmPhieuThu();
            phieuThu.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm_ChungTu chungTu = new frm_ChungTu();
            chungTu.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPhieuNhapHangHoa NhapHang = new frmPhieuNhapHangHoa();
            NhapHang.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_PhieuXuatHangTra XuatHang = new frm_PhieuXuatHangTra();
            XuatHang.ShowDialog();
        }
    }
}
