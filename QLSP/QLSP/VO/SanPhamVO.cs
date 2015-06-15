using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSP.VO
{
    class SanPhamVO
    {
        private string tensanpham;

        public string Tensanpham
        {
            get { return tensanpham; }
            set { tensanpham = value; }
        }
        private string tendanhmuc;

        public string Tendanhmuc
        {
            get { return tendanhmuc; }
            set { tendanhmuc = value; }
        }
        private string tenthuonghieu;

        public string Tenthuonghieu
        {
            get { return tenthuonghieu; }
            set { tenthuonghieu = value; }
        }
        private int si10;

        public int Si10
        {
            get { return si10; }
            set { si10 = value; }
        }
        private int si20;

        public int Si20
        {
            get { return si20; }
            set { si20 = value; }
        }
        private int le;

        public int Le
        {
            get { return le; }
            set { le = value; }
        }
    }
}
