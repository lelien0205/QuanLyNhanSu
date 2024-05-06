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
    public partial class ChinhSuaNhanVien : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public ChinhSuaNhanVien()
        {
            InitializeComponent();
            this.ActiveControl = textBox_hoten;
        }

        private void hoSoNhanVien()
        {
            textBox_manhanvien.Text = QuanLyNhanVien.MaNhanVien;
            textBox_hoten.Text = QuanLyNhanVien.HoTen;
            if (QuanLyNhanVien.GioiTinh.Equals("nam", StringComparison.OrdinalIgnoreCase))
            {
                radioButton_nam.Checked = true;
            }
            else
            {
                radioButton_nu.Checked = true;
            }
            dateTimePicker_ngaysinh.Value = QuanLyNhanVien.NgaySinh;
            textBox_diachi.Text = QuanLyNhanVien.DiaChi;
            textBox_sodienthoai.Text = QuanLyNhanVien.SoDienThoai;
            textBox_quequan.Text = QuanLyNhanVien.QueQuan;
            comboBox_maphong.SelectedValue = QuanLyNhanVien.MaPhong;
            comboBox_machucvu.SelectedValue = QuanLyNhanVien.MaChucVu;
            textBox_matkhau.Text = QuanLyNhanVien.MatKhau;
            if (QuanLyNhanVien.GioiTinh.Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                radioButton_nhanvien.Checked = true;
            }
            else
            {
                radioButton_quanly.Checked = true;
            }
            textBox_hesoluong.Text = QuanLyNhanVien.HeSoLuong.ToString();
        }

        private void load_combobox()
        {
            string queryPhong = GenericClass.selectPhong;
            SqlCommand commandPhong = new SqlCommand(queryPhong, connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(commandPhong);
                DataTable phongDataTable = new DataTable();
                adapter.Fill(phongDataTable);
                comboBox_maphong.DataSource = phongDataTable;
                comboBox_maphong.ValueMember = "MaPhong";
                comboBox_maphong.DisplayMember = "TenPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string queryChucVu = GenericClass.selectChucVu;
            SqlCommand commandChucVu = new SqlCommand(queryChucVu, connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(commandChucVu);
                DataTable chucVuDataTable = new DataTable();
                adapter.Fill(chucVuDataTable);
                comboBox_machucvu.DataSource = chucVuDataTable;
                comboBox_machucvu.ValueMember = "MaChucVu";
                comboBox_machucvu.DisplayMember = "TenChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numbers_only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void no_space(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void ChinhSuaNhanVien_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
            hoSoNhanVien();
        }

        private void ChinhSuaNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, " +
               "QueQuan = @QueQuan, MaPhong = @MaPhong, MaChucVu = @MaChucVu, MatKhau = @MatKhau, LoaiNguoiDung = @LoaiNguoiDung, HeSoLuong = @HeSoLuong " +
               "WHERE MaNhanVien = @MaNhanVien";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HoTen", textBox_hoten.Text);
            if (radioButton_nam.Checked)
            {
                command.Parameters.AddWithValue("@GioiTinh", radioButton_nam.Text);
            }
            else
            {
                command.Parameters.AddWithValue("@GioiTinh", radioButton_nu.Text);
            }
            command.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Value);
            command.Parameters.AddWithValue("@DiaChi", textBox_diachi.Text);
            command.Parameters.AddWithValue("@SoDienThoai", textBox_sodienthoai.Text);
            command.Parameters.AddWithValue("@QueQuan", textBox_quequan.Text);
            command.Parameters.AddWithValue("@MaPhong", comboBox_maphong.SelectedValue.ToString());
            command.Parameters.AddWithValue("@MaChucVu", comboBox_machucvu.SelectedValue.ToString());
            command.Parameters.AddWithValue("@MatKhau", textBox_matkhau.Text);
            if (radioButton_nhanvien.Checked)
            {
                command.Parameters.AddWithValue("@LoaiNguoiDung", "user");
            }
            else
            {
                command.Parameters.AddWithValue("@LoaiNguoiDung", "admin");
            }
            command.Parameters.AddWithValue("@HeSoLuong", textBox_hesoluong.Text);
            command.Parameters.AddWithValue("@MaNhanVien", textBox_manhanvien.Text);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
