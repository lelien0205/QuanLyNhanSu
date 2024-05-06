namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class BaoCaoThongKe
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
            this.button_nhanvien = new System.Windows.Forms.Button();
            this.button_luong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_nhanvien
            // 
            this.button_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_nhanvien.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.button_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.button_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_nhanvien.Name = "button_nhanvien";
            this.button_nhanvien.Size = new System.Drawing.Size(212, 55);
            this.button_nhanvien.TabIndex = 0;
            this.button_nhanvien.Text = "Thống kê nhân viên";
            this.button_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nhanvien.UseVisualStyleBackColor = true;
            this.button_nhanvien.Click += new System.EventHandler(this.button_nhanvien_Click);
            // 
            // button_luong
            // 
            this.button_luong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_luong.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.button_luong.Location = new System.Drawing.Point(0, 55);
            this.button_luong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_luong.Name = "button_luong";
            this.button_luong.Size = new System.Drawing.Size(212, 55);
            this.button_luong.TabIndex = 1;
            this.button_luong.Text = "Thống kê lương";
            this.button_luong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luong.UseVisualStyleBackColor = true;
            this.button_luong.Click += new System.EventHandler(this.button_luong_Click);
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 110);
            this.Controls.Add(this.button_nhanvien);
            this.Controls.Add(this.button_luong);
            this.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Báo cáo thống kê";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_nhanvien;
        private System.Windows.Forms.Button button_luong;
    }
}