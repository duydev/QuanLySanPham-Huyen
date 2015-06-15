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
    public partial class QuanLySanPham : Form
    {
        private SanPhamBUS sanphamBUS = new SanPhamBUS();
        
        public QuanLySanPham()
        {
            InitializeComponent();
            capnhatBang();
        }

        private void xoaForm()
        {
            txtTenSanPham.Clear();
            txtDanhMuc.Clear();
            txtThuongHieu.Clear();
            txtSi10.Clear();
            txtSi20.Clear();
            txtLe.Clear();
        }

        private void capnhatBang()
        {
            dataGridView1.DataSource = sanphamBUS.laySanPham();
            xoaForm();
            capnhatAutoComplete();
        }

        private void capnhatAutoComplete()
        {
            AutoCompleteStringCollection danhmuc = new AutoCompleteStringCollection();
            DataTable dtDanhMuc = sanphamBUS.layDanhMuc();
            foreach(DataRow r in dtDanhMuc.Rows)
            {
                danhmuc.Add(r[0].ToString());
            }
            txtDanhMuc.AutoCompleteCustomSource = danhmuc;
            AutoCompleteStringCollection thuonghieu = new AutoCompleteStringCollection();
            DataTable dtThuongHieu = sanphamBUS.layThuongHieu();
            foreach (DataRow r in dtThuongHieu.Rows)
            {
                thuonghieu.Add(r[0].ToString());
            }
            txtThuongHieu.AutoCompleteCustomSource = thuonghieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm.");
                return;
            }
            if (txtDanhMuc.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập danh mục sản phẩm.");
                return;
            }
            if (txtDanhMuc.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập thương hiệu sản phẩm.");
                return;
            }
            try
            {
                SanPhamVO sp = new SanPhamVO();
                sp.Tensanpham = txtTenSanPham.Text;
                sp.Tenthuonghieu = txtThuongHieu.Text;
                sp.Tendanhmuc = txtDanhMuc.Text;
                sp.Si10 = getTien(txtSi10.Text);
                sp.Si20 = getTien(txtSi20.Text);
                sp.Le = getTien(txtLe.Text);
                sanphamBUS.themSanPham(sp);
                //MessageBox.Show("Thêm thành công.");
                toolStripStatusLabel1.Text = "Thêm thành công.";
                capnhatBang();
            }
            catch(FormatException e1)
            {
                MessageBox.Show("Vui lòng kiểm tra số tiền nhập vào.");
            }
            catch(Exception e2)
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tensp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                sanphamBUS.xoaSanPham(tensp);
                toolStripStatusLabel1.Text = "Xóa thành công.";
                capnhatBang();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1.SelectedRows[0];
            txtTenSanPham.Text = selected.Cells["colTenSP"].Value.ToString();
            txtDanhMuc.Text = selected.Cells["colTenDM"].Value.ToString();
            txtThuongHieu.Text = selected.Cells["colTenTH"].Value.ToString();
            txtSi10.Text = setTien(int.Parse(selected.Cells["colSi10"].Value.ToString()));
            txtSi20.Text = setTien(int.Parse(selected.Cells["colSi20"].Value.ToString()));
            txtLe.Text = setTien(int.Parse(selected.Cells["colLe"].Value.ToString()));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.TextLength == 0)
                return;
            try
            {
            string tenspcu = dataGridView1.SelectedRows[0].Cells["colTenSP"].Value.ToString();
            SanPhamVO sp = new SanPhamVO();
            sp.Tensanpham = txtTenSanPham.Text;
            sp.Tenthuonghieu = txtThuongHieu.Text;
            sp.Tendanhmuc = txtDanhMuc.Text;
            sp.Si10 = getTien(txtSi10.Text);
            sp.Si20 = getTien(txtSi20.Text);
            sp.Le = getTien(txtLe.Text);

                sanphamBUS.suaSanPham(tenspcu, sp);
                toolStripStatusLabel1.Text = "Sửa thành công.";
                capnhatBang();
            }
            catch (FormatException e1)
            {
                MessageBox.Show("Vui lòng kiểm tra số tiền nhập vào.");
            }
            catch
            {
               
            }
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            xoaForm();
        }

        private bool kiemtraSoTien(string so)
        {
            int sotien;
            if (!int.TryParse(so, out sotien))
                return false;
            if (sotien < 0)
                return false;
            return true;
        }

        private int getTien(string sotien)
        {
            string s = sotien.Replace(",","").Replace(" đồng", "");
            int n;
            if(int.TryParse(s,out n))
            {
                return n;
            }
            return 0;
        }

        private string setTien(int sotien)
        {
            string tien = sotien.ToString();
            string res = "";
            int i = tien.Length - 1;
            int dem = 0;
            while(i >= 0)
            {
                if(dem == 3)
                {
                    res = "," + res;
                    dem = 0;
                }
                res = tien[i] + res;
                dem++;
                i--;
            }
            return res + " đồng";
        }

        private void txtSi10_Leave(object sender, EventArgs e)
        {
            int sotien;
            if(int.TryParse(txtSi10.Text, out sotien))
            {
                txtSi10.Text = setTien(sotien);
            }
        }

        private void txtSi10_MouseClick(object sender, MouseEventArgs e)
        {
            txtSi10.Text = getTien(txtSi10.Text).ToString();
        }

        private void txtSi20_Leave(object sender, EventArgs e)
        {
            int sotien;
            if (int.TryParse(txtSi20.Text, out sotien))
            {
                txtSi20.Text = setTien(sotien);
            }
        }

        private void txtSi20_MouseClick(object sender, MouseEventArgs e)
        {
            txtSi20.Text = getTien(txtSi20.Text).ToString();
        }

       

        private void txtLe_Leave(object sender, EventArgs e)
        {
            int sotien;
            if (int.TryParse(txtLe.Text, out sotien))
            {
                txtLe.Text = setTien(sotien);
            }
        }

        private void txtLe_MouseClick(object sender, MouseEventArgs e)
        {
            txtLe.Text = getTien(txtLe.Text).ToString();
        }
    }
}
