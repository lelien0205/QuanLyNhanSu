using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public partial class ChinhSuaPhong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        private string MaPhong = QuanLyPhong.MaPhong;
        private string TenPhong = QuanLyPhong.TenPhong;
        private string DiaChiPhong = QuanLyPhong.DiaChiPhong;
        private string SoDienThoai = QuanLyPhong.SoDienThoai;
        public ChinhSuaPhong()
        {
            InitializeComponent();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Quay trở lại giao diện chính
                this.Close();
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Phong SET TenPhong = @TenPhong, DiaChiPhong = @DiaChiPhong, SoDienThoai = @SoDienThoai WHERE MaPhong = @MaPhong";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenPhong", textBox_tenphong.Text);
            command.Parameters.AddWithValue("@DiaChiPhong", textBox_diachiphong.Text);
            command.Parameters.AddWithValue("@SoDienThoai", textBox_sodienthoai.Text);
            command.Parameters.AddWithValue("@MaPhong", MaPhong);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thông tin phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin phòng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChinhSuaPhong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            textBox_maphong.Text = MaPhong;
            textBox_tenphong.Text = TenPhong;
            textBox_diachiphong.Text = DiaChiPhong;
            textBox_sodienthoai.Text = SoDienThoai;
        }

        private void ChinhSuaPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void textBox_sodienthoai_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
