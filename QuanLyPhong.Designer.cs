namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class QuanLyPhong
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
            this.dataGridView_phong = new System.Windows.Forms.DataGridView();
            this.Column_maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_diachiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmMớiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_sodienthoai = new System.Windows.Forms.TextBox();
            this.textBox_maphong = new System.Windows.Forms.TextBox();
            this.textBox_diachiphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tenphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_phong
            // 
            this.dataGridView_phong.AllowUserToResizeColumns = false;
            this.dataGridView_phong.AllowUserToResizeRows = false;
            this.dataGridView_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_phong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_phong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_phong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_maphong,
            this.Column_tenphong,
            this.Column_diachiphong,
            this.Column_sodienthoai});
            this.dataGridView_phong.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_phong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_phong.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_phong.Location = new System.Drawing.Point(333, 0);
            this.dataGridView_phong.Name = "dataGridView_phong";
            this.dataGridView_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_phong.Size = new System.Drawing.Size(467, 425);
            this.dataGridView_phong.TabIndex = 0;
            this.dataGridView_phong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_phong_DataBindingComplete);
            this.dataGridView_phong.SelectionChanged += new System.EventHandler(this.dataGridView_phong_SelectionChanged);
            // 
            // Column_maphong
            // 
            this.Column_maphong.DataPropertyName = "MaPhong";
            this.Column_maphong.HeaderText = "Mã phòng";
            this.Column_maphong.Name = "Column_maphong";
            this.Column_maphong.ReadOnly = true;
            // 
            // Column_tenphong
            // 
            this.Column_tenphong.DataPropertyName = "TenPhong";
            this.Column_tenphong.HeaderText = "Tên phòng";
            this.Column_tenphong.Name = "Column_tenphong";
            this.Column_tenphong.ReadOnly = true;
            // 
            // Column_diachiphong
            // 
            this.Column_diachiphong.DataPropertyName = "DiaChiPhong";
            this.Column_diachiphong.HeaderText = "Địa chỉ phòng";
            this.Column_diachiphong.Name = "Column_diachiphong";
            this.Column_diachiphong.ReadOnly = true;
            // 
            // Column_sodienthoai
            // 
            this.Column_sodienthoai.DataPropertyName = "SoDienThoai";
            this.Column_sodienthoai.HeaderText = "Số điện thoại";
            this.Column_sodienthoai.Name = "Column_sodienthoai";
            this.Column_sodienthoai.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiDanhSáchToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 114);
            // 
            // làmMớiDanhSáchToolStripMenuItem
            // 
            this.làmMớiDanhSáchToolStripMenuItem.Name = "làmMớiDanhSáchToolStripMenuItem";
            this.làmMớiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.làmMớiDanhSáchToolStripMenuItem.Text = "Làm mới";
            this.làmMớiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.làmMớiDanhSáchToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa";
            this.xóaNhânViênToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý phòng ban";
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 425);
            this.panel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.textBox_sodienthoai);
            this.groupBox1.Controls.Add(this.textBox_maphong);
            this.groupBox1.Controls.Add(this.textBox_diachiphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_tenphong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(4, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 298);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phòng";
            // 
            // textBox_sodienthoai
            // 
            this.textBox_sodienthoai.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_sodienthoai.Location = new System.Drawing.Point(30, 246);
            this.textBox_sodienthoai.Name = "textBox_sodienthoai";
            this.textBox_sodienthoai.Size = new System.Drawing.Size(259, 20);
            this.textBox_sodienthoai.TabIndex = 13;
            this.textBox_sodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sodienthoai_KeyPress);
            // 
            // textBox_maphong
            // 
            this.textBox_maphong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_maphong.Location = new System.Drawing.Point(30, 51);
            this.textBox_maphong.Name = "textBox_maphong";
            this.textBox_maphong.ReadOnly = true;
            this.textBox_maphong.Size = new System.Drawing.Size(259, 20);
            this.textBox_maphong.TabIndex = 10;
            // 
            // textBox_diachiphong
            // 
            this.textBox_diachiphong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_diachiphong.Location = new System.Drawing.Point(30, 181);
            this.textBox_diachiphong.Name = "textBox_diachiphong";
            this.textBox_diachiphong.Size = new System.Drawing.Size(259, 20);
            this.textBox_diachiphong.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã phòng:";
            // 
            // textBox_tenphong
            // 
            this.textBox_tenphong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_tenphong.Location = new System.Drawing.Point(30, 116);
            this.textBox_tenphong.Name = "textBox_tenphong";
            this.textBox_tenphong.Size = new System.Drawing.Size(259, 20);
            this.textBox_tenphong.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_them,
            this.toolStripSeparator1,
            this.toolStripButton_sua,
            this.toolStripSeparator2,
            this.toolStripButton_xoa,
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 15;
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
            // toolStripButton_sua
            // 
            this.toolStripButton_sua.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.edit;
            this.toolStripButton_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sua.Name = "toolStripButton_sua";
            this.toolStripButton_sua.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_sua.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton_sua.Text = "Cập nhật";
            this.toolStripButton_sua.Click += new System.EventHandler(this.toolStripButton_sua_Click);
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
            this.toolStripButton_trolai.Click += new System.EventHandler(this.toolStripButton_trolai_Click);
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_phong);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ban";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyPhong_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phong)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_diachiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sodienthoai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_sodienthoai;
        private System.Windows.Forms.TextBox textBox_maphong;
        private System.Windows.Forms.TextBox textBox_diachiphong;
        private System.Windows.Forms.TextBox textBox_tenphong;
        private System.Windows.Forms.ToolStripMenuItem làmMớiDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_them;
        private System.Windows.Forms.ToolStripButton toolStripButton_sua;
        private System.Windows.Forms.ToolStripButton toolStripButton_xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_trolai;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}