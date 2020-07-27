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
    public partial class frmTimKiemHoaDon : Form
    {
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        private void lblTimKiemHoaDon_Click(object sender, EventArgs e)
        {

        }
        void TimKiem()
        {
            var ds_find = (from h in qlbh.HoaDonBans
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem(string ma_hd, string ma_nv)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaHDBan.Contains(ma_hd) & h.MaNhanVien.Contains(ma_nv)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem(string ma_hd, string ma_nv, string ma_kh)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaHDBan.Contains(ma_hd) & h.MaNhanVien.Contains(ma_nv) & h.MaKhach.Contains(ma_kh)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem1(string ma_kh, string ma_nv)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaKhach.Contains(ma_kh) & h.MaNhanVien.Contains(ma_nv)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem2(string ma_hd, string ma_kh)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaHDBan.Contains(ma_hd) & h.MaKhach.Contains(ma_kh)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem_tb1(string ma_hd)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaHDBan.Contains(ma_hd)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem_tb2(string ma_kh)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaKhach.Contains(ma_kh)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        void TimKiem_tb3(string ma_nv)
        {
            //var ds_find = (from h in qlbh.HoaDonBans join nv in qlbh.NhanViens on h.MaNhanVien equals nv.MaNhanVien where h.MaHDBan.Contains(ma_hd) & nv.MaNhanVien.Contains(ma_nv) 
            // select new {}
            var ds_find = (from h in qlbh.HoaDonBans
                           where h.MaNhanVien.Contains(ma_nv)
                           select new
                           {
                               MaHDBan = h.MaHDBan,
                               MaNhanVien = h.MaNhanVien,
                               NgayBan = h.NgayBan,
                               MaKhach = h.MaKhach,
                               TongTien = h.TongTien
                           }).ToList();
            dgvTimKiemHoaDon.DataSource = ds_find;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "" && txtMaKhachHang.Text != "" && txtMaNhanVien.Text != "") TimKiem(txtMaHoaDon.Text, txtMaNhanVien.Text, txtMaKhachHang.Text);
            else if (txtMaHoaDon.Text != "" || txtMaNhanVien.Text != "") TimKiem(txtMaHoaDon.Text, txtMaNhanVien.Text);
            else if (txtMaKhachHang.Text != "" || txtMaNhanVien.Text != "") TimKiem1(txtMaKhachHang.Text, txtMaNhanVien.Text);
            else if (txtMaHoaDon.Text != "" || txtMaKhachHang.Text != "") TimKiem2(txtMaHoaDon.Text, txtMaKhachHang.Text);
            else if (txtMaHoaDon.Text != "") TimKiem_tb1(txtMaHoaDon.Text);
            else if (txtMaKhachHang.Text != "") TimKiem_tb2(txtMaKhachHang.Text);
            else if (txtMaNhanVien.Text != "") TimKiem_tb3(txtMaNhanVien.Text);
            else TimKiem();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
