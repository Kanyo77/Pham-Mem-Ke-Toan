using QuanLyKeToan.Chungtu;
using QuanLyKeToan.HangHoa;
//using QuanLyKeToan.PhieuChi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKeToan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmPhieuThu());
            //Application.Run(new frmPhieuChi());
            //Application.Run(new frm_PhieuNhapHangTra());
            Application.Run(new Form1());
        }
    }
}
