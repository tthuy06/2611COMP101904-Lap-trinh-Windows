namespace trenlop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            txtSoDienThoai = new TextBox();
            lblSDT = new Label();
            lblDemKyTu = new Label();
            chkNhanEmail = new CheckBox();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            lblTTEmail = new Label();
            grbthongtinhocvien = new GroupBox();
            grbThongTinKhoaHoc = new GroupBox();
            lblTongTien = new Label();
            lblTongHocPhi = new Label();
            lblHocPhiThang = new Label();
            lblHocPhi = new Label();
            numSoThang = new NumericUpDown();
            radOffline = new RadioButton();
            radOnline = new RadioButton();
            cboKhoaHoc = new ComboBox();
            lblSoNgay = new Label();
            lblHinhThuc = new Label();
            lblKhoaHoc = new Label();
            panel4 = new Panel();
            btnThoat = new Label();
            btnLamMoi = new Label();
            btnDangKy = new Label();
            grbthongtinhocvien.SuspendLayout();
            grbThongTinKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(321, 53);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(407, 33);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký Khóa Học Ngắn Hạn";
            label1.Click += label1_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblHoTen.Location = new Point(21, 61);
            lblHoTen.Margin = new Padding(2, 0, 2, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(61, 19);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên:";
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(128, 56);
            txtHoTen.Margin = new Padding(2);
            txtHoTen.MaxLength = 50;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(245, 34);
            txtHoTen.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(128, 103);
            txtSoDienThoai.Margin = new Padding(2);
            txtSoDienThoai.MaxLength = 50;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(245, 34);
            txtSoDienThoai.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSDT.Location = new Point(21, 112);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(44, 19);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "SĐT:";
            lblSDT.Click += label3_Click;
            // 
            // lblDemKyTu
            // 
            lblDemKyTu.AutoSize = true;
            lblDemKyTu.BackColor = Color.LightSkyBlue;
            lblDemKyTu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblDemKyTu.Location = new Point(391, 62);
            lblDemKyTu.Margin = new Padding(2, 0, 2, 0);
            lblDemKyTu.Name = "lblDemKyTu";
            lblDemKyTu.Size = new Size(41, 19);
            lblDemKyTu.TabIndex = 4;
            lblDemKyTu.Text = "0/50";
            // 
            // chkNhanEmail
            // 
            chkNhanEmail.AutoSize = true;
            chkNhanEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkNhanEmail.Location = new Point(109, 204);
            chkNhanEmail.Margin = new Padding(2);
            chkNhanEmail.Name = "chkNhanEmail";
            chkNhanEmail.Size = new Size(189, 23);
            chkNhanEmail.TabIndex = 0;
            chkNhanEmail.Text = "Nhận email thông báo";
            chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpNgaySinh.Location = new Point(128, 153);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(304, 30);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblNgaySinh.Location = new Point(21, 162);
            lblNgaySinh.Margin = new Padding(2, 0, 2, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(87, 19);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblTTEmail
            // 
            lblTTEmail.AutoSize = true;
            lblTTEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTTEmail.Location = new Point(99, 243);
            lblTTEmail.Margin = new Padding(2, 0, 2, 0);
            lblTTEmail.Name = "lblTTEmail";
            lblTTEmail.Size = new Size(217, 19);
            lblTTEmail.TabIndex = 7;
            lblTTEmail.Text = "Không nhận email thông báo";
            // 
            // grbthongtinhocvien
            // 
            grbthongtinhocvien.BackColor = Color.LightSkyBlue;
            grbthongtinhocvien.Controls.Add(lblTTEmail);
            grbthongtinhocvien.Controls.Add(lblNgaySinh);
            grbthongtinhocvien.Controls.Add(dtpNgaySinh);
            grbthongtinhocvien.Controls.Add(chkNhanEmail);
            grbthongtinhocvien.Controls.Add(lblDemKyTu);
            grbthongtinhocvien.Controls.Add(lblSDT);
            grbthongtinhocvien.Controls.Add(txtSoDienThoai);
            grbthongtinhocvien.Controls.Add(txtHoTen);
            grbthongtinhocvien.Controls.Add(lblHoTen);
            grbthongtinhocvien.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            grbthongtinhocvien.Location = new Point(10, 134);
            grbthongtinhocvien.Margin = new Padding(2);
            grbthongtinhocvien.Name = "grbthongtinhocvien";
            grbthongtinhocvien.Padding = new Padding(2);
            grbthongtinhocvien.Size = new Size(480, 293);
            grbthongtinhocvien.TabIndex = 0;
            grbthongtinhocvien.TabStop = false;
            grbthongtinhocvien.Text = "Thông tin học viên";
            grbthongtinhocvien.Enter += groupBox1_Enter;
            // 
            // grbThongTinKhoaHoc
            // 
            grbThongTinKhoaHoc.BackColor = Color.LightSkyBlue;
            grbThongTinKhoaHoc.Controls.Add(lblTongTien);
            grbThongTinKhoaHoc.Controls.Add(lblTongHocPhi);
            grbThongTinKhoaHoc.Controls.Add(lblHocPhiThang);
            grbThongTinKhoaHoc.Controls.Add(lblHocPhi);
            grbThongTinKhoaHoc.Controls.Add(numSoThang);
            grbThongTinKhoaHoc.Controls.Add(radOffline);
            grbThongTinKhoaHoc.Controls.Add(radOnline);
            grbThongTinKhoaHoc.Controls.Add(cboKhoaHoc);
            grbThongTinKhoaHoc.Controls.Add(lblSoNgay);
            grbThongTinKhoaHoc.Controls.Add(lblHinhThuc);
            grbThongTinKhoaHoc.Controls.Add(lblKhoaHoc);
            grbThongTinKhoaHoc.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTinKhoaHoc.Location = new Point(545, 134);
            grbThongTinKhoaHoc.Margin = new Padding(2);
            grbThongTinKhoaHoc.Name = "grbThongTinKhoaHoc";
            grbThongTinKhoaHoc.Padding = new Padding(2);
            grbThongTinKhoaHoc.Size = new Size(480, 293);
            grbThongTinKhoaHoc.TabIndex = 8;
            grbThongTinKhoaHoc.TabStop = false;
            grbThongTinKhoaHoc.Text = "Thông tin khóa học";
            grbThongTinKhoaHoc.Enter += groupBox2_Enter;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            lblTongTien.ForeColor = Color.SeaGreen;
            lblTongTien.Location = new Point(191, 243);
            lblTongTien.Margin = new Padding(2, 0, 2, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(58, 19);
            lblTongTien.TabIndex = 15;
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.Click += label5_Click_1;
            // 
            // lblTongHocPhi
            // 
            lblTongHocPhi.AutoSize = true;
            lblTongHocPhi.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTongHocPhi.Location = new Point(33, 243);
            lblTongHocPhi.Margin = new Padding(2, 0, 2, 0);
            lblTongHocPhi.Name = "lblTongHocPhi";
            lblTongHocPhi.Size = new Size(114, 19);
            lblTongHocPhi.TabIndex = 14;
            lblTongHocPhi.Text = "Tổng Học Phí:";
            // 
            // lblHocPhiThang
            // 
            lblHocPhiThang.AutoSize = true;
            lblHocPhiThang.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            lblHocPhiThang.Location = new Point(191, 204);
            lblHocPhiThang.Margin = new Padding(2, 0, 2, 0);
            lblHocPhiThang.Name = "lblHocPhiThang";
            lblHocPhiThang.Size = new Size(58, 19);
            lblHocPhiThang.TabIndex = 13;
            lblHocPhiThang.Text = "0 VNĐ";
            // 
            // lblHocPhi
            // 
            lblHocPhi.AutoSize = true;
            lblHocPhi.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblHocPhi.Location = new Point(33, 204);
            lblHocPhi.Margin = new Padding(2, 0, 2, 0);
            lblHocPhi.Name = "lblHocPhi";
            lblHocPhi.Size = new Size(128, 19);
            lblHocPhi.TabIndex = 9;
            lblHocPhi.Text = "Học Phí/ Tháng:";
            // 
            // radSoThang
            // 
            numSoThang.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            numSoThang.Location = new Point(191, 156);
            numSoThang.Margin = new Padding(2);
            numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoThang.Name = "radSoThang";
            numSoThang.Size = new Size(195, 27);
            numSoThang.TabIndex = 12;
            numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radOffline
            // 
            radOffline.AutoSize = true;
            radOffline.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radOffline.Location = new Point(285, 108);
            radOffline.Margin = new Padding(2);
            radOffline.Name = "radOffline";
            radOffline.Size = new Size(101, 23);
            radOffline.TabIndex = 10;
            radOffline.TabStop = true;
            radOffline.Text = "Trực tiếp";
            radOffline.UseVisualStyleBackColor = true;
            // 
            // radOnline
            // 
            radOnline.AutoSize = true;
            radOnline.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radOnline.Location = new Point(191, 108);
            radOnline.Margin = new Padding(2);
            radOnline.Name = "radOnline";
            radOnline.Size = new Size(80, 23);
            radOnline.TabIndex = 9;
            radOnline.TabStop = true;
            radOnline.Text = "Online";
            radOnline.UseVisualStyleBackColor = true;
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(191, 51);
            cboKhoaHoc.Margin = new Padding(2);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(226, 36);
            cboKhoaHoc.TabIndex = 8;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // lblSoNgay
            // 
            lblSoNgay.AutoSize = true;
            lblSoNgay.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSoNgay.Location = new Point(33, 162);
            lblSoNgay.Margin = new Padding(2, 0, 2, 0);
            lblSoNgay.Name = "lblSoNgay";
            lblSoNgay.Size = new Size(143, 19);
            lblSoNgay.TabIndex = 6;
            lblSoNgay.Text = "Số tháng đăng ký:";
            lblSoNgay.Click += label3_Click_1;
            // 
            // lblHinhThuc
            // 
            lblHinhThuc.AutoSize = true;
            lblHinhThuc.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblHinhThuc.Location = new Point(33, 118);
            lblHinhThuc.Margin = new Padding(2, 0, 2, 0);
            lblHinhThuc.Name = "lblHinhThuc";
            lblHinhThuc.Size = new Size(118, 19);
            lblHinhThuc.TabIndex = 3;
            lblHinhThuc.Text = "Hình thức học:";
            lblHinhThuc.Click += label5_Click;
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblKhoaHoc.Location = new Point(45, 62);
            lblKhoaHoc.Margin = new Padding(2, 0, 2, 0);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(81, 19);
            lblKhoaHoc.TabIndex = 0;
            lblKhoaHoc.Text = "Khóa Học";
            lblKhoaHoc.Click += lblKhoaHoc_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(btnThoat);
            panel4.Controls.Add(btnLamMoi);
            panel4.Controls.Add(btnDangKy);
            panel4.Location = new Point(144, 447);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(696, 112);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.BlanchedAlmond;
            btnThoat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThoat.Location = new Point(518, 46);
            btnThoat.Margin = new Padding(2, 0, 2, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 41);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ActiveCaption;
            btnLamMoi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.Location = new Point(323, 46);
            btnLamMoi.Margin = new Padding(2, 0, 2, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(133, 41);
            btnLamMoi.TabIndex = 1;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleCenter;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.MediumAquamarine;
            btnDangKy.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnDangKy.Location = new Point(130, 46);
            btnDangKy.Margin = new Padding(2, 0, 2, 0);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(133, 41);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.TextAlign = ContentAlignment.MiddleCenter;
            btnDangKy.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1058, 635);
            Controls.Add(panel4);
            Controls.Add(grbThongTinKhoaHoc);
            Controls.Add(label1);
            Controls.Add(grbthongtinhocvien);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbthongtinhocvien.ResumeLayout(false);
            grbthongtinhocvien.PerformLayout();
            grbThongTinKhoaHoc.ResumeLayout(false);
            grbThongTinKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoThang).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private Label lblSDT;
        private Label lblDemKyTu;
        private CheckBox chkNhanEmail;
        private DateTimePicker dtpNgaySinh;
        private Label lblNgaySinh;
        private Label lblTTEmail;
        private GroupBox grbthongtinhocvien;
        private GroupBox grbThongTinKhoaHoc;
        private Label lblSoNgay;
        private Label lblHinhThuc;
        private Label lblKhoaHoc;
        private ComboBox cboKhoaHoc;
        private RadioButton radOffline;
        private RadioButton radOnline;
        private NumericUpDown numSoThang;
        private Label lblTongTien;
        private Label lblTongHocPhi;
        private Label lblHocPhiThang;
        private Label lblHocPhi;
        private Panel panel4;
        private Label btnThoat;
        private Label btnLamMoi;
        private Label btnDangKy;
    }
}
