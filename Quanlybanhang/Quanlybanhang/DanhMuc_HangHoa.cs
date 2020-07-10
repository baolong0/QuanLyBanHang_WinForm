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
    public partial class frmDanhMuc_HangHoa : Form
    {
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        public frmDanhMuc_HangHoa()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hang sp = new Hang();
            sp.MaHang = txtMaHang.Text;
            sp.TenHang = txtTenHang.Text;
            sp.MaChatLieu = cbxMaChatLieu.SelectedValue.ToString(); //Lỗi, định nghĩa lại ở phần combobox
            sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            sp.DonGiaNhap = Convert.ToInt32(txtDonGiaNhap.Text);
            sp.DonGiaBan = Convert.ToInt32(txtDonGiaBan.Text);
            sp.Anh = txtAnh.Text;
            sp.GhiChu = txtGhiChu.Text;
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng hoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng hoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }

            for (int i = 0; i < dgvHangHoa.Rows.Count; i++)
            {
                if (txtMaHang.Text == dgvHangHoa.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //Thêm cái khi thêm nếu có MaChatLieu rồi thì thông báo trùng
            qlbh.Hangs.Add(sp);
            qlbh.SaveChanges();
            LoadHangHoa();
        }

        private void frmDanhMuc_HangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            LoadMaChatLieu();
        }

        void LoadHangHoa()
        {
            var dshh = from sp in qlbh.Hangs join vl in qlbh.ChatLieux on sp.MaChatLieu equals vl.MaChatLieu
                       select new
                       {
                           sp.MaHang,
                           sp.TenHang,
                           sp.MaChatLieu,
                           sp.SoLuong,
                           sp.DonGiaNhap,
                           sp.DonGiaBan,    
                           sp.Anh,
                           sp.GhiChu
                       };
            dgvHangHoa.DataSource = null;
            dgvHangHoa.DataSource = dshh.ToList();
        }
        void LoadMaChatLieu()
        {
            var machatlieu = from cl in qlbh.Hangs
                             select new
                             {
                                 cl.MaChatLieu
                             };
            cbxMaChatLieu.DataSource = machatlieu.ToList();
            cbxMaChatLieu.DisplayMember = "MaChatLieu";
            cbxMaChatLieu.ValueMember = "MaChatLieu";
        }
        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hang xoasp = (from sp in qlbh.Hangs
                                  where sp.MaHang == txtMaHang.Text.Trim()
                                  select sp).Single<Hang>();
                qlbh.Hangs.Remove(xoasp);
                qlbh.SaveChanges();
                LoadHangHoa();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvHangHoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHang.Text = dgvHangHoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbxMaChatLieu.SelectedValue = dgvHangHoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgvHangHoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvHangHoa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAnh.Text = dgvHangHoa.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtGhiChu.Text = dgvHangHoa.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Hang suasp = (from sp in qlbh.Hangs
                              where sp.MaHang == txtMaHang.Text.Trim()
                              select sp).Single<Hang>();
            suasp.TenHang = txtTenHang.Text;
            suasp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            suasp.MaChatLieu = cbxMaChatLieu.Text;
            suasp.DonGiaNhap = Convert.ToInt32(txtDonGiaNhap.Text);
            suasp.DonGiaBan = Convert.ToInt32(txtDonGiaBan.Text);
            suasp.Anh = txtAnh.Text;
            suasp.GhiChu = txtGhiChu.Text;
            qlbh.SaveChanges();
            LoadHangHoa();
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvHangHoa.Columns.Count + 1; i++) //Duyệt theo cột
                {
                    excel.Cells[1, i] = dgvHangHoa.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvHangHoa.Rows.Count; i++)//Duyệt theo dòng
                {
                    for (int j = 0; j < dgvHangHoa.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dgvHangHoa.Rows[i].Cells[j].Value.ToString();
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
