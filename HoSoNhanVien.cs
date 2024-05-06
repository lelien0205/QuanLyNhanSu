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
    public partial class HoSoNhanVien : Form
    {
        SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public string MaNhanVien = PhienDangNhap.MaNhanVien;
        public string HoTen = PhienDangNhap.HoTen;
        public bool LaNhanVien = PhienDangNhap.LaNhanVien;
        private string maNhanVien;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string soDienThoai;
        private string queQuan;
        private string maPhong;
        private string maChucVu;
        private string loaiNguoiDung;
        private decimal heSoLuong;
        public HoSoNhanVien()
        {
            InitializeComponent();
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

        private void HoSoNhanVien_Load(object sender, EventArgs e)
        {
            load_combobox();
            hoSoNhanVien();
        }

        private void disable_components()
        {
            // Vô hiệu hóa tất cả các control
            this.Height = 615;
            textBox_hoten.Enabled = false;
            radioButton_nam.Enabled = false;
            radioButton_nu.Enabled = false;
            if (string.Equals("nam", gioiTinh, StringComparison.OrdinalIgnoreCase))
            {
                radioButton_nam.Checked = true;
            }
            else
            {
                radioButton_nu.Checked = true;
            }
            dateTimePicker_ngaysinh.Enabled = false;
            textBox_diachi.Enabled = false;
            textBox_sodienthoai.Enabled = false;
            textBox_quequan.Enabled = false;
            comboBox_machucvu.Enabled = false;
            comboBox_maphong.Enabled = false;
            textBox_hesoluong.Enabled = false;
            button_luu.Visible = false;
            button_luu.Enabled = false;
            button_huy.Visible = false;
            button_huy.Enabled = false;
        }

        private void hoSoNhanVien()
        {
            string query = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc thông tin từ database và gán vào biến
                    maNhanVien = reader["MaNhanVien"].ToString();
                    hoTen = reader["HoTen"].ToString();
                    gioiTinh = reader["GioiTinh"].ToString();
                    ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                    diaChi = reader["DiaChi"].ToString();
                    soDienThoai = reader["SoDienThoai"].ToString();
                    queQuan = reader["QueQuan"].ToString();
                    maPhong = reader["MaPhong"].ToString();
                    maChucVu = reader["MaChucVu"].ToString();
                    loaiNguoiDung = reader["LoaiNguoiDung"].ToString();
                    heSoLuong = Convert.ToDecimal(reader["HeSoLuong"]);
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            // Gán thông tin vừa đọc từ database cho các textbox
            textBox_manhanvien.Text = maNhanVien;
            textBox_hoten.Text = hoTen;
            if (string.Equals("nam", gioiTinh, StringComparison.OrdinalIgnoreCase))
            {
                pictureBox_anhdaidien.Image = NTGiangDQHuanLTPLien_LTNET.Properties.Resources.male;
                radioButton_nam.Checked = true;
            }
            else
            {
                pictureBox_anhdaidien.Image = NTGiangDQHuanLTPLien_LTNET.Properties.Resources.female;
                radioButton_nu.Checked = true;
            }
            dateTimePicker_ngaysinh.Value = ngaySinh;
            textBox_diachi.Text = diaChi;
            textBox_sodienthoai.Text = soDienThoai;
            textBox_quequan.Text = queQuan;
            comboBox_machucvu.SelectedValue = maChucVu;
            comboBox_maphong.SelectedValue = maPhong;
            textBox_hesoluong.Text = heSoLuong.ToString();
            disable_components();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void đổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox_hoten.Enabled = true;
            //radioButton_nam.Enabled = true;
            //radioButton_nu.Enabled = true;
            this.Height = 646;
            if (string.Equals("nam", gioiTinh, StringComparison.OrdinalIgnoreCase))
            {
                radioButton_nam.Checked = true;
            }
            else
            {
                radioButton_nu.Checked = true;
            }
            dateTimePicker_ngaysinh.Enabled = true;
            textBox_diachi.Enabled = true;
            textBox_sodienthoai.Enabled = true;
            textBox_quequan.Enabled = true;
            // Nếu là quản lý thì được quyền chỉnh sửa phòng, chức vụ và hệ số lương
            if (!LaNhanVien)
            {
                comboBox_maphong.Enabled = true;
                comboBox_machucvu.Enabled = true;
                textBox_hesoluong.Enabled = true;
            }
            button_luu.Visible = true;
            button_luu.Enabled = true;
            button_huy.Visible = true;
            button_huy.Enabled = true;
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query;
                // Kiểm tra điều kiện nếu là quản lý thì được cập nhật đầy đủ các thuộc tính
                if (LaNhanVien)
                {
                    query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, QueQuan = @QueQuan WHERE MaNhanVien = @MaNhanVien";
                }
                else
                {
                    query = "UPDATE NhanVien SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, QueQuan = @QueQuan, MaPhong = @MaPhong, MaChucVu = @MaChucVu, HeSoLuong = @HeSoLuong WHERE MaNhanVien = @MaNhanVien";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox_manhanvien.Text);
                    command.Parameters.AddWithValue("@HoTen", textBox_hoten.Text);
                    command.Parameters.AddWithValue("@GioiTinh", radioButton_nam.Checked ? "Nam" : "Nữ");
                    command.Parameters.AddWithValue("@NgaySinh", dateTimePicker_ngaysinh.Value);
                    command.Parameters.AddWithValue("@DiaChi", textBox_diachi.Text);
                    command.Parameters.AddWithValue("@SoDienThoai", textBox_sodienthoai.Text);
                    command.Parameters.AddWithValue("@QueQuan", textBox_quequan.Text);
                    if (!LaNhanVien)
                    {
                        command.Parameters.AddWithValue("@MaPhong", comboBox_maphong.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@MaChucVu", comboBox_machucvu.SelectedValue.ToString());
                        command.Parameters.AddWithValue("@HeSoLuong", Convert.ToDecimal(textBox_hesoluong.Text));
                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (rowsAffected > 0)
                        {
                            HoSoNhanVien_Load(sender, e);
                            MessageBox.Show("Cập nhật thông tin thành công.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có thông tin nào được cập nhật.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Quay trở lại giao diện thông tin, vô hiệu hóa tất cả control
                hoSoNhanVien();
            }
        }

        private void HoSoNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Xóa thông tin phiên đăng nhập khi thoát ứng dụng
            // GenericClass.XoaPhienDangNhap();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau form = new DoiMatKhau();
            form.ShowDialog();
        }

        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangChamCong bangChamCong = new BangChamCong();
            bangChamCong.ShowDialog();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuong bangLuong = new BangLuong();
            bangLuong.ShowDialog();
        }
    }
}
