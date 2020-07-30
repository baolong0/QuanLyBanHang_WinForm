namespace Quanlybanhang
{
    partial class frmHoaDonBan
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaKhachHang = new System.Windows.Forms.ComboBox();
            this.maskSoDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cbxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoaDonBanHang = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxMaHang = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblHoaDonBanHang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(809, 554);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaKhachHang);
            this.groupBox1.Controls.Add(this.maskSoDienThoai);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.cbxMaNhanVien);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(797, 172);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // cbxMaKhachHang
            // 
            this.cbxMaKhachHang.FormattingEnabled = true;
            this.cbxMaKhachHang.Location = new System.Drawing.Point(489, 24);
            this.cbxMaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaKhachHang.Name = "cbxMaKhachHang";
            this.cbxMaKhachHang.Size = new System.Drawing.Size(198, 21);
            this.cbxMaKhachHang.TabIndex = 16;
            this.cbxMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbxMaKhachHang_SelectedIndexChanged);
            // 
            // maskSoDienThoai
            // 
            this.maskSoDienThoai.Enabled = false;
            this.maskSoDienThoai.Location = new System.Drawing.Point(489, 127);
            this.maskSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.maskSoDienThoai.Mask = "(999) 000-0000";
            this.maskSoDienThoai.Name = "maskSoDienThoai";
            this.maskSoDienThoai.Size = new System.Drawing.Size(198, 20);
            this.maskSoDienThoai.TabIndex = 15;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(131, 61);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(198, 20);
            this.dtpNgayBan.TabIndex = 14;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(131, 94);
            this.cbxMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.Size = new System.Drawing.Size(198, 21);
            this.cbxMaNhanVien.TabIndex = 13;
            this.cbxMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxMaNhanVien_SelectedIndexChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(131, 127);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(198, 20);
            this.txtTenNhanVien.TabIndex = 12;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(489, 61);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(198, 20);
            this.txtTenKhachHang.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(489, 95);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(131, 29);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(198, 20);
            this.txtMaHoaDon.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hoá Đơn";
            // 
            // lblHoaDonBanHang
            // 
            this.lblHoaDonBanHang.AutoSize = true;
            this.lblHoaDonBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBanHang.ForeColor = System.Drawing.Color.Black;
            this.lblHoaDonBanHang.Location = new System.Drawing.Point(238, 12);
            this.lblHoaDonBanHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoaDonBanHang.Name = "lblHoaDonBanHang";
            this.lblHoaDonBanHang.Size = new System.Drawing.Size(264, 31);
            this.lblHoaDonBanHang.TabIndex = 15;
            this.lblHoaDonBanHang.Text = "Hoá Đơn Bán Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDonBanHang);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(0, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(800, 285);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Các Mặt Hàng";
            // 
            // dgvHoaDonBanHang
            // 
            this.dgvHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDonBanHang.Location = new System.Drawing.Point(2, 88);
            this.dgvHoaDonBanHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDonBanHang.Name = "dgvHoaDonBanHang";
            this.dgvHoaDonBanHang.RowHeadersWidth = 82;
            this.dgvHoaDonBanHang.RowTemplate.Height = 33;
            this.dgvHoaDonBanHang.Size = new System.Drawing.Size(796, 117);
            this.dgvHoaDonBanHang.TabIndex = 2;
            this.dgvHoaDonBanHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBanHang_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxMaHang);
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.txtGiamGia);
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.txtTenHang);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 73);
            this.panel3.TabIndex = 1;
            // 
            // cbxMaHang
            // 
            this.cbxMaHang.FormattingEnabled = true;
            this.cbxMaHang.Location = new System.Drawing.Point(115, 12);
            this.cbxMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaHang.Name = "cbxMaHang";
            this.cbxMaHang.Size = new System.Drawing.Size(137, 21);
            this.cbxMaHang.TabIndex = 11;
            this.cbxMaHang.SelectedIndexChanged += new System.EventHandler(this.cbxMaHang_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(596, 42);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(137, 20);
            this.txtThanhTien.TabIndex = 10;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(358, 43);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(137, 20);
            this.txtGiamGia.TabIndex = 9;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(596, 10);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(137, 20);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(358, 12);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(137, 20);
            this.txtTenHang.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(115, 46);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 20);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(524, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thành Tiền";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(524, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Đơn Giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Giảm giá %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số Lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnHuyHoaDon);
            this.panel2.Controls.Add(this.btnThemHoaDon);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 205);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 78);
            this.panel2.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(525, 38);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(119, 25);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(339, 38);
            this.btnHuyHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(119, 25);
            this.btnHuyHoaDon.TabIndex = 6;
            this.btnHuyHoaDon.Text = "&Huỷ Hoá Đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnHuyHoaDon_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(153, 38);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(119, 25);
            this.btnThemHoaDon.TabIndex = 4;
            this.btnThemHoaDon.Text = "&Thêm Hoá Đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(690, 4);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(91, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(630, 11);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHoaDonBanHang;
        private System.Windows.Forms.MaskedTextBox maskSoDienThoai;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cbxMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoaDonBanHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxMaHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.ComboBox cbxMaKhachHang;
    }
}