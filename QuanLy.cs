using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public partial class QuanLy : Form
    {
        SqlConnection connection;
        public string MaNhanVien = PhienDangNhap.MaNhanVien;
        public string HoTen = PhienDangNhap.HoTen;
        public bool LaNhanVien = PhienDangNhap.LaNhanVien;
        private int countNhanVien;
        private int countChucVu;
        private int countPhong;

        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhienDangNhap.XoaPhienDangNhap();
        }
        private void load_data()
        {
            using (connection = new SqlConnection(GenericClass.connectionString))
            {
                connection.Open();
                string queryNhanVien = "SELECT COUNT(*) FROM NhanVien";
                SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, connection);
                countNhanVien = (int)commandNhanVien.ExecuteScalar();

                string queryPhong = "SELECT COUNT(*) FROM Phong";
                SqlCommand commandPhong = new SqlCommand(queryPhong, connection);
                countPhong = (int)commandPhong.ExecuteScalar();

                string queryChucVu = "SELECT COUNT(*) FROM ChucVu";
                SqlCommand commandChucVu = new SqlCommand(queryChucVu, connection);
                countChucVu = (int)commandChucVu.ExecuteScalar();
            }
            if (countNhanVien < 10)
            {
                label_nhanvien.Text = "0" + countNhanVien.ToString();
            }
            else
            {
                label_nhanvien.Text = countNhanVien.ToString();
            }
            if (countPhong < 10)
            {
                label_phong.Text = "0" + countPhong.ToString();
            }
            else
            {
                label_phong.Text = countPhong.ToString();
            }
            if (countChucVu < 10)
            {
                label_chucvu.Text = "0" + countChucVu.ToString();
            }
            else
            {
                label_chucvu.Text = countChucVu.ToString();
            }
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            load_data();
            timer1.Start();
            button_hoso.Text = "Xin chào," + Environment.NewLine + HoTen;
        }

        private void pictureBox_thietlap_Click(object sender, EventArgs e)
        {
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
        }

        private void pictureBox_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_hoso_Click(object sender, EventArgs e)
        {
            HoSoNhanVien form = new HoSoNhanVien();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button_phong_Click(object sender, EventArgs e)
        {
            QuanLyPhong form = new QuanLyPhong();
            this.Hide();
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void button_chucvu_Click(object sender, EventArgs e)
        {
            QuanLyChucVu form = new QuanLyChucVu();
            this.Hide();
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void button_nhanvien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien form = new QuanLyNhanVien();
            this.Hide();
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void button_chamcong_Click(object sender, EventArgs e)
        {
            QuanLyChamCong form = new QuanLyChamCong();
            this.Hide();
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void button_tienluong_Click(object sender, EventArgs e)
        {
            QuanLyTienLuong form = new QuanLyTienLuong();
            this.Hide();
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe form = new BaoCaoThongKe();
            Point buttonLocationOnScreen = button_thongke.PointToScreen(Point.Empty);
            int x = buttonLocationOnScreen.X + button_thongke.Width + 10;
            int y = buttonLocationOnScreen.Y + (button_thongke.Height - form.Height) / 2;
            form.Location = new Point(x, y);
            form.ShowDialog();
            QuanLy_Load(sender, e);
            this.Show();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // panel_background(sender, e, cornerRadius, alpha, red, green, blue)
            GenericClass.panel_background(sender, e, 50, 130, 0, 0, 0);
        }
    }
}
