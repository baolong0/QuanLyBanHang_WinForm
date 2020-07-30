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
    public partial class frmDanhMuc_KhachHang : Form
    {
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        public frmDanhMuc_KhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dgvKhachHang.CurrentCell.RowIndex;

            if (dgvKhachHang.Rows[index].Cells[0].Value.ToString() == txtMaKhachHang.Text.Trim())
            {
                Khach suakh = (from kh in qlbh.Khaches
                               where kh.MaKhach == txtMaKhachHang.Text.Trim()
                               select kh).Single<Khach>();

                suakh.TenKhach = txtTenKhachHang.Text;
                suakh.DiaChi = txtDiaChi.Text;
                suakh.DienThoai = maskDienThoai.Text;

                qlbh.SaveChanges();
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Không được sửa mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmDanhMuc_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        void LoadKhachHang()
        {
            var dskh = from kh in qlbh.Khaches
                       select new
                       {
                           kh.MaKhach,
                           kh.TenKhach,
                           kh.DiaChi,
                           kh.DienThoai
                       };

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = dskh.ToList();
        }

        private void dgvKhachHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskDienThoai.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Khach kh = new Khach();
            kh.MaKhach = txtMaKhachHang.Text;
            kh.TenKhach = txtTenKhachHang.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.DienThoai = maskDienThoai.Text;

            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }
            if (txtTenKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khác hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhachHang.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }

            for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
            {
                if (txtMaKhachHang.Text == dgvKhachHang.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            qlbh.Khaches.Add(kh);
            qlbh.SaveChanges();
            LoadKhachHang();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //if (dgvNhanVien.Text == "")
                //{
                //    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Khach xoakh = (from kh in qlbh.Khaches
                                   where kh.MaKhach == txtMaKhachHang.Text.Trim()
                                   select kh).Single<Khach>();

                    qlbh.Khaches.Remove(xoakh);
                    qlbh.SaveChanges();
                    LoadKhachHang();

                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể xoá khách hàng! Khách hàng đã thực hiện giao dịch","Lỗi");
            }
             
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvKhachHang.Columns.Count + 1; i++) //Duyệt theo cột
                {
                    excel.Cells[1, i] = dgvKhachHang.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvKhachHang.Rows.Count; i++)//Duyệt theo dòng
                {
                    for (int j = 0; j < dgvKhachHang.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dgvKhachHang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = qlbh.Khaches.Where(x => x.MaKhach.Contains(txtMaKhachHang.Text)).ToList();
        }
    }
}
