using QLTracNghiem.QLTN_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Forms
{
    public partial class QLHocVien : Form
    {
        string strConnect = "Data Source=DESKTOP-7EUOQQ8\\BUITANHIEU;Initial Catalog=QLTracNghiem;Integrated Security=True";
        SqlConnection connect = null;
        HocVien hopvien = null;
        LopHoc lophoc=null;

        public QLHocVien()
        {
            InitializeComponent();
            lsvDSHV.Columns.Add("Mã học viên", 0);
            lsvDSHV.Columns.Add("Họ Tên", 200);
            lsvDSHV.Columns.Add("Địa Chỉ", 0);
            lsvDSHV.Columns.Add("Số Điện Thoại", 0);
            lsvDSHV.Columns.Add("Giới tính", 50);
            lsvDSHV.Columns.Add("Tên lớp", 70);
            lsvDSHV.View = View.Details;
            lsvDSHV.FullRowSelect = true;
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

        private void QLHocVien_Load(object sender, EventArgs e)
        {
            if (connect == null)
            {
                connect = new SqlConnection(strConnect);

            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql = "select  malop, tenlop, giaovien from lophoc";
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Connection = connect;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                char malop = reader.GetString(0)[0];
                string tenlop = reader.GetString(1);
                string giaovien;
                if (!reader.IsDBNull(2))
                {
                    giaovien = reader.GetString(2);
                }
                else
                {
                    giaovien = string.Empty; // Assign an empty string if the column is NULL
                }
                LopHoc lopHoc = new LopHoc(malop,tenlop,giaovien);
                cmbTenLop_HocVien.Items.Add(lopHoc);
                
            }
            reader.Close();
        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            char mahv = char.Parse(txtMaHV.Text);
            string hoten = txtTenHV.Text;
            string gioitinh = txtGioiTinh.Text;
            char sodt=char.Parse(txtSDTHV.Text);
            lophoc = (LopHoc)cmbTenLop_HocVien.SelectedItem;



            HocVien hocvien=new HocVien(mahv,hoten,gioitinh,sodt,tenlop,diachi);


            //them vao database
            if (connect == null)
            {   //neu chua ket noi thi ket noi
                connect = new SqlConnection(strConnect);

            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open(); //neu dong thi mo
            }
            string sql = "insert into lophoc values (@malop , @tenlop,@giaovien)";

            SqlCommand sqlCmd = new SqlCommand(sql);

            //khai bao cac tham so
            SqlParameter prMalop = new SqlParameter("@malop", SqlDbType.Char);
            prMalop.Value = malop;
            SqlParameter prTenlop = new SqlParameter("@tenlop", SqlDbType.NVarChar);
            prTenlop.Value = tenlop;
            SqlParameter prGiaoVien = new SqlParameter("@giaovien", SqlDbType.NVarChar);
            prGiaoVien.Value = giaovien;


            //gan tham so cho sqlCmd
            sqlCmd.Parameters.Add(prTenlop);
            sqlCmd.Parameters.Add(prMalop);
            sqlCmd.Parameters.Add(prGiaoVien);

            sqlCmd.Connection = connect;
            int n = sqlCmd.ExecuteNonQuery();
            if (n > 0)
            {
                //them vao listbox
                lstLopHoc.Items.Add(lh);

            }
            else
            {
                MessageBox.Show("Them that bai !!");
            }

        }
    }
}
