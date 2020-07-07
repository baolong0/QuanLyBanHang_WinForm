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
            LoadChatLieu();
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
            qlbh.ChatLieux.Add(sp);
            qlbh.SaveChanges();
            LoadChatLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChatLieu xoasp = (from sp in qlbh.ChatLieux
                              where sp.MaChatLieu == txtMaChatLieu.Text.Trim()
                              select sp).Single<ChatLieu>();
            qlbh.ChatLieux.Remove(xoasp);
            qlbh.SaveChanges();
            LoadChatLieu();
        }
    }
}
