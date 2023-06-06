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
    public partial class QLHocVien : Form
    {
        public QLHocVien()
        {
            InitializeComponent();
        }

        private void btnThoatHV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiepTucHV_Click(object sender, EventArgs e)
        {
            txtMaHV.Text = "";
            txtDiaChiHV.Text = "";
            txtSDTHV.Text = "";
            txtTenHV.Text = "";
            txtMaHV.Focus();
        }
    }
}
