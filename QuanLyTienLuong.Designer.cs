namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class QuanLyTienLuong
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
            this.dataGridView_luong = new System.Windows.Forms.DataGridView();
            this.Column_maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thuethunhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_datlai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            this.comboBox_thang = new System.Windows.Forms.ComboBox();
            this.comboBox_maphong = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_tongluong = new System.Windows.Forms.TextBox();
            this.label_tongluong = new System.Windows.Forms.Label();
            this.button_in = new System.Windows.Forms.Button();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_luong)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_luong
            // 
            this.dataGridView_luong.AllowUserToResizeColumns = false;
            this.dataGridView_luong.AllowUserToResizeRows = false;
            this.dataGridView_luong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_luong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_luong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_luong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_luong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_maluong,
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_thang,
            this.Column_nam,
            this.Column_luong,
            this.Column_thuethunhap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_luong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_luong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_luong.Location = new System.Drawing.Point(0, 63);
            this.dataGridView_luong.Name = "dataGridView_luong";
            this.dataGridView_luong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_luong.Size = new System.Drawing.Size(879, 378);
            this.dataGridView_luong.TabIndex = 2;
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
            this.Column_hoten.FillWeight = 150F;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 461);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_in);
            this.panel1.Controls.Add(this.button_datlai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_nam);
            this.panel1.Controls.Add(this.comboBox_thang);
            this.panel1.Controls.Add(this.comboBox_maphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 63);
            this.panel1.TabIndex = 20;
            // 
            // button_datlai
            // 
            this.button_datlai.Location = new System.Drawing.Point(670, 29);
            this.button_datlai.Name = "button_datlai";
            this.button_datlai.Size = new System.Drawing.Size(75, 23);
            this.button_datlai.TabIndex = 6;
            this.button_datlai.Text = "Đặt lại";
            this.button_datlai.UseVisualStyleBackColor = true;
            this.button_datlai.Click += new System.EventHandler(this.button_datlai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(465, 11);
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
            this.label2.Location = new System.Drawing.Point(260, 11);
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
            this.label1.Location = new System.Drawing.Point(55, 11);
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
            this.comboBox_nam.Location = new System.Drawing.Point(465, 29);
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
            this.comboBox_thang.Location = new System.Drawing.Point(260, 29);
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
            this.comboBox_maphong.Location = new System.Drawing.Point(55, 29);
            this.comboBox_maphong.Name = "comboBox_maphong";
            this.comboBox_maphong.Size = new System.Drawing.Size(149, 23);
            this.comboBox_maphong.TabIndex = 0;
            this.comboBox_maphong.SelectedIndexChanged += new System.EventHandler(this.comboBox_maphong_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_tongluong);
            this.panel2.Controls.Add(this.label_tongluong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 20);
            this.panel2.TabIndex = 21;
            // 
            // textBox_tongluong
            // 
            this.textBox_tongluong.Location = new System.Drawing.Point(691, 0);
            this.textBox_tongluong.Name = "textBox_tongluong";
            this.textBox_tongluong.ReadOnly = true;
            this.textBox_tongluong.Size = new System.Drawing.Size(176, 20);
            this.textBox_tongluong.TabIndex = 1;
            this.textBox_tongluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_tongluong
            // 
            this.label_tongluong.AutoSize = true;
            this.label_tongluong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label_tongluong.Location = new System.Drawing.Point(528, 3);
            this.label_tongluong.Name = "label_tongluong";
            this.label_tongluong.Size = new System.Drawing.Size(157, 15);
            this.label_tongluong.TabIndex = 0;
            this.label_tongluong.Text = "Tổng lương tháng 00/0000:";
            this.label_tongluong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_in
            // 
            this.button_in.Location = new System.Drawing.Point(751, 29);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(75, 23);
            this.button_in.TabIndex = 7;
            this.button_in.Text = "In";
            this.button_in.UseVisualStyleBackColor = true;
            this.button_in.Visible = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
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
            // QuanLyTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 486);
            this.Controls.Add(this.dataGridView_luong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuanLyTienLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiền lương";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyTienLuong_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyTienLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_luong)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thuethunhap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_trolai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_nam;
        private System.Windows.Forms.ComboBox comboBox_thang;
        private System.Windows.Forms.ComboBox comboBox_maphong;
        private System.Windows.Forms.Button button_datlai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_tongluong;
        private System.Windows.Forms.Label label_tongluong;
        private System.Windows.Forms.Button button_in;
    }
}