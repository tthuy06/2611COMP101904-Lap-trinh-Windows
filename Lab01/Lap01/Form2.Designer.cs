namespace Lap01
{
    partial class Form2
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
            label1 = new Label();
            grpThongTin = new GroupBox();
            lblHoten = new Label();
            txtHoTen = new TextBox();
            lblDemKyTu = new Label();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            chkNhanEmail = new CheckBox();
            lblTrangthaiemail = new Label();
            grpKhoaHoc = new GroupBox();
            lblKhoahoc = new Label();
            cboKhoahoc = new ComboBox();
            lblHinhThucHoc = new Label();
            radOnline = new RadioButton();
            radTrucTiep = new RadioButton();
            lblSoThang = new Label();
            numSoThang = new NumericUpDown();
            lblHocPhiThang = new Label();
            lblHocPhi = new Label();
            lblTongTien = new Label();
            lblTien = new Label();
            panel01 = new Panel();
            ptnDangky = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            grpThongTin.SuspendLayout();
            grpKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            panel01.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(102, 45);
            label1.Name = "label1";
            label1.Size = new Size(537, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký khóa học ngắn hạn";
            label1.Click += label1_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.BackColor = SystemColors.ActiveCaption;
            grpThongTin.Controls.Add(lblTrangthaiemail);
            grpThongTin.Controls.Add(chkNhanEmail);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(lblSDT);
            grpThongTin.Controls.Add(lblDemKyTu);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblHoten);
            grpThongTin.Location = new Point(49, 126);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(470, 273);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin học viên";
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(30, 40);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(57, 20);
            lblHoten.TabIndex = 0;
            lblHoten.Text = "Họ tên:";
            lblHoten.Click += label2_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 37);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(233, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblDemKyTu
            // 
            lblDemKyTu.AutoSize = true;
            lblDemKyTu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDemKyTu.ForeColor = Color.Gray;
            lblDemKyTu.Location = new Point(376, 44);
            lblDemKyTu.Name = "lblDemKyTu";
            lblDemKyTu.Size = new Size(39, 20);
            lblDemKyTu.TabIndex = 2;
            lblDemKyTu.Text = "0/50";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(30, 85);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(39, 20);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "SĐT:";
            lblSDT.Click += label4_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(123, 78);
            txtSDT.MaxLength = 10;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(233, 27);
            txtSDT.TabIndex = 4;
            txtSDT.TextChanged += textBox2_TextChanged;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(30, 123);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày sinh:";
            lblNgaySinh.Click += this.label5_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpNgaySinh.Location = new Point(123, 115);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(234, 28);
            dtpNgaySinh.TabIndex = 7;
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Location = new Point(153, 179);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(180, 24);
            chkNhanEmail.TabIndex = 8;
            chkNhanEmail.Text = "Nhận Email thông báo";
            chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // lblTrangthaiemail
            // 
            lblTrangthaiemail.AutoSize = true;
            lblTrangthaiemail.Location = new Point(162, 226);
            lblTrangthaiemail.Name = "lblTrangthaiemail";
            lblTrangthaiemail.Size = new Size(202, 20);
            lblTrangthaiemail.TabIndex = 9;
            lblTrangthaiemail.Text = "Không nhận email thông báo";
            // 
            // grpKhoaHoc
            // 
            grpKhoaHoc.BackColor = SystemColors.ActiveCaption;
            grpKhoaHoc.Controls.Add(lblTien);
            grpKhoaHoc.Controls.Add(lblTongTien);
            grpKhoaHoc.Controls.Add(lblHocPhi);
            grpKhoaHoc.Controls.Add(lblHocPhiThang);
            grpKhoaHoc.Controls.Add(numSoThang);
            grpKhoaHoc.Controls.Add(lblSoThang);
            grpKhoaHoc.Controls.Add(radTrucTiep);
            grpKhoaHoc.Controls.Add(radOnline);
            grpKhoaHoc.Controls.Add(lblHinhThucHoc);
            grpKhoaHoc.Controls.Add(cboKhoahoc);
            grpKhoaHoc.Controls.Add(lblKhoahoc);
            grpKhoaHoc.Location = new Point(550, 126);
            grpKhoaHoc.Name = "grpKhoaHoc";
            grpKhoaHoc.Size = new Size(470, 273);
            grpKhoaHoc.TabIndex = 2;
            grpKhoaHoc.TabStop = false;
            grpKhoaHoc.Text = "Thông tin khóa học";
            grpKhoaHoc.Enter += grpKhoaHoc_Enter;
            // 
            // lblKhoahoc
            // 
            lblKhoahoc.AutoSize = true;
            lblKhoahoc.Location = new Point(27, 44);
            lblKhoahoc.Name = "lblKhoahoc";
            lblKhoahoc.Size = new Size(74, 20);
            lblKhoahoc.TabIndex = 0;
            lblKhoahoc.Text = "Khóa học:";
            // 
            // cboKhoahoc
            // 
            cboKhoahoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoahoc.FormattingEnabled = true;
            cboKhoahoc.Location = new Point(152, 39);
            cboKhoahoc.Name = "cboKhoahoc";
            cboKhoahoc.Size = new Size(223, 28);
            cboKhoahoc.TabIndex = 1;
            // 
            // lblHinhThucHoc
            // 
            lblHinhThucHoc.AutoSize = true;
            lblHinhThucHoc.Location = new Point(27, 85);
            lblHinhThucHoc.Name = "lblHinhThucHoc";
            lblHinhThucHoc.Size = new Size(104, 20);
            lblHinhThucHoc.TabIndex = 2;
            lblHinhThucHoc.Text = "Hình thức học:";
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Location = new Point(153, 83);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(73, 24);
            radOnline.TabIndex = 3;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            // 
            // radTrucTiep
            // 
            radTrucTiep.AutoSize = true;
            radTrucTiep.Location = new Point(287, 81);
            radTrucTiep.Name = "radTrucTiep";
            radTrucTiep.Size = new Size(88, 24);
            radTrucTiep.TabIndex = 4;
            radTrucTiep.TabStop = true;
            radTrucTiep.Text = "Trực tiếp";
            radTrucTiep.UseVisualStyleBackColor = true;
            // 
            // lblSoThang
            // 
            lblSoThang.AutoSize = true;
            lblSoThang.Location = new Point(27, 122);
            lblSoThang.Name = "lblSoThang";
            lblSoThang.Size = new Size(71, 20);
            lblSoThang.TabIndex = 5;
            lblSoThang.Text = "Số tháng:";
            lblSoThang.Click += label2_Click_1;
            // 
            // numSoThang
            // 
            numSoThang.Location = new Point(152, 113);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "numSoThang";
            numSoThang.Size = new Size(121, 27);
            numSoThang.TabIndex = 6;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHocPhiThang
            // 
            lblHocPhiThang.AutoSize = true;
            lblHocPhiThang.Location = new Point(27, 161);
            lblHocPhiThang.Name = "lblHocPhiThang";
            lblHocPhiThang.Size = new Size(116, 20);
            lblHocPhiThang.TabIndex = 7;
            lblHocPhiThang.Text = "Học phí / tháng:";
            // 
            // lblHocPhi
            // 
            lblHocPhi.AutoSize = true;
            lblHocPhi.Location = new Point(153, 161);
            lblHocPhi.Name = "lblHocPhi";
            lblHocPhi.Size = new Size(52, 20);
            lblHocPhi.TabIndex = 8;
            lblHocPhi.Text = "0 VNĐ";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(27, 202);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(75, 20);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "Tổng tiền:";
            lblTongTien.Click += label2_Click_2;
            // 
            // lblTien
            // 
            lblTien.AutoSize = true;
            lblTien.Location = new Point(153, 202);
            lblTien.Name = "lblTien";
            lblTien.Size = new Size(52, 20);
            lblTien.TabIndex = 10;
            lblTien.Text = "0 VNĐ";
            // 
            // panel01
            // 
            panel01.Controls.Add(btnThoat);
            panel01.Controls.Add(btnLamMoi);
            panel01.Controls.Add(ptnDangky);
            panel01.Location = new Point(243, 444);
            panel01.Name = "panel01";
            panel01.Size = new Size(500, 78);
            panel01.TabIndex = 3;
            // 
            // ptnDangky
            // 
            ptnDangky.BackColor = Color.MediumSeaGreen;
            ptnDangky.ForeColor = Color.Transparent;
            ptnDangky.Location = new Point(39, 19);
            ptnDangky.Name = "ptnDangky";
            ptnDangky.Size = new Size(110, 38);
            ptnDangky.TabIndex = 0;
            ptnDangky.Text = "Đăng ký";
            ptnDangky.UseVisualStyleBackColor = false;
            ptnDangky.Click += ptnDangky_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Blue;
            btnLamMoi.ForeColor = Color.Transparent;
            btnLamMoi.Location = new Point(200, 19);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 38);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += this.btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Brown;
            btnThoat.ForeColor = Color.Transparent;
            btnThoat.Location = new Point(351, 19);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 38);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += this.btnThoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 604);
            Controls.Add(panel01);
            Controls.Add(grpKhoaHoc);
            Controls.Add(grpThongTin);
            Controls.Add(label1);
            Name = "Form2";
            Text = "ĐĂNG KÝ KHÓA HỌC";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpKhoaHoc.ResumeLayout(false);
            grpKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            panel01.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpThongTin;
        private CheckBox chkNhanEmail;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private TextBox txtSDT;
        private Label lblSDT;
        private Label lblDemKyTu;
        private TextBox txtHoTen;
        private Label lblHoten;
        private Label lblTrangthaiemail;
        private GroupBox grpKhoaHoc;
        private Label lblKhoahoc;
        private ComboBox cboKhoahoc;
        private Label label3;
        private Label lblHinhThucHoc;
        private RadioButton radTrucTiep;
        private RadioButton radOnline;
        private Label lblSoThang;
        private NumericUpDown numSoThang;
        private Label lblHocPhi;
        private Label lblHocPhiThang;
        private Label lblTongTien;
        private Label lblTien;
        private Panel panel01;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button ptnDangky;
    }
}