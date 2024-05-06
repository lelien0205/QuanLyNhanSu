namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class BangChamCong
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
            this.dataGridView_bangchamcong = new System.Windows.Forms.DataGridView();
            this.Column_machamcong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_songaylamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangchamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bangchamcong
            // 
            this.dataGridView_bangchamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bangchamcong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_bangchamcong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bangchamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_bangchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bangchamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_machamcong,
            this.Column_manhanvien,
            this.Column_hoten,
            this.Column_thang,
            this.Column_nam,
            this.Column_songaylamviec});
            this.dataGridView_bangchamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_bangchamcong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_bangchamcong.Name = "dataGridView_bangchamcong";
            this.dataGridView_bangchamcong.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_bangchamcong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_bangchamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_bangchamcong.Size = new System.Drawing.Size(984, 561);
            this.dataGridView_bangchamcong.TabIndex = 1;
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
            // BangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView_bangchamcong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BangChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng chấm công";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BangChamCong_FormClosed);
            this.Load += new System.EventHandler(this.BangChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bangchamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bangchamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_machamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_songaylamviec;
    }
}