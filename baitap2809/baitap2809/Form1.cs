using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace trenlop
{
    // Cấu trúc lưu thông tin học phí và mô tả khóa học
    public class KhoaHocInfo
    {
        public decimal HocPhi { get; set; }
        public string NoiDung { get; set; }

        public KhoaHocInfo(decimal hocPhi, string noiDung)
        {
            HocPhi = hocPhi;
            NoiDung = noiDung;
        }
    }

    public partial class Form1 : Form
    {
        // 1. Khai báo danh sách các khóa học theo yêu cầu
        private Dictionary<string, KhoaHocInfo> danhSachKhoaHoc = new Dictionary<string, KhoaHocInfo>()
        {
            {
                "C# WinForms cơ bản",
                new KhoaHocInfo(800000m, "Lập trình giao diện WinForms, xử lý sự kiện, kết nối và thao tác điều khiển cơ bản.")
            },
            {
                "SQL Server cơ bản",
                new KhoaHocInfo(700000m, "Thiết kế cơ sở dữ liệu, câu lệnh truy vấn SQL, quản lý bảng và dữ liệu quan hệ.")
            },
            {
                "Web Frontend cơ bản",
                new KhoaHocInfo(750000m, "Xây dựng giao diện web với HTML5, CSS3, JavaScript và thiết kế giao diện tương thích.")
            },
            {
                "Lập trình Python cơ bản",
                new KhoaHocInfo(650000m, "Cú pháp cơ bản Python, cấu trúc điều kiện, vòng lặp, hàm và xử lý dữ liệu cơ bản.")
            }
        };

        public Form1()
        {
            InitializeComponent();
            txtHoTen.TextChanged += txtHoTen_TextChanged;
        }

        private string ChuanHoaKhoangTrang(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            return Regex.Replace(input.Trim(), @"\s+", " ");
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            int soKyTu = hoTen.Length;
            lblDemKyTu.Text = $"{soKyTu}/50";
        }

        // 5.1. Khi Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.DataSource = new BindingSource(danhSachKhoaHoc, null);
            cboKhoaHoc.DisplayMember = "Key";
            cboKhoaHoc.ValueMember = "Value";
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }
            radOnline.Checked = true;
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;
            TinhTongTien();
            lblDemKyTu.Text = "0/50";
        }

        // Hàm tính toán tổng học phí tự động
        private void TinhTongTien()
        {
            if (cboKhoaHoc.SelectedItem != null)
            {
                var selectedPair = (KeyValuePair<string, KhoaHocInfo>)cboKhoaHoc.SelectedItem;
                decimal hocPhiMotThang = selectedPair.Value.HocPhi;
                int soThang = (int)numSoThang.Value;
                decimal tongTien = hocPhiMotThang * soThang;

                lblHocPhiThang.Text = hocPhiMotThang.ToString("N0") + " VNĐ";
                lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
            }
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        // 5.2. Nút Đăng ký (Kiểm tra ràng buộc theo yêu cầu)
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = ChuanHoaKhoangTrang(txtHoTen.Text);
            txtHoTen.Text = hoTen; 
            string soDienThoai = txtSoDienThoai.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (hoTen.Length > 50)
            {
                MessageBox.Show("Họ tên không được vượt quá 50 ký tự. Vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (!Regex.IsMatch(soDienThoai, @"^\d+$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa các chữ số. Vui lòng điền lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (soDienThoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số. Vui lòng điền lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }
            if (cboKhoaHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            var selectedPair = (KeyValuePair<string, KhoaHocInfo>)cboKhoaHoc.SelectedItem;
            string tenKhoaHoc = selectedPair.Key;
            string noiDungKhoaHoc = selectedPair.Value.NoiDung;
            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            int soThang = (int)numSoThang.Value;
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");
            string trangThaiEmail = chkNhanEmail.Checked ? "Có nhận thông báo" : "Không nhận thông báo";
            decimal tongTien = selectedPair.Value.HocPhi * soThang;
            string phieuDangKy = $"=== PHIẾU ĐĂNG KÝ KHÓA HỌC ===\n\n" +
                                 $"Họ tên học viên: {hoTen}\n" +
                                 $"Số điện thoại: {soDienThoai}\n" +
                                 $"Ngày sinh: {ngaySinh}\n" +
                                 $"Khóa học: {tenKhoaHoc}\n" +
                                 $"Nội dung: {noiDungKhoaHoc}\n" +
                                 $"Hình thức học: {hinhThuc}\n" +
                                 $"Số tháng đăng ký: {soThang}\n" +
                                 $"Tổng học phí: {tongTien:N0} VNĐ\n" +
                                 $"Trạng thái email: {trangThaiEmail}";

            MessageBox.Show(phieuDangKy, "Phiếu Đăng Ký Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear(); 
            dtpNgaySinh.Value = DateTime.Now; 
            chkNhanEmail.Checked = false; 
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0; 
            }

            radOnline.Checked = true; 
            numSoThang.Value = 1;
            lblDemKyTu.Text = "0/50";
            txtHoTen.Focus(); 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Các hàm sự kiện phụ giữ kết nối với Designer
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void lblKhoaHoc_Click(object sender, EventArgs e) { }
        private void lblHoTen_Click(object sender, EventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}