using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuDanhMuc_ChatLieu_Click(object sender, EventArgs e)
        {
            frmDanhMuc_ChatLieu frmChatLieu = new frmDanhMuc_ChatLieu();
            frmChatLieu.Show(); //Showdialog hiển thị, khác với show đó là showdialog khi tắt form mới làm tiếp được

        }

        private void mnuDanhMuc_HangHoa_Click(object sender, EventArgs e)
        {
            frmDanhMuc_HangHoa frmHangHoa = new frmDanhMuc_HangHoa();
            frmHangHoa.Show();
        }

        private void mnuDanhMuc_KhachHang_Click(object sender, EventArgs e)
        {
            frmDanhMuc_KhachHang frmKhachHang = new frmDanhMuc_KhachHang();
            frmKhachHang.Show();
        }

        private void mnuDanhMuc_NhanVien_Click(object sender, EventArgs e)
        {
            frmDanhMuc_NhanVien frmNhanVien = new frmDanhMuc_NhanVien();
            frmNhanVien.Show();
        }

        private void mnuHoaDon_HoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            frmHoaDonBan.Show();
        }
    }
}
