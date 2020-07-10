namespace Quanlybanhang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDanhMuc_ChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_HoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem_Hang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_HangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup_GioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTroGiup});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.mnu.Size = new System.Drawing.Size(1060, 42);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(115, 38);
            this.mnuFile.Text = "&Tệp Tin";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(295, 44);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc_NhanVien,
            this.mnuDanhMuc_KhachHang,
            this.toolStripMenuItem2,
            this.mnuDanhMuc_ChatLieu,
            this.mnuDanhMuc_HangHoa});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(146, 38);
            this.mnuDanhMuc.Text = "&Danh Mục";
            // 
            // mnuDanhMuc_NhanVien
            // 
            this.mnuDanhMuc_NhanVien.Name = "mnuDanhMuc_NhanVien";
            this.mnuDanhMuc_NhanVien.Size = new System.Drawing.Size(359, 44);
            this.mnuDanhMuc_NhanVien.Text = "&Nhân Viên";
            this.mnuDanhMuc_NhanVien.Click += new System.EventHandler(this.mnuDanhMuc_NhanVien_Click);
            // 
            // mnuDanhMuc_KhachHang
            // 
            this.mnuDanhMuc_KhachHang.Name = "mnuDanhMuc_KhachHang";
            this.mnuDanhMuc_KhachHang.Size = new System.Drawing.Size(359, 44);
            this.mnuDanhMuc_KhachHang.Text = "&Khách Hàng";
            this.mnuDanhMuc_KhachHang.Click += new System.EventHandler(this.mnuDanhMuc_KhachHang_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(356, 6);
            // 
            // mnuDanhMuc_ChatLieu
            // 
            this.mnuDanhMuc_ChatLieu.Name = "mnuDanhMuc_ChatLieu";
            this.mnuDanhMuc_ChatLieu.Size = new System.Drawing.Size(359, 44);
            this.mnuDanhMuc_ChatLieu.Text = "&Chất Liệu";
            this.mnuDanhMuc_ChatLieu.Click += new System.EventHandler(this.mnuDanhMuc_ChatLieu_Click);
            // 
            // mnuDanhMuc_HangHoa
            // 
            this.mnuDanhMuc_HangHoa.Name = "mnuDanhMuc_HangHoa";
            this.mnuDanhMuc_HangHoa.Size = new System.Drawing.Size(359, 44);
            this.mnuDanhMuc_HangHoa.Text = "&Hàng Hóa";
            this.mnuDanhMuc_HangHoa.Click += new System.EventHandler(this.mnuDanhMuc_HangHoa_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon_HoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(130, 38);
            this.mnuHoaDon.Text = "&Hóa Đơn";
            // 
            // mnuHoaDon_HoaDonBan
            // 
            this.mnuHoaDon_HoaDonBan.Name = "mnuHoaDon_HoaDonBan";
            this.mnuHoaDon_HoaDonBan.Size = new System.Drawing.Size(291, 44);
            this.mnuHoaDon_HoaDonBan.Text = "&Hóa Đơn Bán";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiem_HoaDon,
            this.mnuTimKiem_Hang,
            this.mnuTimKiem_KhachHang});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(136, 38);
            this.mnuTimKiem.Text = "&Tìm Kiếm";
            // 
            // mnuTimKiem_HoaDon
            // 
            this.mnuTimKiem_HoaDon.Name = "mnuTimKiem_HoaDon";
            this.mnuTimKiem_HoaDon.Size = new System.Drawing.Size(278, 44);
            this.mnuTimKiem_HoaDon.Text = "&Hóa Đơn";
            // 
            // mnuTimKiem_Hang
            // 
            this.mnuTimKiem_Hang.Name = "mnuTimKiem_Hang";
            this.mnuTimKiem_Hang.Size = new System.Drawing.Size(278, 44);
            this.mnuTimKiem_Hang.Text = "&Hàng";
            // 
            // mnuTimKiem_KhachHang
            // 
            this.mnuTimKiem_KhachHang.Name = "mnuTimKiem_KhachHang";
            this.mnuTimKiem_KhachHang.Size = new System.Drawing.Size(278, 44);
            this.mnuTimKiem_KhachHang.Text = "&Khách Hàng";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCao_HangTon,
            this.mnuBaoCao_DoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(123, 38);
            this.mnuBaoCao.Text = "&Báo Cáo";
            // 
            // mnuBaoCao_HangTon
            // 
            this.mnuBaoCao_HangTon.Name = "mnuBaoCao_HangTon";
            this.mnuBaoCao_HangTon.Size = new System.Drawing.Size(268, 44);
            this.mnuBaoCao_HangTon.Text = "&Hàng Tồn";
            // 
            // mnuBaoCao_DoanhThu
            // 
            this.mnuBaoCao_DoanhThu.Name = "mnuBaoCao_DoanhThu";
            this.mnuBaoCao_DoanhThu.Size = new System.Drawing.Size(268, 44);
            this.mnuBaoCao_DoanhThu.Text = "&Doanh Thu";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTroGiup_TroGiup,
            this.mnuTroGiup_GioiThieu});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(125, 38);
            this.mnuTroGiup.Text = "&Trợ Giúp";
            // 
            // mnuTroGiup_TroGiup
            // 
            this.mnuTroGiup_TroGiup.Name = "mnuTroGiup_TroGiup";
            this.mnuTroGiup_TroGiup.Size = new System.Drawing.Size(258, 44);
            this.mnuTroGiup_TroGiup.Text = "Trợ Giúp";
            // 
            // mnuTroGiup_GioiThieu
            // 
            this.mnuTroGiup_GioiThieu.Name = "mnuTroGiup_GioiThieu";
            this.mnuTroGiup_GioiThieu.Size = new System.Drawing.Size(258, 44);
            this.mnuTroGiup_GioiThieu.Text = "Giới Thiệu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1060, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quản Lý Bán Hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc_ChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_HoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem_Hang;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_HangTon;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup_GioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

