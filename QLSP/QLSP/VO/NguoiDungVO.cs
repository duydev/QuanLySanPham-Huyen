using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.VO
{
    class NguoiDungVO
    {
        private string tendangnhap;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        private string tendaydu;


        public string Tendaydu
        {
            get { return tendaydu; }
            set { tendaydu = value; }
        }
        private string matkhau;


        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        private int ngaytao;

        public int Ngaytao
        {
            get { return ngaytao; }
            set { ngaytao = value; }
        }

    }
}
