namespace Lap01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // must be first
            WireEvents();
        }

        private void WireEvents()
        {
            this.btnShow.Click += btnShow_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnExit.Click += btnExit_Click;
            // optional: show details on selection
                this.lstResult.SelectedIndexChanged += lstResult_SelectedIndexChanged_1;
        }

        private void btnShow_Click(object? sender, EventArgs e)
        {
            // Defensive null-checks in case controls aren't present
            var name = txtName?.Text?.Trim() ?? string.Empty;
            var yearText = txtYear?.Text?.Trim() ?? string.Empty;
            var email = txtEmail?.Text?.Trim() ?? string.Empty;
            var faculty = cmbFaculty?.SelectedItem?.ToString() ?? string.Empty;
            var gender = rbMale?.Checked == true ? "Nam" : rbFemale?.Checked == true ? "Nữ" : "Không xác định";

            // Compute age if year is valid
            int age = 0;
            if (int.TryParse(yearText, out var year))
            {
                age = DateTime.Now.Year - year;
                if (age < 0) age = 0;
            }

            // Clear previous result block (optional keep previous entries by removing this line)
            // lstResult.Items.Clear();

            // Add formatted lines to ListBox so it appears as a block of text
            lstResult.Items.Add("THÔNG TIN SINH VIÊN");
            lstResult.Items.Add($"Họ tên: {name}");
            lstResult.Items.Add($"Tuổi: {age}" + (year == 0 ? "" : $" (Năm sinh: {yearText})"));
            lstResult.Items.Add($"Email: {email}");
            lstResult.Items.Add($"Giới tính: {gender}");
            lstResult.Items.Add($"Khoa/Lớp: {faculty}");
            lstResult.Items.Add(string.Empty); // blank line separator
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thông tin sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear input fields
                txtName.Text = string.Empty;
                txtYear.Text = string.Empty;
                txtEmail.Text = string.Empty;
                rbMale.Checked = false;
                rbFemale.Checked = false;
                cmbFaculty.SelectedIndex = -1;

                // Clear results
                lstResult.Items.Clear();
            }
            // else do nothing
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lstResult_SelectedIndexChanged_1(object? sender, EventArgs e)
        {
            // Optional: show selected line details or do nothing
            // if you want to show a detail dialog, uncomment:
            // if (lstResult.SelectedItem != null) MessageBox.Show(lstResult.SelectedItem.ToString(), "Chi tiết");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add your logic here
        }

        private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add your logic here
        }
    }
}
