using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLTracNghiem.QLTN_Class
{
    internal class LopHoc
    {
        private char malop;
        private string tenlop;
        private string giaovien;

        public char MaLop { get => malop; set => malop = value; }
        public string TenLop { get => tenlop; set => tenlop = value; }
        public string Giaovien { get => giaovien; set => giaovien = value; }

        public LopHoc()
        {
            MaLop = (char)0;
            TenLop = "Unknow";
            Giaovien = "Unknow";
        }
        public LopHoc(char malop, string tenlop,string giaovien)
        {
            MaLop = malop;
            TenLop = tenlop;
            Giaovien = giaovien;
        }

        public LopHoc(string giaovien)
        {
            this.giaovien = giaovien;
        }

        public override string ToString()
        {
            return tenlop;
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

    
