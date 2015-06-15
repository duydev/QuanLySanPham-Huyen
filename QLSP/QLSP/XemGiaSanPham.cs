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
    public partial class XemGiaSanPham : Form
    {

        private SanPhamBUS sanphamBUS = new SanPhamBUS();

        public XemGiaSanPham()
        {
            InitializeComponent();
            capnhatListBox();
        }

        private void capnhatListBox()
        {
            lbxDanhMuc.Items.Clear();
            DataTable dtDanhMuc = sanphamBUS.layDanhMuc();
            for (int i = 0; i < dtDanhMuc.Rows.Count; i++)
            {
                lbxDanhMuc.Items.Add(dtDanhMuc.Rows[i][0].ToString());
                //lbxDanhMuc.SetSelected(i, true);
            }

            lbxThuongHieu.Items.Clear();
            DataTable dtThuongHieu = sanphamBUS.layThuongHieu();
            for (int i = 0; i < dtThuongHieu.Rows.Count; i++)
            {
                lbxThuongHieu.Items.Add(dtThuongHieu.Rows[i][0].ToString());
                //lbxThuongHieu.SetSelected(i, true);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string tensp = txtTenSanPham.Text;
                List<string> danhmuc = new List<string>();
                List<string> thuonghieu = new List<string>();
                foreach(var s in lbxDanhMuc.SelectedItems)
                {
                    danhmuc.Add(s.ToString());
                }
                foreach (var s in lbxThuongHieu.SelectedItems)
                {
                    thuonghieu.Add(s.ToString());
                }
                DataTable ketqua = sanphamBUS.timSanPham(tensp, danhmuc, thuonghieu);
                if (ketqua.Rows.Count > 0)
                {
                    dataGridView1.DataSource = ketqua;
                    //MessageBox.Show("Tìm được " + ketqua.Rows.Count + " sản phẩm.");
                    toolStripStatusLabel1.Text = "Tìm được " + ketqua.Rows.Count + " sản phẩm.";
                }
                else
                {
                    //MessageBox.Show("Không tìm được sản phẩm nào.");
                    toolStripStatusLabel1.Text = "Không tìm được sản phẩm nào.";
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn. Vui lòng thử lại.");
            }

        }

        private void btnXoaKetQua_Click(object sender, EventArgs e)
        {
            while(dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows.RemoveAt(i);
            }
            toolStripStatusLabel1.Text = "Đã xóa tất cả kết quả tìm kiếm.";
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
           
        }

        private void nhậpXuấtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.ShowDialog();
            frm.Hide();
            capnhatListBox();
        }

        private void vềTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeTacGia frm = new VeTacGia();
            frm.ShowDialog();
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.FileName = "SanPham-" + DateTime.Now.ToString("dd-MM-yyyy h-mm-ss");
                saveFileDialog1.DefaultExt = "duy";
                saveFileDialog1.Filter = "File Sao Lưu (*.duy)|*.duy";
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    NhapXuat nhapxuat = new NhapXuat();
                    nhapxuat.SaoLuu(filename);
                    toolStripStatusLabel1.Text = "Sao lưu thành công tại đường dẫn: " + saveFileDialog1.FileName;
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Sao lưu gặp lỗi.";
            }
            
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "File Sao Lưu (*.duy)|*.duy";
            openFileDialog1.DefaultExt = "duy";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                NhapXuat nhapxuat = new NhapXuat();
                nhapxuat.PhucHoi(filename);
                capnhatListBox();
                toolStripStatusLabel1.Text = "Phục hồi thành công.";
            }
        }

        private void XemGiaSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
