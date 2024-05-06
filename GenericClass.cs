using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public static class GenericClass
    {
        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlynhansu;Integrated Security=True";
        public static string selectPhong = "SELECT * FROM Phong ORDER BY TenPhong ASC";
        public static string selectChucVu = "SELECT * FROM ChucVu ORDER BY HeSoPhuCap ASC";
        public static string selectNhanVien = "SELECT * FROM NhanVien ORDER BY RIGHT(HoTen, CHARINDEX(' ', REVERSE(HoTen)) - 1) ASC;";
        public static bool fromBaoCao;
        public static bool isLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string laymaluong()
        {
            string maLuong = "";
            using (SqlConnection connection1 = new SqlConnection(GenericClass.connectionString))
            {
                connection1.Open();

                string query = "SELECT MaLuong FROM Luong WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang AND Nam = @Nam";

                using (SqlCommand command = new SqlCommand(query, connection1))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", ThongTinChamCong.MaNhanVien);
                    command.Parameters.AddWithValue("@Thang", ThongTinChamCong.Thang);
                    command.Parameters.AddWithValue("@Nam", ThongTinChamCong.Nam);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        maLuong = result.ToString();
                    }
                    else
                    {
                        // Xử lý trường hợp không tìm thấy dữ liệu
                    }
                }
                connection1.Close();
            }
            return maLuong;
        }

        public static ArrayList CreateArrayList(int startPoint, int endPoint)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = startPoint; i <= endPoint; i++)
            {
                arrayList.Add(i);
            }
            arrayList.Reverse();
            return arrayList;
        }

        // Hàm tạo các loại mã ngẫu nhiên
        public static string GenerateRandomString(string prefix)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            string randomString = $"{prefix.ToUpper()}{randomNumber}";
            return randomString;
        }

        // Hàm vẽ hình vuông bo góc cho panel
        public static void panel_background(object sender, PaintEventArgs e, int cornerRadius, int alpha, int red, int green, int blue)
        {
            Panel panel = (Panel)sender;
            Color backgroundColor = Color.FromArgb(alpha, red, green, blue);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}
