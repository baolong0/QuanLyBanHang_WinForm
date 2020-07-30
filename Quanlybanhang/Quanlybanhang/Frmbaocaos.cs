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
    public partial class Frmbaocaos : Form
    {
        public Frmbaocaos()
        {
            InitializeComponent();
        }

        private void Frmbaocaos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanHangDataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.ChiTietHoaDonTableAdapter.Fill(this.QuanLyBanHangDataSet.ChiTietHoaDon);
            // TODO: This line of code loads data into the 'QuanLyBanHangDataSet.Hang' table. You can move, or remove it, as needed.
            this.HangTableAdapter.Fill(this.QuanLyBanHangDataSet.Hang);

            this.reportViewer1.RefreshReport();
        }
    }
}
