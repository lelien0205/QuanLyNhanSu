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
    public partial class QuanLyPhong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public static string MaPhong;
        public static string TenPhong;
        public static string DiaChiPhong;
        public static string SoDienThoai;

        public QuanLyPhong()
        {
            InitializeComponent();
            this.ActiveControl = textBox_tenphong;
        }

        private void load_data()
        {
            SqlCommand command = new SqlCommand(GenericClass.selectPhong, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_phong.DataSource = data;
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            textBox_maphong.Text = GenericClass.GenerateRandomString("p"); // Hàm tạo mã random
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void QuanLyPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void dataGridView_phong_SelectionChanged(object sender, EventArgs e)
        {
            int selected_row = dataGridView_phong.CurrentRow.Index;
            if (selected_row >= 0)
            {
                MaPhong = dataGridView_phong.Rows[selected_row].Cells["Column_maphong"].Value.ToString();
                TenPhong = dataGridView_phong.Rows[selected_row].Cells["Column_tenphong"].Value.ToString();
                DiaChiPhong = dataGridView_phong.Rows[selected_row].Cells["Column_diachiphong"].Value.ToString();
                SoDienThoai = dataGridView_phong.Rows[selected_row].Cells["Column_sodienthoai"].Value.ToString();
            }
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_sua_Click(sender, e);
        }

        private void làmMớiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhong_Load(sender, e);
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_xoa_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_trolai_Click(sender, e);
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

        private void dataGridView_phong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_phong.Rows.Count > 0)
            {
                dataGridView_phong.Rows[0].Selected = false;
            }
        }

        private void toolStripButton_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Phong (MaPhong, TenPhong, DiaChiPhong, SoDienThoai) VALUES (@MaPhong, @TenPhong, @DiaChiPhong, @SoDienThoai)";
            if (!string.IsNullOrEmpty(textBox_tenphong.Text) && !string.IsNullOrEmpty(textBox_diachiphong.Text) && !string.IsNullOrEmpty(textBox_sodienthoai.Text))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhong", textBox_maphong.Text);
                    command.Parameters.AddWithValue("@TenPhong", textBox_tenphong.Text);
                    command.Parameters.AddWithValue("@DiaChiPhong", textBox_diachiphong.Text);
                    command.Parameters.AddWithValue("@SoDienThoai", textBox_sodienthoai.Text);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        QuanLyPhong_Load(sender, e);
                        textBox_tenphong.Clear();
                        textBox_diachiphong.Clear();
                        textBox_sodienthoai.Clear();
                        textBox_tenphong.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng mới thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm phòng mới thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_phong.SelectedRows.Count > 0)
            {
                if (dataGridView_phong.SelectedRows.Count == 1)
                {
                    ChinhSuaPhong form = new ChinhSuaPhong();
                    form.ShowDialog();
                    QuanLyPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn một phòng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng để cập nhật.");
            }
        }

        private void toolStripButton_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_phong.SelectedRows.Count > 0)
            {
                List<string> selectedMaPhongValues = new List<string>();

                foreach (DataGridViewRow row in dataGridView_phong.SelectedRows)
                {
                    selectedMaPhongValues.Add(row.Cells["Column_maphong"].Value.ToString());
                }

                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + selectedMaPhongValues.Count + " mục đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        foreach (string maPhongValue in selectedMaPhongValues)
                        {
                            string deleteQuery = "DELETE FROM Phong WHERE MaPhong = @MaPhong";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaPhong", maPhongValue);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Xóa phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (string maPhongValue in selectedMaPhongValues)
                        {
                            DataGridViewRow rowToRemove = dataGridView_phong.Rows
                                .Cast<DataGridViewRow>()
                                .Where(r => r.Cells["Column_maphong"].Value.ToString() == maPhongValue)
                                .First();
                            dataGridView_phong.Rows.Remove(rowToRemove);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Xóa phòng thất bại. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_them_Click(sender, e);
        }
    }
}
