using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLSP.DAO;
using QLSP.VO;
using System.Data;

namespace QLSP.BUS
{
    class NguoiDungBUS
    {
        NguoiDungDAO nguoidungDAO;

        public NguoiDungBUS()
        {
            nguoidungDAO = new NguoiDungDAO();
        }

        public NguoiDungVO layNguoiDung(string tendangnhap)
        {
            DataTable dt = nguoidungDAO.layNguoiDung(tendangnhap);
            if(dt == null || dt.Rows.Count == 0)
                return null;
            NguoiDungVO user = new NguoiDungVO();
            user.Tendangnhap = dt.Rows[0]["TenDangNhap"].ToString();
            user.Matkhau = dt.Rows[0]["MatKhau"].ToString();
            user.Tendaydu = dt.Rows[0]["TenDayDu"].ToString();
            return user;
        }

        public bool DangNhap(string tendangnhap, string matkhau)
        {
            NguoiDungVO user = layNguoiDung(tendangnhap);
            if(user == null)
                return false;
            if (matkhau != user.Matkhau)
                return false;
            return true;
        }

    }
}
