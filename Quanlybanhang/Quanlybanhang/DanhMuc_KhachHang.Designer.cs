namespace Quanlybanhang
{
    partial class frmDanhMuc_KhachHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblDanhMucKhachHang = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnHienThiDS = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskDienThoai);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtTenNhanVien);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.lblDienThoai);
            this.panel2.Controls.Add(this.lblDiaChi);
            this.panel2.Controls.Add(this.lblTenNhanVien);
            this.panel2.Controls.Add(this.lblMaNhanVien);
            this.panel2.Controls.Add(this.lblDanhMucKhachHang);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 314);
            this.panel2.TabIndex = 1;
            // 
            // maskDienThoai
            // 
            this.maskDienThoai.Location = new System.Drawing.Point(740, 228);
            this.maskDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskDienThoai.Mask = "(999) 000-0000";
            this.maskDienThoai.Name = "maskDienThoai";
            this.maskDienThoai.Size = new System.Drawing.Size(244, 31);
            this.maskDienThoai.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(740, 164);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 31);
            this.txtDiaChi.TabIndex = 20;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(246, 233);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(244, 31);
            this.txtTenNhanVien.TabIndex = 19;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(246, 172);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(244, 31);
            this.txtMaNhanVien.TabIndex = 18;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(562, 239);
            this.lblDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(116, 25);
            this.lblDienThoai.TabIndex = 17;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(568, 172);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(82, 25);
            this.lblDiaChi.TabIndex = 16;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(56, 239);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(155, 25);
            this.lblTenNhanVien.TabIndex = 15;
            this.lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(56, 172);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(148, 25);
            this.lblMaNhanVien.TabIndex = 14;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lblDanhMucKhachHang
            // 
            this.lblDanhMucKhachHang.AutoSize = true;
            this.lblDanhMucKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblDanhMucKhachHang.Location = new System.Drawing.Point(176, 57);
            this.lblDanhMucKhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhMucKhachHang.Name = "lblDanhMucKhachHang";
            this.lblDanhMucKhachHang.Size = new System.Drawing.Size(601, 63);
            this.lblDanhMucKhachHang.TabIndex = 13;
            this.lblDanhMucKhachHang.Text = "Danh Mục Khách Hàng";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(13, 322);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 82;
            this.dgvKhachHang.RowTemplate.Height = 33;
            this.dgvKhachHang.Size = new System.Drawing.Size(1031, 559);
            this.dgvKhachHang.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnXuatFileExcel);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnHienThiDS);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Location = new System.Drawing.Point(1065, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 875);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(18, 257);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(237, 69);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(18, 51);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(237, 69);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(18, 154);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(237, 69);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Image = global::Quanlybanhang.Properties.Resources.Dakirby309_Simply_Styled_Microsoft_Excel_20131;
            this.btnXuatFileExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFileExcel.Location = new System.Drawing.Point(18, 661);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(237, 69);
            this.btnXuatFileExcel.TabIndex = 43;
            this.btnXuatFileExcel.Text = "Xuất File Excel";
            this.btnXuatFileExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFileExcel.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(18, 352);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(237, 69);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.Control;
            this.btnBoQua.Location = new System.Drawing.Point(18, 455);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(237, 69);
            this.btnBoQua.TabIndex = 45;
            this.btnBoQua.Text = "&Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnHienThiDS
            // 
            this.btnHienThiDS.BackColor = System.Drawing.SystemColors.Control;
            this.btnHienThiDS.Location = new System.Drawing.Point(18, 558);
            this.btnHienThiDS.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienThiDS.Name = "btnHienThiDS";
            this.btnHienThiDS.Size = new System.Drawing.Size(237, 69);
            this.btnHienThiDS.TabIndex = 47;
            this.btnHienThiDS.Text = "&Hiển Thị Danh Sách";
            this.btnHienThiDS.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDong.Location = new System.Drawing.Point(18, 762);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(237, 69);
            this.btnDong.TabIndex = 46;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmDanhMuc_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 905);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDanhMuc_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.MaskedTextBox maskDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblDanhMucKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuatFileExcel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnHienThiDS;
        private System.Windows.Forms.Button btnDong;
    }
}