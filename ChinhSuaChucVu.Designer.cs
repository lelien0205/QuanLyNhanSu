namespace NTGiangDQHuanLTPLien_LTNET
{
    partial class ChinhSuaChucVu
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
            this.button_huy = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.textBox_hesophucap = new System.Windows.Forms.TextBox();
            this.textBox_tenchucvu = new System.Windows.Forms.TextBox();
            this.textBox_machucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_huy
            // 
            this.button_huy.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.button_huy.Location = new System.Drawing.Point(116, 246);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(75, 23);
            this.button_huy.TabIndex = 19;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_luu
            // 
            this.button_luu.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.button_luu.Location = new System.Drawing.Point(35, 246);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(75, 23);
            this.button_luu.TabIndex = 18;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // textBox_hesophucap
            // 
            this.textBox_hesophucap.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_hesophucap.Location = new System.Drawing.Point(9, 177);
            this.textBox_hesophucap.Name = "textBox_hesophucap";
            this.textBox_hesophucap.Size = new System.Drawing.Size(208, 21);
            this.textBox_hesophucap.TabIndex = 16;
            this.textBox_hesophucap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hesophucap_KeyPress);
            // 
            // textBox_tenchucvu
            // 
            this.textBox_tenchucvu.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_tenchucvu.Location = new System.Drawing.Point(9, 119);
            this.textBox_tenchucvu.Name = "textBox_tenchucvu";
            this.textBox_tenchucvu.Size = new System.Drawing.Size(208, 21);
            this.textBox_tenchucvu.TabIndex = 15;
            // 
            // textBox_machucvu
            // 
            this.textBox_machucvu.Enabled = false;
            this.textBox_machucvu.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_machucvu.Location = new System.Drawing.Point(9, 61);
            this.textBox_machucvu.Name = "textBox_machucvu";
            this.textBox_machucvu.Size = new System.Drawing.Size(208, 21);
            this.textBox_machucvu.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hệ số phụ cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono PL SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã chức vụ:";
            // 
            // ChinhSuaChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 283);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.textBox_hesophucap);
            this.Controls.Add(this.textBox_tenchucvu);
            this.Controls.Add(this.textBox_machucvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChinhSuaChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa chức vụ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChinhSuaChucVu_FormClosed);
            this.Load += new System.EventHandler(this.ChinhSuaChucVu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.TextBox textBox_hesophucap;
        private System.Windows.Forms.TextBox textBox_tenchucvu;
        private System.Windows.Forms.TextBox textBox_machucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}