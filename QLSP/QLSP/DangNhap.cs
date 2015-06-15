using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSP.BUS;
using QLSP.VO;

namespace QLSP
{
    public partial class DangNhap : Form
    {
        NguoiDungBUS nguoidungBUS = new NguoiDungBUS();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            if(nguoidungBUS.DangNhap(tendangnhap,matkhau))
            {
                QuanLySanPham frm = new QuanLySanPham();
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu.");
            }
        }
    }
}
