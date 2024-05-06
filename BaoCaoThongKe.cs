using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTGiangDQHuanLTPLien_LTNET
{
    public partial class BaoCaoThongKe : Form
    {
        private const int WM_NCACTIVATE = 0x0086;
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void button_nhanvien_Click(object sender, EventArgs e)
        {
            ThongKeNhanVien form = new ThongKeNhanVien();
            this.Close();
            form.ShowDialog();
        }

        private void button_luong_Click(object sender, EventArgs e)
        {
            QuanLyTienLuong form = new QuanLyTienLuong();
            GenericClass.fromBaoCao = true;
            this.Close();
            form.ShowDialog();
        }

        
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCACTIVATE && m.WParam.ToInt32() == 0)
            {
                Close();
            }
        }
    }
}
