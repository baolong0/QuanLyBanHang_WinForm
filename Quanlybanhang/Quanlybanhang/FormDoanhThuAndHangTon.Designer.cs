namespace Quanlybanhang
{
    partial class FormDoanhThuAndHangTon
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
            this.dataGridDoanhThu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.dataGridHangTon = new System.Windows.Forms.DataGridView();
            this.labelHangTon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHangTon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDoanhThu
            // 
            this.dataGridDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoanhThu.Location = new System.Drawing.Point(3, 255);
            this.dataGridDoanhThu.Name = "dataGridDoanhThu";
            this.dataGridDoanhThu.Size = new System.Drawing.Size(785, 170);
            this.dataGridDoanhThu.TabIndex = 0;
            this.dataGridDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDoanhThu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng Doanh Thu :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Location = new System.Drawing.Point(354, 428);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(0, 13);
            this.lbTT.TabIndex = 2;
            // 
            // dataGridHangTon
            // 
            this.dataGridHangTon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHangTon.Location = new System.Drawing.Point(3, 34);
            this.dataGridHangTon.Name = "dataGridHangTon";
            this.dataGridHangTon.Size = new System.Drawing.Size(459, 170);
            this.dataGridHangTon.TabIndex = 3;
            // 
            // labelHangTon
            // 
            this.labelHangTon.AutoSize = true;
            this.labelHangTon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHangTon.Location = new System.Drawing.Point(191, 9);
            this.labelHangTon.Name = "labelHangTon";
            this.labelHangTon.Size = new System.Drawing.Size(83, 13);
            this.labelHangTon.TabIndex = 4;
            this.labelHangTon.Text = "Bảng Hàng Tồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bảng Doanh Thu";
            // 
            // FormDoanhThuAndHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHangTon);
            this.Controls.Add(this.dataGridHangTon);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDoanhThu);
            this.Name = "FormDoanhThuAndHangTon";
            this.Text = "Doanh Thu Và Hàng Tồn";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHangTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.DataGridView dataGridHangTon;
        private System.Windows.Forms.Label labelHangTon;
        private System.Windows.Forms.Label label2;
    }
}