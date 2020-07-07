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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuDanhMuc_ChatLieu_Click(object sender, EventArgs e)
        {
            frmDanhMuc_ChatLieu frmChatLieu = new frmDanhMuc_ChatLieu();
            frmChatLieu.Show(); //Showdialog hiển thị, khác với show đó là showdialog khi tắt form mới làm tiếp được

        }
    }
}
