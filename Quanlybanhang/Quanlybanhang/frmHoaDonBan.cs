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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvHoaDonBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadHoaDonBan();
            LoadMaHang();
            LoadMaNhanVien();
        }

        void LoadHoaDonBan()
        {
            var hoadon = from hd in qlbh.Hangs join hd2 in qlbh.ChiTietHoaDons on hd.MaHang equals hd2.MaHang
                         select new
                         {
                             hd.MaHang,
                             hd.TenHang,
                             hd.SoLuong,
                             hd.DonGiaBan,
                             hd2.GiamGia,
                             hd2.ThanhTien
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDonBanHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxMaHang.SelectedValue = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonGia.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGiamGia.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtThanhTien.Text = dgvHoaDonBanHang.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.GiamGia = Convert.ToInt32(txtGiamGia.Text);
            cthd.ThanhTien = Convert.ToInt32(txtThanhTien.Text);

            Hang hh = new Hang();
            hh.MaHang = cbxMaHang.SelectedValue.ToString();
            hh.TenHang = txtTenHang.Text;
            hh.DonGiaBan = Convert.ToInt32(txtDonGia.Text);
            hh.SoLuong = Convert.ToInt32(txtSoLuong.Text);

            HoaDonBan hd = new HoaDonBan();
            hd.MaHDBan = txtMaHoaDon.Text;
            hd.NgayBan = dtpNgayBan.Value;
            hd.MaNhanVien = cbxMaNhanVien.SelectedValue.ToString();

            NhanVien nv = new NhanVien();
            nv.TenNhanVien = txtTenNhanVien.Text;

            Khach kh = new Khach();
            kh.MaKhach = txtMaKhachHang.Text;
            kh.TenKhach = txtTenKhachHang.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.DienThoai = maskSoDienThoai.Text;

            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng hoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }

            for (int i = 0; i < dgvHoaDonBanHang.Rows.Count; i++)
            {
                if (txtTenHang.Text == dgvHoaDonBanHang.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //Thêm cái khi thêm nếu có MaChatLieu rồi thì thông báo trùng
            qlbh.Hangs.Add(hh);
            qlbh.ChiTietHoaDons.Add(cthd);
            qlbh.HoaDonBans.Add(hd);
            qlbh.NhanViens.Add(nv);
            qlbh.SaveChanges();
            LoadHoaDonBan();
        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
