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
    public partial class ChinhSuaChucVu : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        private string MaChucVu = QuanLyChucVu.MaChucVu;
        private string TenChucVu = QuanLyChucVu.TenChucVu;
        private decimal HeSoPhuCap = QuanLyChucVu.HeSoPhuCap;
        public ChinhSuaChucVu()
        {
            InitializeComponent();
        }

        private void ChinhSuaChucVu_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            textBox_machucvu.Text = MaChucVu;
            textBox_tenchucvu.Text = TenChucVu;
            textBox_hesophucap.Text = HeSoPhuCap.ToString();
        }

        private void ChinhSuaChucVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void textBox_hesophucap_KeyPress(object sender, KeyPressEventArgs e)
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
            string query = "UPDATE ChucVu SET TenChucVu = @TenChucVu, HeSoPhuCap = @HeSoPhuCap WHERE MaChucVu = @MaChucVu";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenChucVu", textBox_tenchucvu.Text);
            command.Parameters.AddWithValue("@HeSoPhuCap", textBox_hesophucap.Text);
            command.Parameters.AddWithValue("@MaChucVu", MaChucVu);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thông tin chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chức vụ thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
