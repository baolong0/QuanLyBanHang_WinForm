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
    public partial class frmHoaDonBan : Form
    {
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadHoaDonBan();
            LoadMaHang();
            LoadMaNhanVien();
            LoadMaKhachHang();
        }

        void LoadHoaDonBan()
        {
            var hoadon = from hd in qlbh.ChiTietHoaDons
                         join hd2 in qlbh.HoaDonBans on hd.MaHDBan equals hd2.MaHDBan
                         select new
                         {
                             hd.MaHDBan,
                             hd2.Khach.TenKhach,
                             hd2.NhanVien.TenNhanVien,
                             hd2.NgayBan,
                             hd.MaHang,
                             hd.ThanhTien,
                             hd.SoLuong,
                             hd.DonGia,
                         };
            dgvHoaDonBanHang.DataSource = null;
            dgvHoaDonBanHang.DataSource = hoadon.ToList();
           
        }

        void LoadMaNhanVien()
        {
            var manv = from nv in qlbh.NhanViens
                       select new
                       {
                           nv.MaNhanVien
                       };
            cbxMaNhanVien.DataSource = manv.ToList();
            cbxMaNhanVien.DisplayMember = "TenNhanVien";
            cbxMaNhanVien.ValueMember = "MaNhanVien";

        }
        void LoadMaKhachHang()
        {
            var makh = from kh in qlbh.Khaches
                       select new
                       {
                           kh.MaKhach
                       };
            cbxMaKhachHang.DataSource = makh.ToList();
            cbxMaKhachHang.DisplayMember = "TenKhach";
            cbxMaKhachHang.ValueMember = "MaKhach";

        }

        void LoadMaHang()
        {
            var mahang = from hh in qlbh.Hangs
                         select new
                         {
                             hh.MaHang
                         };
            cbxMaHang.DataSource = mahang.ToList();
            cbxMaHang.DisplayMember = "TenHang";
            cbxMaHang.ValueMember = "MaHang";
        }

        private void dgvHoaDonBanHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //cbxMaHang.SelectedValue = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtTenHang.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtSoLuong.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtDonGia.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtGiamGia.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtThanhTien.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        { 
            // tạo mới hoá đơn
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHDBan = txtMaHoaDon.Text;
            cthd.MaHang = cbxMaHang.SelectedValue.ToString();
            cthd.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            cthd.DonGia = Convert.ToInt32(txtDonGia.Text);
            cthd.GiamGia = Convert.ToInt32(txtGiamGia.Text);
            cthd.ThanhTien = Convert.ToInt32(txtThanhTien.Text);

            HoaDonBan hdb = new HoaDonBan();
            hdb.MaHDBan = txtMaHoaDon.Text;
            hdb.MaNhanVien = cbxMaNhanVien.SelectedValue.ToString();
            hdb.NgayBan = dtpNgayBan.Value;
            hdb.MaKhach = cbxMaKhachHang.SelectedValue.ToString();
            hdb.TongTien = Convert.ToInt32(txtThanhTien.Text);

            // cập nhật số lượng mới vào kho
            List<Hang> hanglist = qlbh.Hangs.ToList<Hang>();
            for (int i = 0; i < hanglist.Count; i++)
            {
                if (hanglist[i].MaHang ==cbxMaHang.SelectedValue.ToString())
                {
                    if (hanglist[i].SoLuong >= Convert.ToInt32(txtSoLuong.Text))
                    {
                        hanglist[i].SoLuong = hanglist[i].SoLuong - Convert.ToInt32(txtSoLuong.Text);
                        MessageBox.Show( "Thêm Hoá đơn thành công \n"+"số lượng " + hanglist[i].TenHang + " còn lại " + hanglist[i].SoLuong);
                        qlbh.ChiTietHoaDons.Add(cthd);
                        qlbh.HoaDonBans.Add(hdb);
                        qlbh.SaveChanges();
                        LoadHoaDonBan();
                    }  
                    else 
                    {
                        MessageBox.Show("Số Lượng " + hanglist[i].TenHang + " trong kho không còn đủ số lượng \n Thêm mới hoá đơn "+ txtMaHoaDon.Text+" KHÔNG THÀNH CÔNG" );
                        
                    }
                } 
            }
        
        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVien> nhanvienlist = qlbh.NhanViens.ToList<NhanVien>();
            NhanVien nvchon = new NhanVien();
            txtTenNhanVien.Text = nhanvienlist[0].TenNhanVien;
            nvchon.MaNhanVien = cbxMaNhanVien.SelectedValue.ToString();
            for (int i = 0; i < nhanvienlist.Count; i++)
            {
                NhanVien nvlist = nhanvienlist[i];
                if (nvchon.MaNhanVien == nvlist.MaNhanVien)
                {
                    txtTenNhanVien.Text = nvlist.TenNhanVien;
                    break;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Khach> khachlist = qlbh.Khaches.ToList<Khach>();
            Khach khachchon = new Khach();
            txtTenKhachHang.Text = khachlist[0].TenKhach;
            txtDiaChi.Text = khachlist[0].DiaChi;
            maskSoDienThoai.Text = khachlist[0].DienThoai;
            khachchon.MaKhach = cbxMaKhachHang.SelectedValue.ToString();
            for (int i = 0; i < khachlist.Count; i++)
            {
                Khach nvlist = khachlist[i];
                if (khachchon.MaKhach == nvlist.MaKhach)
                {
                    txtTenKhachHang.Text = nvlist.TenKhach;
                    txtDiaChi.Text = nvlist.DiaChi;
                    maskSoDienThoai.Text = nvlist.DienThoai;
                    break;
                }
            }
        }

        private void cbxMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Hang> hanglist = qlbh.Hangs.ToList<Hang>();
            Hang hangchon = new Hang();
            txtTenHang.Text = hanglist[0].TenHang;
            txtDonGia.Text = hanglist[0].DonGiaBan.ToString();
            hangchon.MaHang = cbxMaHang.SelectedValue.ToString();
            for (int i = 0; i < hanglist.Count; i++)
            {
                Hang nvlist = hanglist[i];
                if (hangchon.MaHang == nvlist.MaHang)
                {
                    txtTenHang.Text = nvlist.TenHang;
                    txtDonGia.Text = nvlist.DonGiaBan.ToString();
                    break;
                }
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia != null && txtDonGia != null && txtSoLuong != null)
                {
                    int SoLuong = 1, DonGia = 1, GiamGia = 1;
                    SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    DonGia = Convert.ToInt32(txtDonGia.Text);
                    GiamGia = Convert.ToInt32(txtGiamGia.Text);
                    txtThanhTien.Text = (SoLuong * DonGia - DonGia * SoLuong * GiamGia / 100).ToString();
                    txtTongTien.Text = txtThanhTien.Text;
                }
            }
            catch { }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia != null && txtDonGia != null && txtSoLuong != null)
                {
                    int SoLuong = 1, DonGia = 1, GiamGia = 1;
                    SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    DonGia = Convert.ToInt32(txtDonGia.Text);
                    GiamGia = Convert.ToInt32(txtGiamGia.Text);
                    txtThanhTien.Text = (SoLuong * DonGia - DonGia * SoLuong * GiamGia / 100).ToString();
                    txtTongTien.Text = txtThanhTien.Text;
                }
            }
            catch { }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia != null && txtDonGia != null && txtSoLuong != null)
                {
                    int SoLuong = 1, DonGia = 1, GiamGia = 1;
                    SoLuong = Convert.ToInt32(txtSoLuong.Text);
                    DonGia = Convert.ToInt32(txtDonGia.Text);
                    GiamGia = Convert.ToInt32(txtGiamGia.Text);
                    txtThanhTien.Text = (SoLuong * DonGia - DonGia * SoLuong * GiamGia / 100).ToString();
                    txtTongTien.Text = txtThanhTien.Text;
                }
            }
            catch {  }
        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
        }
    }
}
