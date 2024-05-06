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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public partial class QuanLyNhanVien : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public static string MaNhanVien;
        public static string HoTen;
        public static string GioiTinh;
        public static DateTime NgaySinh;
        public static string DiaChi;
        public static string SoDienThoai;
        public static string QueQuan;
        public static string MaPhong;
        public static string MaChucVu;
        public static string MatKhau;
        public static string LoaiNguoiDung;
        public static decimal HeSoLuong;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void load_data()
        {
            string query = GenericClass.selectNhanVien;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_nhanvien.DataSource = data;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void QuanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void toolStripButton_them_Click(object sender, EventArgs e)
        {
            ThemNhanVien form = new ThemNhanVien();
            form.ShowDialog();
            QuanLyNhanVien_Load(sender, e);
        }

        private void toolStripButton_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_nhanvien.SelectedRows.Count > 0)
            {
                if (dataGridView_nhanvien.SelectedRows.Count == 1)
                {
                    if (PhienDangNhap.MaNhanVien.Equals(MaNhanVien, StringComparison.OrdinalIgnoreCase))
                    {
                        HoSoNhanVien form = new HoSoNhanVien();
                        form.ShowDialog();
                        QuanLyNhanVien_Load(sender, e);
                    }
                    else
                    {

                        ChinhSuaNhanVien form = new ChinhSuaNhanVien();
                        form.ShowDialog();
                        QuanLyNhanVien_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn một nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.");
            }
        }

        private void toolStripButton_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_nhanvien.SelectedRows.Count > 0)
            {
                if (!MaNhanVien.Equals(PhienDangNhap.MaNhanVien, StringComparison.OrdinalIgnoreCase))
                {
                    List<string> selectedValues = new List<string>();

                    foreach (DataGridViewRow row in dataGridView_nhanvien.SelectedRows)
                    {
                        selectedValues.Add(row.Cells["Column_manhanvien"].Value.ToString());
                    }

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa " + selectedValues.Count + " mục đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        SqlTransaction transaction = connection.BeginTransaction();
                        try
                        {
                            foreach (string Value in selectedValues)
                            {
                                string deleteQuery = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
                                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@MaNhanVien", Value);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            foreach (string Value in selectedValues)
                            {
                                DataGridViewRow rowToRemove = dataGridView_nhanvien.Rows
                                    .Cast<DataGridViewRow>()
                                    .Where(r => r.Cells["Column_manhanvien"].Value.ToString() == Value)
                                    .First();
                                dataGridView_nhanvien.Rows.Remove(rowToRemove);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Xóa nhân viên thất bại. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa người dùng đang đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_nhanvien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_nhanvien.Rows.Count > 0)
            {
                dataGridView_nhanvien.Rows[0].Selected = false;
            }
        }

        private void dataGridView_nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selected_row = dataGridView_nhanvien.CurrentRow?.Index ?? -1;
                if (selected_row >= 0)
                {
                    MaNhanVien = dataGridView_nhanvien.Rows[selected_row].Cells["Column_manhanvien"].Value.ToString();
                    HoTen = dataGridView_nhanvien.Rows[selected_row].Cells["Column_hoten"].Value.ToString();
                    GioiTinh = dataGridView_nhanvien.Rows[selected_row].Cells["Column_gioitinh"].Value.ToString();
                    NgaySinh = (DateTime)dataGridView_nhanvien.Rows[selected_row].Cells["Column_ngaysinh"].Value;
                    DiaChi = dataGridView_nhanvien.Rows[selected_row].Cells["Column_diachi"].Value.ToString();
                    SoDienThoai = dataGridView_nhanvien.Rows[selected_row].Cells["Column_sodienthoai"].Value.ToString();
                    QueQuan = dataGridView_nhanvien.Rows[selected_row].Cells["Column_quequan"].Value.ToString();
                    MaPhong = dataGridView_nhanvien.Rows[selected_row].Cells["Column_maphong"].Value.ToString();
                    MaChucVu = dataGridView_nhanvien.Rows[selected_row].Cells["Column_machucvu"].Value.ToString();
                    MatKhau = dataGridView_nhanvien.Rows[selected_row].Cells["Column_matkhau"].Value.ToString();
                    LoaiNguoiDung = dataGridView_nhanvien.Rows[selected_row].Cells["Column_loainguoidung"].Value.ToString();
                    HeSoLuong = decimal.Parse(dataGridView_nhanvien.Rows[selected_row].Cells["Column_hesoluong"].Value.ToString());
                }
            }
            catch (Exception)
            {
                QuanLyNhanVien_Load(sender, e);
            }
        }

        private void textBox_timkiem_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NhanVien WHERE HoTen LIKE @TimKiem OR MaNhanVien LIKE @TimKiem";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TimKiem", "%" + textBox_timkiem.Text + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_nhanvien.DataSource = data;
        }

        private void làmMớiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien_Load(sender, e);
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_sua_Click(sender, e);
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_xoa_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_trolai_Click(sender, e);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_them_Click(sender, e);
        }
    }
}
