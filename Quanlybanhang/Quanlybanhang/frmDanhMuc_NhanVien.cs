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
    public partial class frmDanhMuc_NhanVien : Form
    {
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        public frmDanhMuc_NhanVien()
        {
            InitializeComponent();
        }

        private void lblDanhMucNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void frmDanhMuc_NhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        void LoadNhanVien()
        {
            var dsnv = from nv in qlbh.NhanViens
                       select new
                       {
                           nv.MaNhanVien,
                           nv.TenNhanVien,
                           nv.GioiTinh,
                           nv.DiaChi,
                           nv.DienThoai,
                           nv.NgaySinh,
                       };

            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = dsnv.ToList();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNhanVien.Text;
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.DienThoai = maskDienThoai.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.GioiTinh = chkGioiTinh.Checked.ToString();

            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }

            for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                if (txtMaNhanVien.Text == dgvNhanVien.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            void Kiemtragioitinh()
            {
                if (chkGioiTinh.Checked == true)
                {
                    nv.GioiTinh = "Nam";
                }
                else
                {
                    nv.GioiTinh = "Nữ";
                }
            }

            Kiemtragioitinh();
            qlbh.NhanViens.Add(nv);
            qlbh.SaveChanges();
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.Rows.Count == 0)
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
                    NhanVien xoanv = (from nv in qlbh.NhanViens
                                      where nv.MaNhanVien == txtMaNhanVien.Text.Trim()
                                      select nv).Single<NhanVien>();

                    qlbh.NhanViens.Remove(xoanv);
                    qlbh.SaveChanges();
                    LoadNhanVien();

                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Không thể xoá nhân viên! Nhân viên đã xử lý giao dịch", "Lỗi");
            }
            
        }

        private void dgvNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            chkGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskDienThoai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dgvNhanVien.CurrentCell.RowIndex;

            if (dgvNhanVien.Rows[index].Cells[0].Value.ToString() == txtMaNhanVien.Text.Trim())
            {
                NhanVien suanv = (from nv in qlbh.NhanViens
                                  where nv.MaNhanVien == txtMaNhanVien.Text.Trim()
                                  select nv).Single<NhanVien>();

                suanv.TenNhanVien = txtTenNhanVien.Text;
                suanv.DiaChi = txtDiaChi.Text;
                suanv.DienThoai = maskDienThoai.Text;
                suanv.NgaySinh = dtpNgaySinh.Value;
                suanv.GioiTinh = chkGioiTinh.Checked.ToString();

                void Kiemtragioitinh()
                {
                    if (chkGioiTinh.Checked == true)
                    {
                        suanv.GioiTinh = "Nam";
                    }
                    else
                    {
                        suanv.GioiTinh = "Nữ";
                    }
                }

                Kiemtragioitinh();
                qlbh.SaveChanges();
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Không được sửa mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           dgvNhanVien.DataSource = qlbh.NhanViens.Where(x => x.MaNhanVien.Contains(txtMaNhanVien.Text)).ToList();    
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvNhanVien.Columns.Count + 1; i++) //Duyệt theo cột
                {
                    excel.Cells[1, i] = dgvNhanVien.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvNhanVien.Rows.Count; i++)//Duyệt theo dòng
                {
                    for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
