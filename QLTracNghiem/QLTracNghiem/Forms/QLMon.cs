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
    public partial class QLMon : Form
    {
        public QLMon()
        {
            InitializeComponent();
        }

        private void QLMon_Load(object sender, EventArgs e)
        {

        }
       

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenChuongMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTieptucChuongMH_Click_1(object sender, EventArgs e)
        {
            txtMaChuongMH.Text = "";
            txtTenChuongMH.Text = "";
            txtMaChuongMH.Focus();
        }

        private void btnSuaChuongMH_Click(object sender, EventArgs e)
        {

        }
    }
}
