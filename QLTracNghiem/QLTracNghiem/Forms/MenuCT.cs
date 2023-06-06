using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Forms
{
    public partial class MenuCT : Form
    {
        public MenuCT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLHocVien qlhocvien=new QLHocVien();
            qlhocvien.ShowDialog();
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            QLLopHoc qlylophoc=new QLLopHoc();
            qlylophoc.ShowDialog();
        }

        private void btnQLMon_Click(object sender, EventArgs e)
        {
            QLMon qlymon=new QLMon();
            qlymon.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLCauHoi_Click(object sender, EventArgs e)
        {
            QLYCauHoi qlycauhoi=new QLYCauHoi();
            qlycauhoi.ShowDialog();
        }

        private void btnTaoDeThi_Click(object sender, EventArgs e)
        {
            FTaoDeThi ftaodethi=new FTaoDeThi();
            ftaodethi.ShowDialog();
        }

        private void btnThiThu_Click(object sender, EventArgs e)
        {
            FThiThu fthithu=new FThiThu();
            fthithu.ShowDialog();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            FXemKQ fxemkq=new FXemKQ();
            fxemkq.ShowDialog();
        }
    }
}
