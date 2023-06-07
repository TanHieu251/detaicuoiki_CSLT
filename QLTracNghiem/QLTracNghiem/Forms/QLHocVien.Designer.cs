namespace QLTracNghiem.Forms
{
    partial class QLHocVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDSHV = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTenLop_HocVien = new System.Windows.Forms.ComboBox();
            this.btnThoatHV = new System.Windows.Forms.Button();
            this.btnTiepTucHV = new System.Windows.Forms.Button();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDTHV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChiHV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HỌC VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 613);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDSHV);
            this.groupBox2.Location = new System.Drawing.Point(685, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 572);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Học Viên";
            // 
            // lsvDSHV
            // 
            this.lsvDSHV.HideSelection = false;
            this.lsvDSHV.Location = new System.Drawing.Point(6, 20);
            this.lsvDSHV.Name = "lsvDSHV";
            this.lsvDSHV.Size = new System.Drawing.Size(641, 527);
            this.lsvDSHV.TabIndex = 0;
            this.lsvDSHV.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTenLop_HocVien);
            this.groupBox1.Controls.Add(this.btnThoatHV);
            this.groupBox1.Controls.Add(this.btnTiepTucHV);
            this.groupBox1.Controls.Add(this.btnXoaHV);
            this.groupBox1.Controls.Add(this.btnSuaHV);
            this.groupBox1.Controls.Add(this.btnThemHV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtSDTHV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChiHV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenHV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaHV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 584);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Học Viên";
            // 
            // cmbTenLop_HocVien
            // 
            this.cmbTenLop_HocVien.FormattingEnabled = true;
            this.cmbTenLop_HocVien.Location = new System.Drawing.Point(147, 406);
            this.cmbTenLop_HocVien.Name = "cmbTenLop_HocVien";
            this.cmbTenLop_HocVien.Size = new System.Drawing.Size(244, 28);
            this.cmbTenLop_HocVien.TabIndex = 4;
            // 
            // btnThoatHV
            // 
            this.btnThoatHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatHV.Location = new System.Drawing.Point(451, 406);
            this.btnThoatHV.Name = "btnThoatHV";
            this.btnThoatHV.Size = new System.Drawing.Size(129, 61);
            this.btnThoatHV.TabIndex = 3;
            this.btnThoatHV.Text = "Thoát";
            this.btnThoatHV.UseVisualStyleBackColor = true;
            this.btnThoatHV.Click += new System.EventHandler(this.btnThoatHV_Click);
            // 
            // btnTiepTucHV
            // 
            this.btnTiepTucHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTucHV.Location = new System.Drawing.Point(451, 320);
            this.btnTiepTucHV.Name = "btnTiepTucHV";
            this.btnTiepTucHV.Size = new System.Drawing.Size(129, 61);
            this.btnTiepTucHV.TabIndex = 3;
            this.btnTiepTucHV.Text = "Tiếp Tục";
            this.btnTiepTucHV.UseVisualStyleBackColor = true;
            this.btnTiepTucHV.Click += new System.EventHandler(this.btnTiepTucHV_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHV.Location = new System.Drawing.Point(451, 232);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(129, 61);
            this.btnXoaHV.TabIndex = 3;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.UseVisualStyleBackColor = true;
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHV.Location = new System.Drawing.Point(451, 151);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(129, 61);
            this.btnSuaHV.TabIndex = 3;
            this.btnSuaHV.Text = "Sửa";
            this.btnSuaHV.UseVisualStyleBackColor = true;
            // 
            // btnThemHV
            // 
            this.btnThemHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHV.Location = new System.Drawing.Point(451, 71);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(129, 61);
            this.btnThemHV.TabIndex = 3;
            this.btnThemHV.Text = "Thêm";
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính:";
            // 
            // txtSDTHV
            // 
            this.txtSDTHV.Location = new System.Drawing.Point(147, 270);
            this.txtSDTHV.Multiline = true;
            this.txtSDTHV.Name = "txtSDTHV";
            this.txtSDTHV.Size = new System.Drawing.Size(244, 28);
            this.txtSDTHV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtDiaChiHV
            // 
            this.txtDiaChiHV.Location = new System.Drawing.Point(147, 207);
            this.txtDiaChiHV.Multiline = true;
            this.txtDiaChiHV.Name = "txtDiaChiHV";
            this.txtDiaChiHV.Size = new System.Drawing.Size(244, 28);
            this.txtDiaChiHV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtTenHV
            // 
            this.txtTenHV.Location = new System.Drawing.Point(147, 151);
            this.txtTenHV.Multiline = true;
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(244, 28);
            this.txtTenHV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên:";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(147, 88);
            this.txtMaHV.Multiline = true;
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(244, 28);
            this.txtMaHV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Học Viên:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(147, 337);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(244, 28);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // QLHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "QLHocVien";
            this.Text = "QLHocVien";
            this.Load += new System.EventHandler(this.QLHocVien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvDSHV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTHV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChiHV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Button btnThoatHV;
        private System.Windows.Forms.Button btnTiepTucHV;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.ComboBox cmbTenLop_HocVien;
        private System.Windows.Forms.TextBox txtGioiTinh;
    }
}