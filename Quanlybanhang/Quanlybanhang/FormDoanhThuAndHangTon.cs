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
    public partial class FormDoanhThuAndHangTon : Form
    {
        public FormDoanhThuAndHangTon()
        {
            InitializeComponent();
        }
        QuanlybanhangEntities qlbh = new QuanlybanhangEntities();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            var slht = from ht in qlbh.Hangs
                       select new
                       {
                           ht.MaHang,
                           ht.TenHang,
                           ht.MaChatLieu,
                           ht.SoLuong
                       };
            dataGridHangTon.DataSource = null;
            dataGridHangTon.DataSource = slht.ToList();
            var dtbh = from ds in qlbh.ChiTietHoaDons
                       select new
                       {
                           ds.MaHDBan,
                           ds.MaHang,
                           ds.SoLuong,
                           ds.DonGia,
                           ds.GiamGia,
                           ds.ThanhTien
                       };
            dataGridDoanhThu.DataSource = null;
            dataGridDoanhThu.DataSource = dtbh.ToList();
            var Thanh_Toan_Colume = (from ds in qlbh.ChiTietHoaDons select ds.ThanhTien).ToList();
            double sum = Thanh_Toan_Colume.Sum();
            lbTT.Text = sum.ToString();


        }

        private void dataGridDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
