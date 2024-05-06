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
    public partial class ThemNhanVien : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public ThemNhanVien()
        {
            InitializeComponent();
            this.ActiveControl = textBox_hoten;
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

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            textBox_manhanvien.Text = GenericClass.GenerateRandomString("nv"); // Hàm tạo mã random
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
        }

        private void ThemNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
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

        private void button_them_Click(object sender, EventArgs e)
        {
            int nam = DateTime.Now.Year;
            if (!string.IsNullOrEmpty(textBox_hoten.Text) && (!string.IsNullOrEmpty(textBox_diachi.Text)) && !string.IsNullOrEmpty(textBox_sodienthoai.Text) && !string.IsNullOrEmpty(textBox_quequan.Text) && !string.IsNullOrEmpty(textBox_matkhau.Text) && !string.IsNullOrEmpty(textBox_hesoluong.Text) && (radioButton_nam.Checked || radioButton_nu.Checked) && (radioButton_nhanvien.Checked || radioButton_quanly.Checked) && comboBox_machucvu.SelectedIndex != -1 && comboBox_maphong.SelectedIndex != -1)
            {
                if (nam - dateTimePicker_ngaysinh.Value.Year > 18 && nam - dateTimePicker_ngaysinh.Value.Year < 100)
                {
                    if (decimal.Parse(textBox_hesoluong.Text) > 0)
                    {
                        string query = "INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, QueQuan, MaPhong, MaChucVu, MatKhau, LoaiNguoiDung, HeSoLuong) " +
                                       "VALUES (@MaNhanVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDienThoai, @QueQuan, @MaPhong, @MaChucVu, @MatKhau, @LoaiNguoiDung, @HeSoLuong)";

                        string maNhanVien = textBox_manhanvien.Text;
                        string hoTen = textBox_hoten.Text;
                        string gioitinh = radioButton_nam.Checked ? "Nam" : "Nữ";
                        DateTime ngaySinh = dateTimePicker_ngaysinh.Value;
                        string diaChi = textBox_diachi.Text;
                        string soDienThoai = textBox_sodienthoai.Text;
                        string queQuan = textBox_quequan.Text;
                        string maPhong = comboBox_maphong.SelectedValue.ToString();
                        string maChucVu = comboBox_machucvu.SelectedValue.ToString();
                        string matKhau = textBox_matkhau.Text;
                        string loainguoidung = radioButton_nhanvien.Checked ? "user" : "admin";
                        decimal heSoLuong = decimal.Parse(textBox_hesoluong.Text);

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        command.Parameters.AddWithValue("@HoTen", hoTen);
                        command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@DiaChi", diaChi);
                        command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        command.Parameters.AddWithValue("@QueQuan", queQuan);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaChucVu", maChucVu);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);
                        command.Parameters.AddWithValue("@LoaiNguoiDung", loainguoidung);
                        command.Parameters.AddWithValue("@HeSoLuong", heSoLuong);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox_manhanvien.Text = GenericClass.GenerateRandomString("nv");
                                textBox_hoten.Focus();
                                textBox_hoten.Clear();
                                radioButton_nam.Checked = false;
                                radioButton_nu.Checked = false;
                                dateTimePicker_ngaysinh.Value = DateTime.Now;
                                textBox_diachi.Clear();
                                textBox_sodienthoai.Clear();
                                textBox_quequan.Clear();
                                comboBox_machucvu.SelectedIndex = 0;
                                comboBox_maphong.SelectedIndex = 0;
                                textBox_matkhau.Clear();
                                radioButton_quanly.Checked = false;
                                radioButton_nhanvien.Checked = false;
                                textBox_hesoluong.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Thêm nhân viên thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hệ số lương không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
