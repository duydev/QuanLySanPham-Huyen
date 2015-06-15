using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSP.DAO;
using QLSP.VO;
using System.Data;


namespace QLSP.BUS
{
    class SanPhamBUS
    {
        private SanPhamDAO sanphamDAO;

        public SanPhamBUS()
        {
            sanphamDAO = new SanPhamDAO();
        }

        public DataTable laySanPham()
        {
            return sanphamDAO.laySanPham();
        }

        public DataTable layDanhMuc()
        {
            return sanphamDAO.layDanhMuc();
        }

        public DataTable layThuongHieu()
        {
            return sanphamDAO.layThuongHieu();
        }


        public DataTable timSanPham(string tensp, List<string> danhmuc, List<string> thuonghieu)
        {
            string s1 = "", s2 = "";
            if (danhmuc.Count > 0)
            {
                for (int i = 0; i < danhmuc.Count - 1; i++ )
                    s1 += "'" + danhmuc[i] + "',";
                s1 += "'" + danhmuc[danhmuc.Count-1] + "'";
            }
            if (thuonghieu.Count > 0)
            {
                for (int i = 0; i < thuonghieu.Count - 1; i++)
                    s2 += "'" + thuonghieu[i] + "',";
                s2 += "'" + thuonghieu[thuonghieu.Count - 1] + "'";              
            }
            return sanphamDAO.timSanPham(tensp, s1, s2);
        }

        public bool themSanPham(SanPhamVO sp)
        {
            return sanphamDAO.themSanPham(sp.Tensanpham, sp.Tendanhmuc, sp.Tenthuonghieu, sp.Si10, sp.Si20, sp.Le);
        }

        public bool xoaSanPham(string tensp)
        {
            return sanphamDAO.xoaSanPham(tensp);
        }

        public bool suaSanPham(string tenspcu, SanPhamVO sp)
        {
            return sanphamDAO.suaSanPham(tenspcu,sp.Tensanpham, sp.Tendanhmuc, sp.Tenthuonghieu, sp.Si10, sp.Si20, sp.Le);
        }

     
    }
}
