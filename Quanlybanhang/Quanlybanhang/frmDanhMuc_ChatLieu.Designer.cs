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
            this.panelChatLieu = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.lblDanhMucChatLieu = new System.Windows.Forms.Label();
            this.lblMaChatLieu = new System.Windows.Forms.Label();
            this.lblTenChatLieu = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.panelChatLieu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChatLieu
            // 
            this.panelChatLieu.Controls.Add(this.btnDong);
            this.panelChatLieu.Controls.Add(this.btnBoQua);
            this.panelChatLieu.Controls.Add(this.btnLuu);
            this.panelChatLieu.Controls.Add(this.btnSua);
            this.panelChatLieu.Controls.Add(this.btnXoa);
            this.panelChatLieu.Controls.Add(this.btnThem);
            this.panelChatLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChatLieu.Location = new System.Drawing.Point(0, 898);
            this.panelChatLieu.Name = "panelChatLieu";
            this.panelChatLieu.Size = new System.Drawing.Size(1588, 134);
            this.panelChatLieu.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(79, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(192, 72);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(323, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(192, 72);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(567, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(192, 72);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDong.Location = new System.Drawing.Point(1299, 34);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(192, 72);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.Control;
            this.btnBoQua.Location = new System.Drawing.Point(1055, 34);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(192, 72);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "&Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(811, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(192, 72);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenChatLieu);
            this.panel1.Controls.Add(this.txtMaChatLieu);
            this.panel1.Controls.Add(this.lblTenChatLieu);
            this.panel1.Controls.Add(this.lblMaChatLieu);
            this.panel1.Controls.Add(this.lblDanhMucChatLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1588, 248);
            this.panel1.TabIndex = 0;
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChatLieu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvChatLieu.Location = new System.Drawing.Point(0, 248);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.RowHeadersWidth = 82;
            this.dgvChatLieu.RowTemplate.Height = 33;
            this.dgvChatLieu.Size = new System.Drawing.Size(1588, 650);
            this.dgvChatLieu.TabIndex = 2;
            // 
            // lblDanhMucChatLieu
            // 
            this.lblDanhMucChatLieu.AutoSize = true;
            this.lblDanhMucChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucChatLieu.ForeColor = System.Drawing.Color.Black;
            this.lblDanhMucChatLieu.Location = new System.Drawing.Point(470, 26);
            this.lblDanhMucChatLieu.Name = "lblDanhMucChatLieu";
            this.lblDanhMucChatLieu.Size = new System.Drawing.Size(630, 63);
            this.lblDanhMucChatLieu.TabIndex = 0;
            this.lblDanhMucChatLieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // lblMaChatLieu
            // 
            this.lblMaChatLieu.AutoSize = true;
            this.lblMaChatLieu.Location = new System.Drawing.Point(115, 117);
            this.lblMaChatLieu.Name = "lblMaChatLieu";
            this.lblMaChatLieu.Size = new System.Drawing.Size(140, 25);
            this.lblMaChatLieu.TabIndex = 1;
            this.lblMaChatLieu.Text = "Mã Chất Liệu";
            // 
            // lblTenChatLieu
            // 
            this.lblTenChatLieu.AutoSize = true;
            this.lblTenChatLieu.Location = new System.Drawing.Point(115, 175);
            this.lblTenChatLieu.Name = "lblTenChatLieu";
            this.lblTenChatLieu.Size = new System.Drawing.Size(147, 25);
            this.lblTenChatLieu.TabIndex = 2;
            this.lblTenChatLieu.Text = "Tên Chất Liệu";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(337, 111);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.ReadOnly = true;
            this.txtMaChatLieu.Size = new System.Drawing.Size(478, 31);
            this.txtMaChatLieu.TabIndex = 0;
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(337, 169);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(478, 31);
            this.txtTenChatLieu.TabIndex = 1;
            // 
            // frmDanhMuc_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1032);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChatLieu);
            this.Name = "frmDanhMuc_ChatLieu";
            this.Text = "Chất Liệu";
            this.panelChatLieu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChatLieu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private System.Windows.Forms.Label lblDanhMucChatLieu;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Label lblTenChatLieu;
        private System.Windows.Forms.Label lblMaChatLieu;
    }
}