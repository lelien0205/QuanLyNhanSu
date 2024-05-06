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
    public partial class ThongTinChamCong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public static string MaNhanVien;
        public static string MaChamCong;
        public static string HoTen;
        public static int Thang;
        public static int Nam;
        public static int SoNgayLamViec;
        public ThongTinChamCong()
        {
            InitializeComponent();
        }

        private void load_data()
        {
            MaNhanVien = QuanLyChamCong.MaNhanVien;
            HoTen = QuanLyChamCong.HoTen;
            string query = "SELECT C.MaChamCong, C.MaNhanVien, N.HoTen, C.Thang, C.Nam, C.SoNgayLamViec FROM ChamCong C INNER JOIN NhanVien N ON C.MaNhanVien = N.MaNhanVien WHERE N.MaNhanVien = @MaNhanVien ORDER BY C.Nam ASC, C.Thang ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_chamcong.DataSource = data;
        }

        private void ThongTinChamCong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void ThongTinChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void dataGridView_chamcong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selected_row = dataGridView_chamcong.CurrentRow?.Index ?? -1;
                if (selected_row >= 0)
                {
                    MaChamCong = dataGridView_chamcong.Rows[selected_row].Cells["Column_machamcong"].Value.ToString();
                    Thang = int.Parse(dataGridView_chamcong.Rows[selected_row].Cells["Column_thang"].Value.ToString());
                    Nam = int.Parse(dataGridView_chamcong.Rows[selected_row].Cells["Column_nam"].Value.ToString());
                    SoNgayLamViec = int.Parse(dataGridView_chamcong.Rows[selected_row].Cells["Column_songaylamviec"].Value.ToString());
                }
            }
            catch (Exception)
            {
                ThongTinChamCong_Load(sender, e);
            }
        }

        private void toolStripButton_capnhat_Click(object sender, EventArgs e)
        {
            if (dataGridView_chamcong.SelectedRows.Count > 0)
            {
                if (dataGridView_chamcong.SelectedRows.Count == 1)
                {
                    ChinhSuaChamCong form = new ChinhSuaChamCong();
                    form.ShowDialog();
                    ThongTinChamCong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn một dòng.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.");
            }
        }

        private void toolStripButton_xoa_Click(object sender, EventArgs e)
        {
            string maLuong = GenericClass.laymaluong();
            string deleteQuery = "DELETE FROM ChamCong WHERE MaChamCong = @MaChamCong";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@MaChamCong", MaChamCong);

                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + dataGridView_chamcong.SelectedRows.Count + " mục đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deleteLuong(maLuong);
                        ThongTinChamCong_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void deleteLuong(string maLuong)
        {
            string deleteQuery = "DELETE FROM Luong WHERE MaLuong = @MaLuong";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@MaLuong", maLuong);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Xóa thành công.");
                }
                else
                {
                    Console.WriteLine("Không có bản ghi nào được xóa.");
                }
            }
        }

        private void toolStripButton_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinChamCong_Load(sender, e);
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_capnhat_Click(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_xoa_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_trolai_Click(sender, e);
        }

        private void dataGridView_chamcong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_chamcong.Rows.Count > 0)
            {
                dataGridView_chamcong.Rows[0].Selected = false;
            }
        }
    }
}
