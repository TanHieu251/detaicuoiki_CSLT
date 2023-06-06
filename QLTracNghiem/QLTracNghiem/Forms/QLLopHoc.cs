using Microsoft.SqlServer.Server;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTracNghiem.Forms
{
    public partial class QLLopHoc : Form
    {
        string strConnect = "Data Source=DESKTOP-7EUOQQ8\\BUITANHIEU;Initial Catalog=QLTracNghiem;Integrated Security=True";
        SqlConnection connect=null;
        LopHoc lophoc= null;

        public QLLopHoc()
        {
            InitializeComponent();
        }

        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            if (connect == null)
            {
                connect = new SqlConnection(strConnect);

            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql = "select *from lophoc";
            SqlCommand sqlCmnd = new SqlCommand(sql);
            sqlCmnd.Connection = connect;
            SqlDataReader reader = sqlCmnd.ExecuteReader();
            while (reader.Read())
            {
                char malop = reader.GetString(0)[0];
                string tenlop  = reader.GetString(1);
                string giaovien;
                if (!reader.IsDBNull(2))
                {
                     giaovien = reader.GetString(2);
                }
                else
                {
                     giaovien = string.Empty; // Assign an empty string if the column is NULL
                }
                LopHoc lophoc = new LopHoc (malop, tenlop,giaovien);
                lstLopHoc.Items.Add(lophoc);
                
            }
            reader.Close();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Ma lop khong duoc de trong!");
                txtMaLop.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Ten lop khong duoc de trong!");
                txtTenLop.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenGiaoVien.Text))
            {
                MessageBox.Show("Ten giao vien khong duoc de trong!");
                txtTenGiaoVien.Focus();
                return;
            }
            char malop = char.Parse(txtMaLop.Text);
            string tenlop = txtTenLop.Text;
            string giaovien = txtTenGiaoVien.Text;


            LopHoc lh=new LopHoc(malop, tenlop, giaovien);


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtMaLop.Focus();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {

            if (connect == null)
            {
                connect = new SqlConnection(strConnect);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql = "update lophoc set  tenlop=@tenlop, giaovien=@giaovien where malop=@malop ";
               
            SqlParameter prMaLop = new SqlParameter("@malop", SqlDbType.Char);
            SqlParameter prTenLop = new SqlParameter("@tenlop", SqlDbType.NVarChar);
            SqlParameter prGiaoVien = new SqlParameter("@giaovien", SqlDbType.NVarChar);
            prMaLop.Value = char.Parse(txtMaLop.Text);
            prTenLop.Value = txtTenLop.Text;
            prGiaoVien.Value = txtTenGiaoVien.Text;
            SqlCommand sqlCmd = new SqlCommand(sql);
            sqlCmd.Parameters.Add(prMaLop);
            sqlCmd.Parameters.Add(prTenLop);
            sqlCmd.Parameters.Add(prGiaoVien);

            sqlCmd.Connection = connect;

            int n = sqlCmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Cập nhật thành công!, Vào lại chương trình để cập nhật");
                var item = lstLopHoc.SelectedItems[0];


                LopHoc lh = new LopHoc();


                lstLopHoc.Items.Remove(n);
                
                lh.MaLop = char.Parse(txtMaLop.Text);
                lh.TenLop = txtTenLop.Text;
                lh.Giaovien = txtTenGiaoVien.Text;

                //cap nhat
                lstLopHoc.Items.RemoveAt(n);
                lstLopHoc.Items.Insert(n, lh);

            }
            else
                MessageBox.Show("Cập nhật chưa thành công!");
        
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {

            

            if (lstLopHoc.SelectedItems.Count <= 0)
                return;
            var selectedItem = lstLopHoc.SelectedItem;
            //xoa du lieu duoi database
            if (connect == null)
            {
                connect = new SqlConnection(strConnect);
            }
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql = "delete from lophoc where malop=@malop";
            SqlParameter prMaLop = new SqlParameter("@malop", SqlDbType.Char);
           if(selectedItem is char) 
            {
                prMaLop.Value = selectedItem.ToString();
            }
            else if (selectedItem is LopHoc)
            {
                var LopHoc = (LopHoc)selectedItem;
                prMaLop.Value = LopHoc.MaLop;
            }
            else
            {
                MessageBox.Show("Kiểu chọn không hợp lệ!", "Lỗi");
                return;
            }
            SqlCommand sqlCmd = new SqlCommand(sql);

            sqlCmd.Parameters.Add(prMaLop);
            sqlCmd.Connection = connect;

            int n = sqlCmd.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Đã xóa thành công! Vào lại chương trình để cập nhật", "Thông báo");

                //cap nhat trong dsDauSach cua loai sach dang chon
                LopHoc lh = new LopHoc();
               
                //cap nhat tren listview
                lstLopHoc.Items.Remove(n);
                lstLopHoc.Items.Insert(n, lh);
            }
            else
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo");




        
            
        }

        private void btnTieptucMH_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtTenGiaoVien.Text = "";
            txtMaLop.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
