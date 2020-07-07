namespace Quanlybanhang
{
    partial class frmDanhMuc_ChatLieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.lblTenChatLieu = new System.Windows.Forms.Label();
            this.lblMaChatLieu = new System.Windows.Forms.Label();
            this.lblDanhMucChatLieu = new System.Windows.Forms.Label();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnHienThiDS = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenChatLieu);
            this.panel1.Controls.Add(this.txtMaChatLieu);
            this.panel1.Controls.Add(this.lblTenChatLieu);
            this.panel1.Controls.Add(this.lblMaChatLieu);
            this.panel1.Controls.Add(this.lblDanhMucChatLieu);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 129);
            this.panel1.TabIndex = 0;
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(168, 88);
            this.txtTenChatLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(241, 20);
            this.txtTenChatLieu.TabIndex = 1;
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(168, 58);
            this.txtMaChatLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(241, 20);
            this.txtMaChatLieu.TabIndex = 0;
            // 
            // lblTenChatLieu
            // 
            this.lblTenChatLieu.AutoSize = true;
            this.lblTenChatLieu.Location = new System.Drawing.Point(58, 91);
            this.lblTenChatLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenChatLieu.Name = "lblTenChatLieu";
            this.lblTenChatLieu.Size = new System.Drawing.Size(74, 13);
            this.lblTenChatLieu.TabIndex = 2;
            this.lblTenChatLieu.Text = "Tên Chất Liệu";
            // 
            // lblMaChatLieu
            // 
            this.lblMaChatLieu.AutoSize = true;
            this.lblMaChatLieu.Location = new System.Drawing.Point(58, 61);
            this.lblMaChatLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaChatLieu.Name = "lblMaChatLieu";
            this.lblMaChatLieu.Size = new System.Drawing.Size(70, 13);
            this.lblMaChatLieu.TabIndex = 1;
            this.lblMaChatLieu.Text = "Mã Chất Liệu";
            // 
            // lblDanhMucChatLieu
            // 
            this.lblDanhMucChatLieu.AutoSize = true;
            this.lblDanhMucChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucChatLieu.ForeColor = System.Drawing.Color.Black;
            this.lblDanhMucChatLieu.Location = new System.Drawing.Point(70, 9);
            this.lblDanhMucChatLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhMucChatLieu.Name = "lblDanhMucChatLieu";
            this.lblDanhMucChatLieu.Size = new System.Drawing.Size(329, 31);
            this.lblDanhMucChatLieu.TabIndex = 0;
            this.lblDanhMucChatLieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvChatLieu.Location = new System.Drawing.Point(2, 129);
            this.dgvChatLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 82;
            this.dgvChatLieu.RowTemplate.Height = 33;
            this.dgvChatLieu.Size = new System.Drawing.Size(500, 326);
            this.dgvChatLieu.TabIndex = 2;
            this.dgvChatLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChatLieu_CellContentClick);
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
            this.groupBox2.Location = new System.Drawing.Point(506, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(136, 455);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(9, 134);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 36);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(9, 27);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 36);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(9, 80);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 36);
            this.btnXoa.TabIndex = 49;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Image = global::Quanlybanhang.Properties.Resources.Dakirby309_Simply_Styled_Microsoft_Excel_20131;
            this.btnXuatFileExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFileExcel.Location = new System.Drawing.Point(9, 344);
            this.btnXuatFileExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(118, 36);
            this.btnXuatFileExcel.TabIndex = 43;
            this.btnXuatFileExcel.Text = "Xuất File Excel";
            this.btnXuatFileExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFileExcel.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(9, 183);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 36);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.Control;
            this.btnBoQua.Location = new System.Drawing.Point(9, 237);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(118, 36);
            this.btnBoQua.TabIndex = 45;
            this.btnBoQua.Text = "&Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnHienThiDS
            // 
            this.btnHienThiDS.BackColor = System.Drawing.SystemColors.Control;
            this.btnHienThiDS.Location = new System.Drawing.Point(9, 290);
            this.btnHienThiDS.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienThiDS.Name = "btnHienThiDS";
            this.btnHienThiDS.Size = new System.Drawing.Size(118, 36);
            this.btnHienThiDS.TabIndex = 47;
            this.btnHienThiDS.Text = "&Hiển Thị Danh Sách";
            this.btnHienThiDS.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDong.Location = new System.Drawing.Point(9, 396);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(118, 36);
            this.btnDong.TabIndex = 46;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // frmDanhMuc_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDanhMuc_ChatLieu";
            this.Text = "Chất Liệu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.Label lblDanhMucChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Label lblTenChatLieu;
        private System.Windows.Forms.Label lblMaChatLieu;
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