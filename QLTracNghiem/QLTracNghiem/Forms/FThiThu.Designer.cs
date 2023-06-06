namespace QLTracNghiem.Forms
{
    partial class FThiThu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntLamBaiThi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChonMon = new System.Windows.Forms.ComboBox();
            this.cmbChonDe = new System.Windows.Forms.ComboBox();
            this.txtHoVaTenThi = new System.Windows.Forms.TextBox();
            this.btnThoatThi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn Đề Thi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên Môn Kiểm Tra:";
            // 
            // bntLamBaiThi
            // 
            this.bntLamBaiThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLamBaiThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntLamBaiThi.Location = new System.Drawing.Point(364, 303);
            this.bntLamBaiThi.Name = "bntLamBaiThi";
            this.bntLamBaiThi.Size = new System.Drawing.Size(172, 75);
            this.bntLamBaiThi.TabIndex = 18;
            this.bntLamBaiThi.Text = "Làm Bài";
            this.bntLamBaiThi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoVaTenThi);
            this.groupBox1.Controls.Add(this.cmbChonDe);
            this.groupBox1.Controls.Add(this.cmbChonMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThoatThi);
            this.groupBox1.Controls.Add(this.bntLamBaiThi);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ Và Tên:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(25, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 550);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "LÀM BÀI";
            // 
            // cmbChonMon
            // 
            this.cmbChonMon.FormattingEnabled = true;
            this.cmbChonMon.Location = new System.Drawing.Point(514, 53);
            this.cmbChonMon.Name = "cmbChonMon";
            this.cmbChonMon.Size = new System.Drawing.Size(208, 28);
            this.cmbChonMon.TabIndex = 20;
            // 
            // cmbChonDe
            // 
            this.cmbChonDe.FormattingEnabled = true;
            this.cmbChonDe.Location = new System.Drawing.Point(514, 123);
            this.cmbChonDe.Name = "cmbChonDe";
            this.cmbChonDe.Size = new System.Drawing.Size(208, 28);
            this.cmbChonDe.TabIndex = 20;
            // 
            // txtHoVaTenThi
            // 
            this.txtHoVaTenThi.Location = new System.Drawing.Point(514, 184);
            this.txtHoVaTenThi.Multiline = true;
            this.txtHoVaTenThi.Name = "txtHoVaTenThi";
            this.txtHoVaTenThi.Size = new System.Drawing.Size(208, 31);
            this.txtHoVaTenThi.TabIndex = 21;
            // 
            // btnThoatThi
            // 
            this.btnThoatThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatThi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoatThi.Location = new System.Drawing.Point(623, 303);
            this.btnThoatThi.Name = "btnThoatThi";
            this.btnThoatThi.Size = new System.Drawing.Size(172, 75);
            this.btnThoatThi.TabIndex = 18;
            this.btnThoatThi.Text = "Thoát";
            this.btnThoatThi.UseVisualStyleBackColor = true;
            this.btnThoatThi.Click += new System.EventHandler(this.btnThoatThi_Click);
            // 
            // FThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FThiThu";
            this.Text = "FThiThu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntLamBaiThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoVaTenThi;
        private System.Windows.Forms.ComboBox cmbChonDe;
        private System.Windows.Forms.ComboBox cmbChonMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoatThi;
    }
}