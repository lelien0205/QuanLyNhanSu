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
    public partial class BangChamCong : Form
    {
        public SqlConnection connection = new SqlConnection(GenericClass.connectionString);
        public string MaNhanVien;
        public string HoTen = PhienDangNhap.HoTen;
        public bool LaNhanVien = PhienDangNhap.LaNhanVien;
        public BangChamCong()
        {
            InitializeComponent();
            MaNhanVien = PhienDangNhap.MaNhanVien;
        }
        private void load_data()
        {
            string query = "SELECT C.MaChamCong, C.MaNhanVien, N.HoTen, C.Thang, C.Nam, C.SoNgayLamViec FROM ChamCong C INNER JOIN NhanVien N ON C.MaNhanVien = N.MaNhanVien WHERE N.MaNhanVien = @MaNhanVien ORDER BY C.Nam ASC, C.Thang ASC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView_bangchamcong.DataSource = data;
        }

        private void BangChamCong_Load(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            load_data();
        }

        private void BangChamCong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}
