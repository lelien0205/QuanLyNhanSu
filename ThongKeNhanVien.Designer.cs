namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class ThongKeNhanVien
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
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_machucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_loainguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hesoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_maphong = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.AllowUserToResizeColumns = false;
            this.dataGridView_nhanvien.AllowUserToResizeRows = false;
            this.dataGridView_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_nhanvien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_gioitinh,
            this.Column_ngaysinh,
            this.Column_diachi,
            this.Column_sodienthoai,
            this.Column_quequan,
            this.Column_maphong,
            this.Column_machucvu,
            this.Column_matkhau,
            this.Column_loainguoidung,
            this.Column_hesoluong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_nhanvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(0, 63);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(1198, 540);
            this.dataGridView_nhanvien.TabIndex = 22;
            // 
            // Column_manhanvien
            // 
            this.Column_manhanvien.DataPropertyName = "MaNhanVien";
            this.Column_manhanvien.FillWeight = 50F;
            this.Column_manhanvien.HeaderText = "Mã nhân viên";
            this.Column_manhanvien.Name = "Column_manhanvien";
            this.Column_manhanvien.ReadOnly = true;
            // 
            // Column_hoten
            // 
            this.Column_hoten.DataPropertyName = "HoTen";
            this.Column_hoten.FillWeight = 70F;
            this.Column_hoten.HeaderText = "Họ tên";
            this.Column_hoten.Name = "Column_hoten";
            this.Column_hoten.ReadOnly = true;
            // 
            // Column_gioitinh
            // 
            this.Column_gioitinh.DataPropertyName = "GioiTinh";
            this.Column_gioitinh.FillWeight = 40F;
            this.Column_gioitinh.HeaderText = "Giới tính";
            this.Column_gioitinh.Name = "Column_gioitinh";
            this.Column_gioitinh.ReadOnly = true;
            // 
            // Column_ngaysinh
            // 
            this.Column_ngaysinh.DataPropertyName = "NgaySinh";
            this.Column_ngaysinh.FillWeight = 40F;
            this.Column_ngaysinh.HeaderText = "Ngày sinh";
            this.Column_ngaysinh.Name = "Column_ngaysinh";
            this.Column_ngaysinh.ReadOnly = true;
            // 
            // Column_diachi
            // 
            this.Column_diachi.DataPropertyName = "DiaChi";
            this.Column_diachi.HeaderText = "Địa chỉ";
            this.Column_diachi.Name = "Column_diachi";
            this.Column_diachi.ReadOnly = true;
            // 
            // Column_sodienthoai
            // 
            this.Column_sodienthoai.DataPropertyName = "SoDienThoai";
            this.Column_sodienthoai.FillWeight = 50F;
            this.Column_sodienthoai.HeaderText = "Số điện thoại";
            this.Column_sodienthoai.Name = "Column_sodienthoai";
            this.Column_sodienthoai.ReadOnly = true;
            // 
            // Column_quequan
            // 
            this.Column_quequan.DataPropertyName = "QueQuan";
            this.Column_quequan.FillWeight = 50F;
            this.Column_quequan.HeaderText = "Quê quán";
            this.Column_quequan.Name = "Column_quequan";
            this.Column_quequan.ReadOnly = true;
            // 
            // Column_maphong
            // 
            this.Column_maphong.DataPropertyName = "MaPhong";
            this.Column_maphong.FillWeight = 40F;
            this.Column_maphong.HeaderText = "Mã phòng";
            this.Column_maphong.Name = "Column_maphong";
            this.Column_maphong.ReadOnly = true;
            // 
            // Column_machucvu
            // 
            this.Column_machucvu.DataPropertyName = "MaChucVu";
            this.Column_machucvu.FillWeight = 40F;
            this.Column_machucvu.HeaderText = "Mã chức vụ";
            this.Column_machucvu.Name = "Column_machucvu";
            this.Column_machucvu.ReadOnly = true;
            // 
            // Column_matkhau
            // 
            this.Column_matkhau.DataPropertyName = "MatKhau";
            this.Column_matkhau.FillWeight = 40F;
            this.Column_matkhau.HeaderText = "Mật khẩu";
            this.Column_matkhau.Name = "Column_matkhau";
            this.Column_matkhau.ReadOnly = true;
            // 
            // Column_loainguoidung
            // 
            this.Column_loainguoidung.DataPropertyName = "LoaiNguoiDung";
            this.Column_loainguoidung.FillWeight = 50F;
            this.Column_loainguoidung.HeaderText = "Loại người dùng";
            this.Column_loainguoidung.Name = "Column_loainguoidung";
            this.Column_loainguoidung.ReadOnly = true;
            // 
            // Column_hesoluong
            // 
            this.Column_hesoluong.DataPropertyName = "HeSoLuong";
            this.Column_hesoluong.FillWeight = 50F;
            this.Column_hesoluong.HeaderText = "Hệ số lương";
            this.Column_hesoluong.Name = "Column_hesoluong";
            this.Column_hesoluong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_in);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_maphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 63);
            this.panel1.TabIndex = 23;
            // 
            // button_in
            // 
            this.button_in.Location = new System.Drawing.Point(677, 29);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(75, 23);
            this.button_in.TabIndex = 6;
            this.button_in.Text = "In";
            this.button_in.UseVisualStyleBackColor = true;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(432, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_maphong
            // 
            this.comboBox_maphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maphong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_maphong.FormattingEnabled = true;
            this.comboBox_maphong.Location = new System.Drawing.Point(432, 29);
            this.comboBox_maphong.Name = "comboBox_maphong";
            this.comboBox_maphong.Size = new System.Drawing.Size(239, 23);
            this.comboBox_maphong.TabIndex = 0;
            this.comboBox_maphong.SelectedIndexChanged += new System.EventHandler(this.comboBox_maphong_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 603);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_trolai
            // 
            this.toolStripButton_trolai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_trolai.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.exit;
            this.toolStripButton_trolai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_trolai.Name = "toolStripButton_trolai";
            this.toolStripButton_trolai.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_trolai.Text = "Trở lại";
            this.toolStripButton_trolai.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton_trolai.Click += new System.EventHandler(this.toolStripButton_trolai_Click);
            // 
            // ThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 628);
            this.Controls.Add(this.dataGridView_nhanvien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongKeNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaoCaoThongKe_FormClosed);
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_machucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_loainguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hesoluong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_maphong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_trolai;
    }
}