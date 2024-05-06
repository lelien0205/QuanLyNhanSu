using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public static class PhienDangNhap
    {
        public static string MaNhanVien
        {
            get; set;
        }
        public static string HoTen
        {
            get; set;
        }
        public static bool LaNhanVien
        {
            get; set;
        }
        public static void XoaPhienDangNhap()
        {
            MaNhanVien = null;
            HoTen = null;
            LaNhanVien = false;
        }
    }
}
