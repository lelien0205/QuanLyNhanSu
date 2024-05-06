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
    public partial class DoiMatKhau : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public string MaNhanVien = PhienDangNhap.MaNhanVien;
        public string HoTen = PhienDangNhap.HoTen;
        public bool LaNhanVien = PhienDangNhap.LaNhanVien;
        private string matKhau;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void doiMatKhau()
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
                    matKhau = reader["MatKhau"].ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            doiMatKhau();
            button_hien_moi.BringToFront();
            button_hien_cu.BringToFront();
        }

        private void button_an(TextBox textBox_matkhau, Button button_hien)
        {
            if (textBox_matkhau.PasswordChar == '\0')
            {
                button_hien.BringToFront();
                textBox_matkhau.PasswordChar = '*';
            }
        }

        private void button_hien(TextBox textBox_matkhau, Button button_an)
        {
            if (textBox_matkhau.PasswordChar == '*')
            {
                button_an.BringToFront();
                textBox_matkhau.PasswordChar = '\0';
            }
        }

        private void button_hien_cu_Click(object sender, EventArgs e)
        {
            button_hien(textBox_matkhaucu, button_an_cu);
        }

        private void button_an_cu_Click(object sender, EventArgs e)
        {
            button_an(textBox_matkhaucu, button_hien_cu);
        }

        private void button_hien_moi_Click(object sender, EventArgs e)
        {
            button_hien(textBox_matkhaumoi, button_an_moi);
        }

        private void button_an_moi_Click(object sender, EventArgs e)
        {
            button_an(textBox_matkhaumoi, button_hien_moi);
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_matkhaucu.Text) && !string.IsNullOrEmpty(textBox_matkhaumoi.Text))
            {
                if (string.Equals(textBox_matkhaucu.Text, matKhau, StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        string query = "UPDATE NhanVien SET MatKhau = @MatKhau WHERE MaNhanVien = @MaNhanVien";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                            command.Parameters.AddWithValue("@MatKhau", textBox_matkhaumoi.Text);

                            int rowsAffected = command.ExecuteNonQuery();
                            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cập nhật mật khẩu thành công.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (connection.State != ConnectionState.Closed)
                                        connection.Close();
                                    DoiMatKhau_Load(sender, e);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Cập nhật mật khẩu thất bại.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không thể trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}
