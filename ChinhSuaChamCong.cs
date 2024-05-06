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
    public partial class ChinhSuaChamCong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public ChinhSuaChamCong()
        {
            InitializeComponent();

        }

        private void load_combobox()
        {
            comboBox_thang.Items.Clear();
            comboBox_nam.Items.Clear();
            comboBox_thang.Items.AddRange(GenericClass.CreateArrayList(1, 12).ToArray());
            comboBox_nam.Items.AddRange(GenericClass.CreateArrayList(DateTime.Now.Year - 50, DateTime.Now.Year).ToArray());
            comboBox_nam.SelectedIndex = 0;
            comboBox_thang.SelectedIndex = 0;
        }

        private void load_data()
        {
            textBox_machamcong.Text = ThongTinChamCong.MaChamCong;
            textBox_manhanvien.Text = ThongTinChamCong.MaNhanVien;
            textBox_hoten.Text = ThongTinChamCong.HoTen;
            comboBox_thang.SelectedItem = ThongTinChamCong.Thang;
            comboBox_nam.SelectedItem = ThongTinChamCong.Nam;
            textBox_songaylamviec.Text = ThongTinChamCong.SoNgayLamViec.ToString();
        }

        private void ThongTinChamCong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
            load_data();
        }

        private void ThongTinChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string maLuong = GenericClass.laymaluong();
            int thang = int.Parse(comboBox_thang.SelectedItem.ToString());
            int nam = int.Parse(comboBox_nam.SelectedItem.ToString());
            int soNgayLamViec = int.Parse(textBox_songaylamviec.Text);
            string updateQuery = "UPDATE ChamCong SET Thang = @Thang, Nam = @Nam, SoNgayLamViec = @SoNgayLamViec WHERE MaChamCong = @MaChamCong";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Thang", thang);
                command.Parameters.AddWithValue("@Nam", nam);
                command.Parameters.AddWithValue("@SoNgayLamViec", soNgayLamViec);
                command.Parameters.AddWithValue("@MaChamCong", textBox_machamcong.Text);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateLuong(maLuong, thang, nam, soNgayLamViec);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void updateLuong(string maLuong, int thang, int nam, int soNgayLamViec)
        {
            string updateQuery = "UPDATE L SET L.Thang = @Thang, L.Nam = @Nam, L.Luong = (N.HeSoLuong * 1500000 + @SoNgayLamViec * 200000 * CV.HeSoPhuCap) - IIF(@SoNgayLamViec < 20, (20 - @SoNgayLamViec) * 500000, 0) FROM Luong L INNER JOIN NhanVien N ON L.MaNhanVien = N.MaNhanVien INNER JOIN ChamCong C ON N.MaNhanVien = C.MaNhanVien INNER JOIN ChucVu CV ON N.MaChucVu = CV.MaChucVu WHERE L.MaLuong = @MaLuong AND C.Thang = @Thang AND C.Nam = @Nam";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Thang", thang);
                command.Parameters.AddWithValue("@Nam", nam);
                command.Parameters.AddWithValue("@SoNgayLamViec", soNgayLamViec);
                command.Parameters.AddWithValue("@MaLuong", maLuong);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Cập nhật thành công.");
                }
                else
                {
                    Console.WriteLine("Không có bản ghi nào được cập nhật.");
                }
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
