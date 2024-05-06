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
    public partial class QuanLyChucVu : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public static string MaChucVu;
        public static string TenChucVu;
        public static decimal HeSoPhuCap;
        public QuanLyChucVu()
        {
            InitializeComponent();
            this.ActiveControl = textBox_tenchucvu;
        }

        private void load_data()
        {
            SqlCommand command = new SqlCommand(GenericClass.selectChucVu, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_chucvu.DataSource = data;
        }


        // nhap so, k nhập chữ
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

        private void dataGridView_chucvu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selected_row = dataGridView_chucvu.CurrentRow.Index;
                if (selected_row >= 0)
                {
                    MaChucVu = dataGridView_chucvu.Rows[selected_row].Cells["Column_machucvu"].Value.ToString();
                    TenChucVu = dataGridView_chucvu.Rows[selected_row].Cells["Column_tenchucvu"].Value.ToString();
                    HeSoPhuCap = decimal.Parse(dataGridView_chucvu.Rows[selected_row].Cells["Column_hesophucap"].Value.ToString());
                }
            }
            catch (Exception)
            {
                QuanLyChucVu_Load(sender, e);
            }
        }

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            textBox_machucvu.Text = GenericClass.GenerateRandomString("cv");
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void QuanLyChucVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        // thừa ( ms đầu vào k chọn dòng nào cả)
        private void dataGridView_chucvu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_chucvu.Rows.Count > 0)
            {
                dataGridView_chucvu.Rows[0].Selected = false;
            }
        }

        private void làmMớiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyChucVu_Load(sender, e);
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

        private void toolStripButton_them_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ChucVu (MaChucVu, TenChucVu, HeSoPhuCap) VALUES (@MaChucVu, @TenChucVu, @HeSoPhuCap)";
            if (!string.IsNullOrEmpty(textBox_tenchucvu.Text) && !string.IsNullOrEmpty(textBox_hesophucap.Text))
            {
                decimal heSoPhuCap = decimal.Parse(textBox_hesophucap.Text); //(đổi từ dạng string sang dạng số thập phân )
                if (heSoPhuCap > 1 && heSoPhuCap < 2)
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaChucVu", textBox_machucvu.Text);
                        command.Parameters.AddWithValue("@TenChucVu", textBox_tenchucvu.Text);
                        command.Parameters.AddWithValue("@HeSoPhuCap", textBox_hesophucap.Text);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            QuanLyChucVu_Load(sender, e);
                            textBox_tenchucvu.Clear();
                            textBox_hesophucap.Clear();
                            textBox_tenchucvu.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Thêm chức vụ mới thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thêm chức vụ mới thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hệ số phụ cấp không hợp lệ.\n1 < Hệ số phụ cấp < 2.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView_chucvu.SelectedRows.Count > 0)
            {
                if (dataGridView_chucvu.SelectedRows.Count == 1)
                {
                    ChinhSuaChucVu form = new ChinhSuaChucVu();
                    form.ShowDialog();
                    QuanLyChucVu_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn một chức vụ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để cập nhật.");
            }
        }

        // đoạn này em chat gpt
        private void toolStripButton_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_chucvu.SelectedRows.Count > 0)
            {
                List<string> selectedMaChucVuValues = new List<string>();

                foreach (DataGridViewRow row in dataGridView_chucvu.SelectedRows)
                {
                    selectedMaChucVuValues.Add(row.Cells["Column_machucvu"].Value.ToString());
                }

                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + selectedMaChucVuValues.Count + " mục đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        foreach (string maChucVuValue in selectedMaChucVuValues)
                        {
                            string deleteQuery = "DELETE FROM ChucVu WHERE MaChucVu = @MaChucVu";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@MaChucVu", maChucVuValue);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Xóa chức vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (string maChucVuValue in selectedMaChucVuValues)
                        {
                            DataGridViewRow rowToRemove = dataGridView_chucvu.Rows
                                .Cast<DataGridViewRow>()
                                .Where(r => r.Cells["Column_machucvu"].Value.ToString() == maChucVuValue)
                                .First();
                            dataGridView_chucvu.Rows.Remove(rowToRemove);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Xóa chức vụ thất bại. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox_machucvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_hesophucap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
