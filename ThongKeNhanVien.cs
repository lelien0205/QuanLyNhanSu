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
    public partial class ThongKeNhanVien : Form
    {
        SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public ThongKeNhanVien()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            string query = "SELECT NV.* FROM NhanVien NV JOIN Phong P ON NV.MaPhong = P.MaPhong WHERE P.MaPhong = @MaPhong ORDER BY RIGHT(NV.HoTen, CHARINDEX(' ', REVERSE(NV.HoTen)) - 1) ASC;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaPhong", comboBox_maphong.SelectedValue.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_nhanvien.DataSource = data;
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
            comboBox_maphong.SelectedIndex = 0;
        }

        private void toolStripButton_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_combobox();
            load_data();
        }

        private void BaoCaoThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        private void comboBox_maphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
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

            for (int i = 0; i < dataGridView_nhanvien.Columns.Count; i++)
            {
                worksheet.Cells[2, i + 1] = dataGridView_nhanvien.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView_nhanvien.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_nhanvien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dataGridView_nhanvien.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            // Áp dụng AutoFit chỉ cho các cột từ A đến L
            for (int i = 1; i <= dataGridView_nhanvien.Columns.Count + 4; i++)
            {
                worksheet.Columns[i].AutoFit();
            }

            // Đặt tên cho bảng
            worksheet.Cells[1, 1] = "Danh sách nhân viên " + LayTenPhong(comboBox_maphong.SelectedValue.ToString());
            worksheet.Range["A1", "L1"].Font.Size = 24; // Đặt kích thước chữ là 24

            // Lấy thời gian xuất
            int lastRow = worksheet.UsedRange.Rows.Count;
            int lastColumn = worksheet.UsedRange.Columns.Count;
            worksheet.Cells[lastRow + 3, lastColumn + 1] = "Thời gian xuất";
            worksheet.Cells[lastRow + 4, lastColumn + 1] = export_time;

            // Đặt viền cho ô chứa tên bảng
            Microsoft.Office.Interop.Excel.Range tableHeaderRange = worksheet.Range["A1", "L1"];
            tableHeaderRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            tableHeaderRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            // Đặt viền cho các ô của bảng
            Microsoft.Office.Interop.Excel.Range tableDataRange = worksheet.Range["A2", "L" + (dataGridView_nhanvien.Rows.Count + 2)];
            tableDataRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            tableDataRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            // Định dạng bảng
            worksheet.Range["A1", "L2"].Font.Bold = true;
            worksheet.Range["A1", "L1"].Merge();
            worksheet.Range["A1", "L1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
