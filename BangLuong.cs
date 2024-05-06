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
    public partial class BangLuong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public string MaNhanVien;
        public string HoTen = PhienDangNhap.HoTen;
        public bool LaNhanVien = PhienDangNhap.LaNhanVien;
        public BangLuong()
        {
            InitializeComponent();
            MaNhanVien = PhienDangNhap.MaNhanVien;
        }
        private void load_data()
        {
            string query = "SELECT L.MaLuong, L.MaNhanVien, N.HoTen, L.Thang, L.Nam, L.Luong, CASE WHEN Luong > 10000000 THEN Luong * 0.1 ELSE 0 END AS ThueThuNhap FROM Luong L INNER JOIN NhanVien N ON L.MaNhanVien = N.MaNhanVien WHERE N.MaNhanVien = @MaNhanVien ORDER BY L.Nam ASC, L.Thang ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_bangluong.DataSource = data;
        }

        private void BangLuong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void BangLuong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}
