using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.QLTN_Class
{
    internal class HocVien
    {
        private char mahv;
        private string holot;
        private string ten;
        private string gioitinh;
        private char sodt;
        private char malop;

        private LopHoc lophoc;

        public char Mahv { get => mahv; set => mahv = value; }
        public string Holot { get => holot; set => holot = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public char Sodt { get => sodt; set => sodt = value; }
        public char Malop { get => malop; set => malop = value; }

        public HocVien()
        {
            Mahv = (char)0;
            Holot = "Unknow";
            Ten = "unknow";
            Gioitinh = "unknow";
            Sodt = (char)0;
            malop = (char)0;
            lophoc = null;
        }

        public HocVien(char mahv, string holot, string ten, string gioitinh, char sodt, char malop)
        {
            Mahv = mahv;
            Holot = holot;
            Ten = ten;
            Gioitinh = gioitinh;
            Sodt = sodt;
            Malop = malop;
        }
    }

}
