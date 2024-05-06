namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class BangLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_bangluong = new System.Windows.Forms.DataGridView();
            this.Column_maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thuethunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bangluong
            // 
            this.dataGridView_bangluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bangluong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_bangluong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bangluong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bangluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_maluong,
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_thang,
            this.Column_nam,
            this.Column_luong,
            this.Column_thuethunhap});
            this.dataGridView_bangluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_bangluong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_bangluong.Name = "dataGridView_bangluong";
            this.dataGridView_bangluong.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bangluong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_bangluong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_bangluong.Size = new System.Drawing.Size(984, 561);
            this.dataGridView_bangluong.TabIndex = 0;
            // 
            // Column_maluong
            // 
            this.Column_maluong.DataPropertyName = "MaLuong";
            this.Column_maluong.HeaderText = "Mã lương";
            this.Column_maluong.Name = "Column_maluong";
            this.Column_maluong.ReadOnly = true;
            // 
            // Column_manhanvien
            // 
            this.Column_manhanvien.DataPropertyName = "MaNhanVien";
            this.Column_manhanvien.HeaderText = "Mã nhân viên";
            this.Column_manhanvien.Name = "Column_manhanvien";
            this.Column_manhanvien.ReadOnly = true;
            // 
            // Column_hoten
            // 
            this.Column_hoten.DataPropertyName = "HoTen";
            this.Column_hoten.HeaderText = "Họ tên";
            this.Column_hoten.Name = "Column_hoten";
            this.Column_hoten.ReadOnly = true;
            // 
            // Column_thang
            // 
            this.Column_thang.DataPropertyName = "Thang";
            this.Column_thang.HeaderText = "Tháng";
            this.Column_thang.Name = "Column_thang";
            this.Column_thang.ReadOnly = true;
            // 
            // Column_nam
            // 
            this.Column_nam.DataPropertyName = "Nam";
            this.Column_nam.HeaderText = "Năm";
            this.Column_nam.Name = "Column_nam";
            this.Column_nam.ReadOnly = true;
            // 
            // Column_luong
            // 
            this.Column_luong.DataPropertyName = "Luong";
            this.Column_luong.HeaderText = "Lương";
            this.Column_luong.Name = "Column_luong";
            this.Column_luong.ReadOnly = true;
            // 
            // Column_thuethunhap
            // 
            this.Column_thuethunhap.DataPropertyName = "ThueThuNhap";
            this.Column_thuethunhap.HeaderText = "Thuế thu nhập";
            this.Column_thuethunhap.Name = "Column_thuethunhap";
            this.Column_thuethunhap.ReadOnly = true;
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView_bangluong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BangLuong_FormClosed);
            this.Load += new System.EventHandler(this.BangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bangluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thuethunhap;
    }
}