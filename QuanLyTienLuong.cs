using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public partial class QuanLyTienLuong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        decimal tongluong = 0;
        public QuanLyTienLuong()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            string query = "SELECT L.MaLuong, L.MaNhanVien, N.HoTen, L.Thang, L.Nam, L.Luong, CASE WHEN Luong > 10000000 THEN Luong * 0.1 ELSE 0 END AS ThueThuNhap FROM Luong L INNER JOIN NhanVien N ON L.MaNhanVien = N.MaNhanVien ORDER BY L.Nam ASC, L.Thang ASC";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_luong.DataSource = data;
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
            comboBox_maphong.SelectedIndex = 0;
            comboBox_nam.SelectedIndex = 0;
            comboBox_thang.SelectedIndex = 0;
        }

        private void QuanLyTienLuong_Load(object sender, EventArgs e)
        {
            if (GenericClass.fromBaoCao == true)
            {
                button_in.Visible = true;
            }
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
            load_data();
        }

        private void QuanLyTienLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            GenericClass.fromBaoCao = false;
        }

        private void toolStripButton_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_datlai_Click(object sender, EventArgs e)
        {
            QuanLyTienLuong_Load(sender, e);
        }

        private void comboBox_maphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void comboBox_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void comboBox_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocDuLieu();
        }

        private void LocDuLieu()
        {
            if (comboBox_thang.SelectedItem == null || comboBox_nam.SelectedItem == null || comboBox_maphong.SelectedItem == null)
                return;

            int thang = int.Parse(comboBox_thang.SelectedItem.ToString());
            int nam = int.Parse(comboBox_nam.SelectedItem.ToString());
            string maPhong = comboBox_maphong.SelectedValue.ToString();
            string query = "SELECT L.MaLuong, L.MaNhanVien, N.HoTen, L.Thang, L.Nam, L.Luong, CASE WHEN Luong > 10000000 THEN Luong * 0.1 ELSE 0 END AS ThueThuNhap FROM Luong L INNER JOIN NhanVien N ON L.MaNhanVien = N.MaNhanVien WHERE L.Thang = @Thang AND L.Nam = @Nam AND N.MaPhong = @MaPhong ORDER BY L.Nam ASC, L.Thang ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Thang", thang);
            command.Parameters.AddWithValue("@Nam", nam);
            command.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            tongluong = TinhTongLuong(data);
            label_tongluong.Text = $"Tổng lương tháng {thang}/{nam}:";
            textBox_tongluong.Text = tongluong.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
            dataGridView_luong.DataSource = data;
        }
        private decimal TinhTongLuong(DataTable dataTable)
        {
            decimal tong = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                tong += Convert.ToDecimal(row["Luong"]);
            }

            return tong;
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            string export_time = DateTime.Now.ToString();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed on this system.");
                return;
            }

            excelApp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 0; i < dataGridView_luong.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1] = dataGridView_luong.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView_luong.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_luong.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataGridView_luong.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // Áp dụng AutoFit chỉ cho các cột từ A đến L
            for (int i = 1; i <= dataGridView_luong.Columns.Count; i++)
            {
                worksheet.Columns[i].AutoFit();
            }

            // Đặt tên cho bảng
            worksheet.Cells[1, 1] = "Bảng lương " + LayTenPhong(comboBox_maphong.SelectedValue.ToString());
            worksheet.Range["A1", "G1"].Font.Size = 24; // Đặt kích thước chữ là 24

            // Lấy thời gian xuất
            int lastRow = worksheet.UsedRange.Rows.Count;
            int lastColumn = worksheet.UsedRange.Columns.Count;
            worksheet.Cells[lastRow + 3, lastColumn + 1] = "Thời gian xuất";
            worksheet.Cells[lastRow + 4, lastColumn + 1] = export_time;

            // Đặt viền cho ô chứa tên bảng
            Microsoft.Office.Interop.Excel.Range tableHeaderRange = worksheet.Range["A1", "G1"];
            tableHeaderRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            tableHeaderRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            // Đặt viền cho các ô của bảng
            Microsoft.Office.Interop.Excel.Range tableDataRange = worksheet.Range["A2", "G" + (dataGridView_luong.Rows.Count + 2)];
            tableDataRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            tableDataRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            // Định dạng bảng
            worksheet.Range["A1", "G2"].Font.Bold = true;
            worksheet.Range["A1", "G1"].Merge();
            worksheet.Range["A1", "G1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        public string LayTenPhong(string maPhong)
        {
            try
            {
                // Kiểm tra xem kết nối đã mở hay chưa
                if (connection.State != ConnectionState.Open)
                {
                    // Nếu chưa mở, mở kết nối
                    connection.Open();
                }

                // Thực hiện truy vấn để lấy tên phòng
                string query = "SELECT TenPhong FROM Phong WHERE MaPhong = @MaPhong";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaPhong", maPhong);

                // Thực hiện đọc dữ liệu từ truy vấn
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Đọc tên phòng từ dữ liệu và trả về
                        return reader["TenPhong"].ToString();
                    }
                    else
                    {
                        // Không tìm thấy dữ liệu
                        Console.WriteLine("Không tìm thấy dữ liệu cho mã phòng {0}.", maPhong);
                        return string.Empty; // hoặc có thể trả về null tùy theo yêu cầu
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ hoặc hiển thị thông báo lỗi
                Console.WriteLine("Lỗi: " + ex.Message);
                return string.Empty; // hoặc có thể trả về null tùy theo yêu cầu
            }
            finally
            {
                // Nếu bạn đã mở kết nối trong quá trình thực hiện, đảm bảo đóng nó
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

