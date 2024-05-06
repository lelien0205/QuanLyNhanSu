namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class QuanLyChucVu
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
            this.dataGridView_chucvu = new System.Windows.Forms.DataGridView();
            this.Column_machucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tenchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hesophucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmMớiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_machucvu = new System.Windows.Forms.TextBox();
            this.textBox_hesophucap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tenchucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_trolai = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chucvu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_chucvu
            // 
            this.dataGridView_chucvu.AllowUserToResizeColumns = false;
            this.dataGridView_chucvu.AllowUserToResizeRows = false;
            this.dataGridView_chucvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_chucvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_chucvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_chucvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_chucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_machucvu,
            this.Column_tenchucvu,
            this.Column_hesophucap});
            this.dataGridView_chucvu.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_chucvu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_chucvu.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_chucvu.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView_chucvu.Location = new System.Drawing.Point(444, 0);
            this.dataGridView_chucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_chucvu.Name = "dataGridView_chucvu";
            this.dataGridView_chucvu.RowHeadersWidth = 51;
            this.dataGridView_chucvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_chucvu.Size = new System.Drawing.Size(623, 527);
            this.dataGridView_chucvu.TabIndex = 1;
            this.dataGridView_chucvu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_chucvu_DataBindingComplete);
            this.dataGridView_chucvu.SelectionChanged += new System.EventHandler(this.dataGridView_chucvu_SelectionChanged);
            // 
            // Column_machucvu
            // 
            this.Column_machucvu.DataPropertyName = "MaChucVu";
            this.Column_machucvu.HeaderText = "Mã chức vụ";
            this.Column_machucvu.MinimumWidth = 6;
            this.Column_machucvu.Name = "Column_machucvu";
            this.Column_machucvu.ReadOnly = true;
            // 
            // Column_tenchucvu
            // 
            this.Column_tenchucvu.DataPropertyName = "TenChucVu";
            this.Column_tenchucvu.HeaderText = "Tên chức vụ";
            this.Column_tenchucvu.MinimumWidth = 6;
            this.Column_tenchucvu.Name = "Column_tenchucvu";
            this.Column_tenchucvu.ReadOnly = true;
            // 
            // Column_hesophucap
            // 
            this.Column_hesophucap.DataPropertyName = "HeSoPhuCap";
            this.Column_hesophucap.HeaderText = "Hệ số phụ cấp";
            this.Column_hesophucap.MinimumWidth = 6;
            this.Column_hesophucap.Name = "Column_hesophucap";
            this.Column_hesophucap.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiDanhSáchToolStripMenuItem,
            this.thêmToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 124);
            // 
            // làmMớiDanhSáchToolStripMenuItem
            // 
            this.làmMớiDanhSáchToolStripMenuItem.Name = "làmMớiDanhSáchToolStripMenuItem";
            this.làmMớiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.làmMớiDanhSáchToolStripMenuItem.Text = "Làm mới";
            this.làmMớiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.làmMớiDanhSáchToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa";
            this.xóaNhânViênToolStripMenuItem.Click += new System.EventHandler(this.xóaNhânViênToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 527);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.textBox_machucvu);
            this.groupBox1.Controls.Add(this.textBox_hesophucap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_tenchucvu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(424, 294);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm chức vụ";
            // 
            // textBox_machucvu
            // 
            this.textBox_machucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_machucvu.Location = new System.Drawing.Point(40, 65);
            this.textBox_machucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_machucvu.Name = "textBox_machucvu";
            this.textBox_machucvu.ReadOnly = true;
            this.textBox_machucvu.Size = new System.Drawing.Size(344, 23);
            this.textBox_machucvu.TabIndex = 10;
            this.textBox_machucvu.TextChanged += new System.EventHandler(this.textBox_machucvu_TextChanged);
            // 
            // textBox_hesophucap
            // 
            this.textBox_hesophucap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_hesophucap.Location = new System.Drawing.Point(40, 225);
            this.textBox_hesophucap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_hesophucap.Name = "textBox_hesophucap";
            this.textBox_hesophucap.Size = new System.Drawing.Size(344, 23);
            this.textBox_hesophucap.TabIndex = 12;
            this.textBox_hesophucap.TextChanged += new System.EventHandler(this.textBox_hesophucap_TextChanged);
            this.textBox_hesophucap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hesophucap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã chức vụ:";
            // 
            // textBox_tenchucvu
            // 
            this.textBox_tenchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_tenchucvu.Location = new System.Drawing.Point(40, 145);
            this.textBox_tenchucvu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_tenchucvu.Name = "textBox_tenchucvu";
            this.textBox_tenchucvu.Size = new System.Drawing.Size(344, 23);
            this.textBox_tenchucvu.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hệ số phụ cấp:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý chức vụ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_them,
            this.toolStripSeparator1,
            this.toolStripButton_sua,
            this.toolStripSeparator2,
            this.toolStripButton_xoa,
            this.toolStripButton_trolai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 527);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_them
            // 
            this.toolStripButton_them.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.add;
            this.toolStripButton_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_them.Name = "toolStripButton_them";
            this.toolStripButton_them.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_them.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton_them.Text = "Thêm";
            this.toolStripButton_them.Click += new System.EventHandler(this.toolStripButton_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_sua
            // 
            this.toolStripButton_sua.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.edit;
            this.toolStripButton_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sua.Name = "toolStripButton_sua";
            this.toolStripButton_sua.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_sua.Size = new System.Drawing.Size(129, 24);
            this.toolStripButton_sua.Text = "Cập nhật";
            this.toolStripButton_sua.Click += new System.EventHandler(this.toolStripButton_sua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_xoa
            // 
            this.toolStripButton_xoa.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.trash;
            this.toolStripButton_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_xoa.Name = "toolStripButton_xoa";
            this.toolStripButton_xoa.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.toolStripButton_xoa.Size = new System.Drawing.Size(92, 24);
            this.toolStripButton_xoa.Text = "Xóa";
            this.toolStripButton_xoa.Click += new System.EventHandler(this.toolStripButton_xoa_Click);
            // 
            // toolStripButton_trolai
            // 
            this.toolStripButton_trolai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_trolai.Image = global::NTGiangDQHuanLTPLien_LTNET.Properties.Resources.exit;
            this.toolStripButton_trolai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_trolai.Name = "toolStripButton_trolai";
            this.toolStripButton_trolai.Size = new System.Drawing.Size(80, 24);
            this.toolStripButton_trolai.Text = "Trở lại";
            this.toolStripButton_trolai.Click += new System.EventHandler(this.toolStripButton_trolai_Click);
            // 
            // QuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_chucvu);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "QuanLyChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chức vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyChucVu_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_chucvu)).EndInit();
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

        private System.Windows.Forms.DataGridView dataGridView_chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_machucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tenchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hesophucap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_machucvu;
        private System.Windows.Forms.TextBox textBox_hesophucap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tenchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmMớiDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
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