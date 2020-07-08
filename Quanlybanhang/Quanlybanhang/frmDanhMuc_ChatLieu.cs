using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlybanhang;

namespace Quanlybanhang
{
    public partial class frmDanhMuc_ChatLieu : Form
    {
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();
        public frmDanhMuc_ChatLieu()
        {
            InitializeComponent();
        }

        private void dgvChatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void LoadChatLieu()
        {
            var dssp = from sp in qlbh.ChatLieux
                       select new
                       {
                           sp.MaChatLieu,
                           sp.TenChatLieu,
                       };
            dgvChatLieu.DataSource = null;
            dgvChatLieu.DataSource = dssp.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChatLieu sp = new ChatLieu();
            sp.MaChatLieu = txtMaChatLieu.Text;
            sp.TenChatLieu = txtTenChatLieu.Text;
            if (txtMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }
            if (txtTenChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChatLieu.Focus(); //Lệnh đặt con trỏ ngay vị trí đó
                return;
            }

            for (int i = 0; i < dgvChatLieu.Rows.Count; i++)
            {
                if (txtMaChatLieu.Text == dgvChatLieu.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Trùng dữ liệu", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            //Thêm cái khi thêm nếu có MaChatLieu rồi thì thông báo trùng
            qlbh.ChatLieux.Add(sp);
            qlbh.SaveChanges();
            LoadChatLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChatLieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ChatLieu xoasp = (from sp in qlbh.ChatLieux
                                  where sp.MaChatLieu == txtMaChatLieu.Text.Trim()
                                  select sp).Single<ChatLieu>();
                qlbh.ChatLieux.Remove(xoasp);
                qlbh.SaveChanges();
                LoadChatLieu();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmDanhMuc_ChatLieu_Load(object sender, EventArgs e)
        {
            LoadChatLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChatLieu suasp = (from sp in qlbh.ChatLieux
                              where sp.MaChatLieu == txtMaChatLieu.Text.Trim()
                              select sp).Single<ChatLieu>();
            suasp.TenChatLieu = txtTenChatLieu.Text;
            qlbh.SaveChanges();
            LoadChatLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            if (dgvChatLieu.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvChatLieu.Columns.Count + 1; i++) //Duyệt theo cột
                {
                    excel.Cells[1, i] = dgvChatLieu.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvChatLieu.Rows.Count; i++)//Duyệt theo dòng
                {
                    for (int j = 0; j < dgvChatLieu.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = dgvChatLieu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }
        private void dgvChatLieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaChatLieu.Text = dgvChatLieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenChatLieu.Text = dgvChatLieu.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        
    }
}
