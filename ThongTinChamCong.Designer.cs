namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class ThongTinChamCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_chamcong = new System.Windows.Forms.DataGridView();
            this.Column_machamcong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_songaylamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_capnhat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chamcong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_chamcong
            // 
            this.dataGridView_chamcong.AllowUserToResizeColumns = false;
            this.dataGridView_chamcong.AllowUserToResizeRows = false;
            this.dataGridView_chamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chamcong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_chamcong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_chamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_machamcong,
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_thang,
            this.Column_nam,
            this.Column_songaylamviec});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_chamcong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_chamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_chamcong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_chamcong.MultiSelect = false;
            this.dataGridView_chamcong.Name = "dataGridView_chamcong";
            this.dataGridView_chamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_chamcong.Size = new System.Drawing.Size(800, 425);
            this.dataGridView_chamcong.TabIndex = 1;
            this.dataGridView_chamcong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_chamcong_DataBindingComplete);
            this.dataGridView_chamcong.SelectionChanged += new System.EventHandler(this.dataGridView_chamcong_SelectionChanged);
            // 
            // Column_machamcong
            // 
            this.Column_machamcong.DataPropertyName = "MaChamCong";
            this.Column_machamcong.HeaderText = "Mã chấm công";
            this.Column_machamcong.Name = "Column_machamcong";
            this.Column_machamcong.ReadOnly = true;
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
            // Column_songaylamviec
            // 
            this.Column_songaylamviec.DataPropertyName = "SoNgayLamViec";
            this.Column_songaylamviec.HeaderText = "Số ngày làm việc";
            this.Column_songaylamviec.Name = "Column_songaylamviec";
            this.Column_songaylamviec.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_capnhat,
            this.toolStripSeparator2,
            this.toolStripButton_xoa,
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_capnhat
            // 
            this.toolStripButton_capnhat.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.edit;
            this.toolStripButton_capnhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_capnhat.Name = "toolStripButton_capnhat";
            this.toolStripButton_capnhat.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_capnhat.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton_capnhat.Text = "Cập nhật";
            this.toolStripButton_capnhat.Click += new System.EventHandler(this.toolStripButton_capnhat_Click);
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
            this.toolStripButton_trolai.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.exit;
            this.toolStripButton_trolai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_trolai.Name = "toolStripButton_trolai";
            this.toolStripButton_trolai.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton_trolai.Text = "Trở lại";
            this.toolStripButton_trolai.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton_trolai.Click += new System.EventHandler(this.toolStripButton_trolai_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ThongTinChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_chamcong);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ThongTinChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chấm công";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinChamCong_FormClosed);
            this.Load += new System.EventHandler(this.ThongTinChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chamcong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_chamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_machamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_songaylamviec;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_capnhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_trolai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}