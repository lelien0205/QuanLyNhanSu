using System;
using System.Collections;
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
    public partial class QuanLyChamCong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public static string MaNhanVien;
        public static string MaChamCong;
        public static string HoTen;
        public static string GioiTinh;
        public static DateTime NgaySinh;
        public static string MaPhong;
        public static int Thang;
        public static int Nam;
        //public static int SoNgayLamViec;
        public static string MaLuong;
        public QuanLyChamCong()
        {
            InitializeComponent();
        }

        private void load_data()
        {
            MaLuong = GenericClass.GenerateRandomString("l");
            MaChamCong = GenericClass.GenerateRandomString("cc");
            string query = "SELECT NV.MaNhanVien, NV.HoTen, NV.GioiTinh, NV.NgaySinh, P.TenPhong FROM NhanVien NV JOIN Phong P ON NV.MaPhong = P.MaPhong WHERE P.MaPhong = @MaPhong ORDER BY RIGHT(NV.HoTen, CHARINDEX(' ', REVERSE(NV.HoTen)) - 1) ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaPhong", comboBox_maphong.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_chamcong.DataSource = data;
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
            comboBox_thang.Items.Clear();
            comboBox_nam.Items.Clear();
            comboBox_thang.Items.AddRange(GenericClass.CreateArrayList(1, 12).ToArray());
            comboBox_nam.Items.AddRange(GenericClass.CreateArrayList(DateTime.Now.Year - 50, DateTime.Now.Year).ToArray());
            comboBox_nam.SelectedIndex = 0;
            comboBox_thang.SelectedIndex = 0;
        }

        private void QuanLyChamCong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
            load_data();
        }

        private void QuanLyChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void comboBox_maphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void dataGridView_chamcong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selected_row = dataGridView_chamcong.CurrentRow.Index;
                if (selected_row >= 0)
                {
                    MaNhanVien = dataGridView_chamcong.Rows[selected_row].Cells["Column_manhanvien"].Value.ToString();
                    HoTen = dataGridView_chamcong.Rows[selected_row].Cells["Column_hoten"].Value.ToString();
                    GioiTinh = dataGridView_chamcong.Rows[selected_row].Cells["Column_gioitinh"].Value.ToString();
                    NgaySinh = (DateTime)dataGridView_chamcong.Rows[selected_row].Cells["Column_ngaysinh"].Value;
                    MaPhong = comboBox_maphong.SelectedValue.ToString();
                }
            }
            catch (Exception)
            {
                QuanLyChamCong_Load(sender, e);
            }
        }

        private void dataGridView_chamcong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView_chamcong.Rows.Count > 0)
            {
                dataGridView_chamcong.Rows[0].Selected = false;
            }
        }

        private void comboBox_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thang = int.Parse(comboBox_thang.SelectedItem.ToString());
        }

        private void comboBox_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nam = int.Parse(comboBox_nam.SelectedItem.ToString());
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_chamcong.SelectedRows.Count > 0)
            {
                if (dataGridView_chamcong.SelectedRows.Count == 1)
                {
                    ChinhSuaChamCong form = new ChinhSuaChamCong();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Chỉ được chọn một nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xem chi tiết.");
            }
        }

        private void tinhLuong(string maLuong, string maNhanVien, int thang, int nam)
        {
            string checkQuery = "SELECT COUNT(*) FROM Luong " +
            "WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang AND Nam = @Nam";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                checkCommand.Parameters.AddWithValue("@Thang", thang);
                checkCommand.Parameters.AddWithValue("@Nam", nam);

                int existingRecordsCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingRecordsCount > 0)
                {
                    Console.WriteLine("Bản ghi đã tồn tại.");
                }
                else
                {
                    string insertQuery = "INSERT INTO Luong (MaLuong, MaNhanVien, Thang, Nam, Luong) " +
                        "VALUES (@MaLuong, @MaNhanVien, @Thang, @Nam, " +
                        "(SELECT NhanVien.HeSoLuong * 1500000 + ChamCong.SoNgayLamViec * 200000 * ChucVu.HeSoPhuCap - " +
                        "IIF(ChamCong.SoNgayLamViec < 20, (20 - ChamCong.SoNgayLamViec) * 500000, 0) " +
                        "FROM NhanVien " +
                        "INNER JOIN ChamCong ON NhanVien.MaNhanVien = ChamCong.MaNhanVien " +
                        "INNER JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu " +
                        "WHERE NhanVien.MaNhanVien = @MaNhanVien AND ChamCong.Thang = @Thang AND ChamCong.Nam = @Nam))";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@MaLuong", maLuong);
                        insertCommand.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                        insertCommand.Parameters.AddWithValue("@Thang", thang);
                        insertCommand.Parameters.AddWithValue("@Nam", nam);

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Bản ghi đã được thêm vào bảng Luong.");
                        }
                        else
                        {
                            Console.WriteLine("Thêm bản ghi thất bại.");
                        }
                    }
                }
            }
        }

        private void toolStripButton_them_Click(object sender, EventArgs e)
        {
            if (dataGridView_chamcong.SelectedRows.Count > 0)
            {
                Thang = int.Parse(comboBox_thang.SelectedItem.ToString());
                Nam = int.Parse(comboBox_nam.SelectedItem.ToString());
                try
                {
                    DataGridViewRow selectedRow = dataGridView_chamcong.Rows[dataGridView_chamcong.CurrentCell.RowIndex];
                    string maNhanVien = MaNhanVien;
                    string queryCheckDuplicate = "SELECT COUNT(*) FROM ChamCong WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang AND Nam = @Nam";
                    SqlCommand commandCheckDuplicate = new SqlCommand(queryCheckDuplicate, connection);
                    commandCheckDuplicate.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                    commandCheckDuplicate.Parameters.AddWithValue("@Thang", Thang);
                    commandCheckDuplicate.Parameters.AddWithValue("@Nam", Nam);

                    int duplicateCount = (int)commandCheckDuplicate.ExecuteScalar();
                    int soNgayLamViec = int.Parse(selectedRow.Cells["Column_songaylamviec"].Value.ToString());
                    if (selectedRow.Cells["Column_songaylamviec"].Value != null && !string.IsNullOrWhiteSpace(selectedRow.Cells["Column_songaylamviec"].Value.ToString()))
                    {
                        if (soNgayLamViec > 0 && soNgayLamViec <= 31)
                        {
                            if (duplicateCount == 0)
                            {
                                if ((Thang == 2 && GenericClass.isLeapYear(Nam) && soNgayLamViec <= 29) || ((Thang == 4 || Thang == 6 || Thang == 9 || Thang == 11) && soNgayLamViec <= 30) || ((Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12) && soNgayLamViec <= 31))
                                {

                                    string query = "INSERT INTO ChamCong (MaChamCong, MaNhanVien, Thang, Nam, SoNgayLamViec) " +
                                                "VALUES (@MaChamCong, @MaNhanVien, @Thang, @Nam, @SoNgayLamViec)";
                                    SqlCommand command = new SqlCommand(query, connection);
                                    command.Parameters.AddWithValue("@MaChamCong", MaChamCong);
                                    command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                                    command.Parameters.AddWithValue("@Thang", Thang);
                                    command.Parameters.AddWithValue("@Nam", Nam);
                                    command.Parameters.AddWithValue("@SoNgayLamViec", selectedRow.Cells["Column_songaylamviec"].Value.ToString());

                                    int rowsAffected = command.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Đã chấm công tháng " + Thang + "/" + Nam + " cho nhân viên " + HoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tinhLuong(MaLuong, MaNhanVien, Thang, Nam);
                                        QuanLyChamCong_Load(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Chấm công thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Số ngày làm việc không hợp lệ cho tháng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bản ghi đã tồn tại. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số ngày làm việc không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập số ngày làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void toolStripButton_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_chitiet_Click(object sender, EventArgs e)
        {
            ThongTinChamCong form = new ThongTinChamCong();
            form.ShowDialog();
            QuanLyChamCong_Load(sender, e);
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyChamCong_Load(sender, e);
        }

        private void toolStripButton_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Không thể xóa trực tiếp từ bảng công.\nChuyển sang bảng công chi tiết?", "Chuyển hướng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                toolStripButton_chitiet_Click(sender, e);
            }
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_chitiet_Click(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_xoa_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton_trolai_Click(sender, e);
        }
    }
}
