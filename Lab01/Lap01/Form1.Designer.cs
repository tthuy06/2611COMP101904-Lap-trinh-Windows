namespace Lap01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel rightPanel;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblFaculty = new Label();
            cmbFaculty = new ComboBox();
            lblResult = new Label();
            lstResult = new ListBox();
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            rightPanel = new Panel();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(760, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN SINH VIÊN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(76, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(120, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(500, 75);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(74, 20);
            lblYear.TabIndex = 3;
            lblYear.Text = "Năm sinh:";
            // 
            // txtYear
            // 
            txtYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtYear.Location = new Point(570, 70);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(210, 27);
            txtYear.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(120, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(660, 27);
            txtEmail.TabIndex = 6;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(30, 155);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 7;
            lblGender.Text = "Giới tính:";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(120, 152);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 24);
            rbMale.TabIndex = 8;
            rbMale.Text = "Nam";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(180, 152);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(50, 24);
            rbFemale.TabIndex = 9;
            rbFemale.Text = "Nữ";
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Location = new Point(30, 195);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(82, 20);
            lblFaculty.TabIndex = 10;
            lblFaculty.Text = "Chọn khoa:";
            // 
            // cmbFaculty
            // 
            cmbFaculty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Khoa học máy tính", "Toán - Tin", "Kinh tế" });
            cmbFaculty.Location = new Point(120, 190);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(360, 28);
            cmbFaculty.TabIndex = 11;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(35, 266);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 20);
            lblResult.TabIndex = 12;
            lblResult.Text = "Kết quả:";
            lblResult.Click += lblResult_Click;
            // 
            // lstResult
            // 
            lstResult.Location = new Point(120, 260);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(660, 120);
            lstResult.TabIndex = 13;
            lstResult.SelectedIndexChanged += lstResult_SelectedIndexChanged;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Top;
            btnShow.Location = new Point(9, 20);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(80, 28);
            btnShow.TabIndex = 14;
            btnShow.Text = "Hiển thị";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.Location = new Point(95, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 28);
            btnClear.TabIndex = 15;
            btnClear.Text = "Xóa";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top;
            btnExit.Location = new Point(181, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 28);
            btnExit.TabIndex = 16;
            btnExit.Text = "Thoát";
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(btnClear);
            rightPanel.Controls.Add(btnExit);
            rightPanel.Controls.Add(btnShow);
            rightPanel.Location = new Point(283, 383);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(277, 55);
            rightPanel.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblYear);
            Controls.Add(txtYear);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblGender);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(lblFaculty);
            Controls.Add(cmbFaculty);
            Controls.Add(lblResult);
            Controls.Add(lstResult);
            Controls.Add(rightPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin sinh viên";
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Add this method to your Form1 partial class (usually in Form1.cs, but can be here for completeness)
        private void lblResult_Click(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }
    }
}
