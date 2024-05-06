namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class QuanLyChamCong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChamCong));
            this.dataGridView_chamcong = new System.Windows.Forms.DataGridView();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_songaylamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            this.comboBox_thang = new System.Windows.Forms.ComboBox();
            this.comboBox_maphong = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_chitiet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chamcong)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_chamcong
            // 
            this.dataGridView_chamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chamcong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_chamcong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_chamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_gioitinh,
            this.Column_ngaysinh,
            this.Column_tenphong,
            this.Column_songaylamviec});
            this.dataGridView_chamcong.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_chamcong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_chamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_chamcong.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_chamcong.Location = new System.Drawing.Point(0, 63);
            this.dataGridView_chamcong.MultiSelect = false;
            this.dataGridView_chamcong.Name = "dataGridView_chamcong";
            this.dataGridView_chamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_chamcong.Size = new System.Drawing.Size(800, 362);
            this.dataGridView_chamcong.TabIndex = 2;
            this.dataGridView_chamcong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_chamcong_DataBindingComplete);
            this.dataGridView_chamcong.SelectionChanged += new System.EventHandler(this.dataGridView_chamcong_SelectionChanged);
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
            this.Column_hoten.HeaderText = "Tên nhân viên";
            this.Column_hoten.Name = "Column_hoten";
            this.Column_hoten.ReadOnly = true;
            // 
            // Column_gioitinh
            // 
            this.Column_gioitinh.DataPropertyName = "GioiTinh";
            this.Column_gioitinh.HeaderText = "Giới tính";
            this.Column_gioitinh.Name = "Column_gioitinh";
            this.Column_gioitinh.ReadOnly = true;
            // 
            // Column_ngaysinh
            // 
            this.Column_ngaysinh.DataPropertyName = "NgaySinh";
            this.Column_ngaysinh.HeaderText = "Ngày sinh";
            this.Column_ngaysinh.Name = "Column_ngaysinh";
            this.Column_ngaysinh.ReadOnly = true;
            // 
            // Column_tenphong
            // 
            this.Column_tenphong.DataPropertyName = "TenPhong";
            this.Column_tenphong.HeaderText = "Tên phòng";
            this.Column_tenphong.Name = "Column_tenphong";
            this.Column_tenphong.ReadOnly = true;
            // 
            // Column_songaylamviec
            // 
            this.Column_songaylamviec.HeaderText = "Số ngày làm việc";
            this.Column_songaylamviec.Name = "Column_songaylamviec";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiToolStripMenuItem,
            this.xemChiTiếtToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 114);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_nam);
            this.panel1.Controls.Add(this.comboBox_thang);
            this.panel1.Controls.Add(this.comboBox_maphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(527, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(326, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_nam
            // 
            this.comboBox_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nam.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_nam.FormattingEnabled = true;
            this.comboBox_nam.Location = new System.Drawing.Point(527, 29);
            this.comboBox_nam.Name = "comboBox_nam";
            this.comboBox_nam.Size = new System.Drawing.Size(149, 23);
            this.comboBox_nam.TabIndex = 2;
            this.comboBox_nam.SelectedIndexChanged += new System.EventHandler(this.comboBox_nam_SelectedIndexChanged);
            // 
            // comboBox_thang
            // 
            this.comboBox_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_thang.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_thang.FormattingEnabled = true;
            this.comboBox_thang.Location = new System.Drawing.Point(326, 29);
            this.comboBox_thang.Name = "comboBox_thang";
            this.comboBox_thang.Size = new System.Drawing.Size(149, 23);
            this.comboBox_thang.TabIndex = 1;
            this.comboBox_thang.SelectedIndexChanged += new System.EventHandler(this.comboBox_thang_SelectedIndexChanged);
            // 
            // comboBox_maphong
            // 
            this.comboBox_maphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_maphong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_maphong.FormattingEnabled = true;
            this.comboBox_maphong.Location = new System.Drawing.Point(125, 29);
            this.comboBox_maphong.Name = "comboBox_maphong";
            this.comboBox_maphong.Size = new System.Drawing.Size(149, 23);
            this.comboBox_maphong.TabIndex = 0;
            this.comboBox_maphong.SelectedIndexChanged += new System.EventHandler(this.comboBox_maphong_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_them,
            this.toolStripSeparator1,
            this.toolStripButton_chitiet,
            this.toolStripSeparator2,
            this.toolStripButton_xoa,
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_them
            // 
            this.toolStripButton_them.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.add;
            this.toolStripButton_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_them.Name = "toolStripButton_them";
            this.toolStripButton_them.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_them.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton_them.Text = "Thêm";
            this.toolStripButton_them.Click += new System.EventHandler(this.toolStripButton_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_chitiet
            // 
            this.toolStripButton_chitiet.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.detail;
            this.toolStripButton_chitiet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_chitiet.Name = "toolStripButton_chitiet";
            this.toolStripButton_chitiet.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_chitiet.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton_chitiet.Text = "Chi tiết";
            this.toolStripButton_chitiet.Click += new System.EventHandler(this.toolStripButton_chitiet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_xoa
            // 
            this.toolStripButton_xoa.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.trash;
            this.toolStripButton_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_xoa.Name = "toolStripButton_xoa";
            this.toolStripButton_xoa.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_xoa.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton_xoa.Text = "Xóa";
            this.toolStripButton_xoa.Click += new System.EventHandler(this.toolStripButton_xoa_Click);
            // 
            // toolStripButton_trolai
            // 
            this.toolStripButton_trolai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_trolai.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_trolai.Image")));
            this.toolStripButton_trolai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_trolai.Name = "toolStripButton_trolai";
            this.toolStripButton_trolai.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_trolai.Text = "Trở lại";
            this.toolStripButton_trolai.Click += new System.EventHandler(this.toolStripButton_trolai_Click);
            // 
            // QuanLyChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView_chamcong);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chấm công";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyChamCong_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chamcong)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_chamcong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_nam;
        private System.Windows.Forms.ComboBox comboBox_thang;
        private System.Windows.Forms.ComboBox comboBox_maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_songaylamviec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_them;
        private System.Windows.Forms.ToolStripButton toolStripButton_chitiet;
        private System.Windows.Forms.ToolStripButton toolStripButton_xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_trolai;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
    }
}