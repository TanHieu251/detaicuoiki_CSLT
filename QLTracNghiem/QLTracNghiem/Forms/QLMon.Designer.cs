namespace QLTracNghiem.Forms
{
    partial class QLMon
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvChuongMH = new System.Windows.Forms.ListView();
            this.btnXoaChuongMH = new System.Windows.Forms.Button();
            this.txtTenChuongMH = new System.Windows.Forms.TextBox();
            this.txtMaChuongMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTieptucChuongMH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaChuongMH = new System.Windows.Forms.Button();
            this.btnThemChuongMH = new System.Windows.Forms.Button();
            this.cmbLop_Mon = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTieptucMH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Môn Học:";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemMH.Location = new System.Drawing.Point(482, 52);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(117, 55);
            this.btnThemMH.TabIndex = 18;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvChuongMH);
            this.groupBox2.Controls.Add(this.btnXoaChuongMH);
            this.groupBox2.Controls.Add(this.txtTenChuongMH);
            this.groupBox2.Controls.Add(this.txtMaChuongMH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnTieptucChuongMH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSuaChuongMH);
            this.groupBox2.Controls.Add(this.btnThemChuongMH);
            this.groupBox2.Location = new System.Drawing.Point(646, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 544);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chương";
            // 
            // lsvChuongMH
            // 
            this.lsvChuongMH.HideSelection = false;
            this.lsvChuongMH.Location = new System.Drawing.Point(15, 243);
            this.lsvChuongMH.Name = "lsvChuongMH";
            this.lsvChuongMH.Size = new System.Drawing.Size(528, 285);
            this.lsvChuongMH.TabIndex = 19;
            this.lsvChuongMH.UseCompatibleStateImageBehavior = false;
            // 
            // btnXoaChuongMH
            // 
            this.btnXoaChuongMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuongMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaChuongMH.Location = new System.Drawing.Point(135, 166);
            this.btnXoaChuongMH.Name = "btnXoaChuongMH";
            this.btnXoaChuongMH.Size = new System.Drawing.Size(102, 55);
            this.btnXoaChuongMH.TabIndex = 14;
            this.btnXoaChuongMH.Text = "Xóa";
            this.btnXoaChuongMH.UseVisualStyleBackColor = true;
            // 
            // txtTenChuongMH
            // 
            this.txtTenChuongMH.Location = new System.Drawing.Point(191, 80);
            this.txtTenChuongMH.Multiline = true;
            this.txtTenChuongMH.Name = "txtTenChuongMH";
            this.txtTenChuongMH.Size = new System.Drawing.Size(251, 36);
            this.txtTenChuongMH.TabIndex = 12;
            this.txtTenChuongMH.TextChanged += new System.EventHandler(this.txtTenChuongMH_TextChanged);
            // 
            // txtMaChuongMH
            // 
            this.txtMaChuongMH.Location = new System.Drawing.Point(191, 25);
            this.txtMaChuongMH.Multiline = true;
            this.txtMaChuongMH.Name = "txtMaChuongMH";
            this.txtMaChuongMH.Size = new System.Drawing.Size(251, 36);
            this.txtMaChuongMH.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Chương:";
            // 
            // btnTieptucChuongMH
            // 
            this.btnTieptucChuongMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieptucChuongMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTieptucChuongMH.Location = new System.Drawing.Point(400, 166);
            this.btnTieptucChuongMH.Name = "btnTieptucChuongMH";
            this.btnTieptucChuongMH.Size = new System.Drawing.Size(143, 55);
            this.btnTieptucChuongMH.TabIndex = 16;
            this.btnTieptucChuongMH.Text = "Tiếp Tục";
            this.btnTieptucChuongMH.UseVisualStyleBackColor = true;
            this.btnTieptucChuongMH.Click += new System.EventHandler(this.btnTieptucChuongMH_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Chương:";
            // 
            // btnSuaChuongMH
            // 
            this.btnSuaChuongMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChuongMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaChuongMH.Location = new System.Drawing.Point(269, 166);
            this.btnSuaChuongMH.Name = "btnSuaChuongMH";
            this.btnSuaChuongMH.Size = new System.Drawing.Size(102, 55);
            this.btnSuaChuongMH.TabIndex = 17;
            this.btnSuaChuongMH.Text = "Sửa";
            this.btnSuaChuongMH.UseVisualStyleBackColor = true;
            this.btnSuaChuongMH.Click += new System.EventHandler(this.btnSuaChuongMH_Click);
            // 
            // btnThemChuongMH
            // 
            this.btnThemChuongMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChuongMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemChuongMH.Location = new System.Drawing.Point(15, 166);
            this.btnThemChuongMH.Name = "btnThemChuongMH";
            this.btnThemChuongMH.Size = new System.Drawing.Size(102, 55);
            this.btnThemChuongMH.TabIndex = 18;
            this.btnThemChuongMH.Text = "Thêm";
            this.btnThemChuongMH.UseVisualStyleBackColor = true;
            // 
            // cmbLop_Mon
            // 
            this.cmbLop_Mon.FormattingEnabled = true;
            this.cmbLop_Mon.Location = new System.Drawing.Point(192, 165);
            this.cmbLop_Mon.Name = "cmbLop_Mon";
            this.cmbLop_Mon.Size = new System.Drawing.Size(251, 28);
            this.cmbLop_Mon.TabIndex = 19;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.Location = new System.Drawing.Point(482, 349);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 55);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.FormattingEnabled = true;
            this.lstMonHoc.ItemHeight = 20;
            this.lstMonHoc.Location = new System.Drawing.Point(6, 224);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.Size = new System.Drawing.Size(457, 304);
            this.lstMonHoc.TabIndex = 13;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoaMH.Location = new System.Drawing.Point(482, 192);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(117, 55);
            this.btnXoaMH.TabIndex = 14;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(192, 25);
            this.txtMaMH.Multiline = true;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(251, 36);
            this.txtMaMH.TabIndex = 12;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(192, 95);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(251, 35);
            this.txtTenMH.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên Lớp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Môn Học:";
            // 
            // btnTieptucMH
            // 
            this.btnTieptucMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieptucMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTieptucMH.Location = new System.Drawing.Point(482, 277);
            this.btnTieptucMH.Name = "btnTieptucMH";
            this.btnTieptucMH.Size = new System.Drawing.Size(117, 52);
            this.btnTieptucMH.TabIndex = 16;
            this.btnTieptucMH.Text = "Tiếp Tục";
            this.btnTieptucMH.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLop_Mon);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.lstMonHoc);
            this.groupBox1.Controls.Add(this.btnXoaMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTieptucMH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSuaMH);
            this.groupBox1.Controls.Add(this.btnThemMH);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn Học";
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSuaMH.Location = new System.Drawing.Point(482, 122);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(117, 55);
            this.btnSuaMH.TabIndex = 17;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(16, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 550);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(487, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // QLMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "QLMon";
            this.Text = "QLMon";
            this.Load += new System.EventHandler(this.QLMon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvChuongMH;
        private System.Windows.Forms.Button btnXoaChuongMH;
        private System.Windows.Forms.TextBox txtTenChuongMH;
        private System.Windows.Forms.TextBox txtMaChuongMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTieptucChuongMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaChuongMH;
        private System.Windows.Forms.Button btnThemChuongMH;
        private System.Windows.Forms.ComboBox cmbLop_Mon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstMonHoc;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTieptucMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}