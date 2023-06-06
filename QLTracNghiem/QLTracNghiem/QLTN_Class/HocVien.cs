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
        private string hoten;
        private string diachi;
        private string gioitinh;
        private char sodt;
        private string tenlop;

        private LopHoc lophoc;

        public char Mahv { get => mahv; set => mahv = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public char Sodt { get => sodt; set => sodt = value; }
        public string TenLop { get => tenlop; set => tenlop = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        public HocVien()
        {
            Mahv = (char)0;
            HoTen = "Unknow";
            Gioitinh = "unknow";
            Sodt = (char)0;
            tenlop = "unknow";
            lophoc = null;
            diachi=null;
        }

        public HocVien(char mahv, string holot,  string gioitinh, char sodt, string tenlop,string diachi)
        {
            Mahv = mahv;
            HoTen = holot;
            Diachi = diachi;
            Gioitinh = gioitinh;
            Sodt = sodt;
            TenLop = tenlop;
        }
    }

}
