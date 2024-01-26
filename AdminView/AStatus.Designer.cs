namespace CPMS
{
    partial class AStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AStatus));
            panel1 = new Panel();
            LogOutBtn = new Button();
            InfoTXT = new Label();
            StatusBtn = new Button();
            InvoicesBtn = new Button();
            CustomersBtn = new Button();
            EmployeesBtn = new Button();
            DashboardBtn = new Button();
            LogoTXT = new Label();
            pictureBox1 = new PictureBox();
            FTitleTXT = new Label();
            FTitle = new PictureBox();
            Title = new Label();
            StatusDView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusDView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 208, 182);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(InfoTXT);
            panel1.Controls.Add(StatusBtn);
            panel1.Controls.Add(InvoicesBtn);
            panel1.Controls.Add(CustomersBtn);
            panel1.Controls.Add(EmployeesBtn);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(LogoTXT);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 680);
            panel1.TabIndex = 0;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.Transparent;
            LogOutBtn.BackgroundImage = (Image)resources.GetObject("LogOutBtn.BackgroundImage");
            LogOutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LogOutBtn.CausesValidation = false;
            LogOutBtn.Cursor = Cursors.Hand;
            LogOutBtn.FlatAppearance.BorderSize = 0;
            LogOutBtn.FlatStyle = FlatStyle.Flat;
            LogOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtn.ForeColor = Color.White;
            LogOutBtn.Location = new Point(20, 580);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(260, 60);
            LogOutBtn.TabIndex = 10;
            LogOutBtn.Text = "Logout";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // InfoTXT
            // 
            InfoTXT.AutoSize = true;
            InfoTXT.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoTXT.Location = new Point(52, 655);
            InfoTXT.Name = "InfoTXT";
            InfoTXT.Size = new Size(189, 17);
            InfoTXT.TabIndex = 8;
            InfoTXT.Text = "A Project By DiIT 01 - Group 05";
            InfoTXT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBtn
            // 
            StatusBtn.BackColor = Color.Transparent;
            StatusBtn.BackgroundImage = (Image)resources.GetObject("StatusBtn.BackgroundImage");
            StatusBtn.BackgroundImageLayout = ImageLayout.Stretch;
            StatusBtn.CausesValidation = false;
            StatusBtn.Cursor = Cursors.Hand;
            StatusBtn.FlatAppearance.BorderSize = 0;
            StatusBtn.FlatStyle = FlatStyle.Flat;
            StatusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StatusBtn.ForeColor = SystemColors.ControlText;
            StatusBtn.Location = new Point(20, 388);
            StatusBtn.Name = "StatusBtn";
            StatusBtn.Size = new Size(260, 60);
            StatusBtn.TabIndex = 7;
            StatusBtn.Text = "Status";
            StatusBtn.UseVisualStyleBackColor = false;
            // 
            // InvoicesBtn
            // 
            InvoicesBtn.BackColor = Color.Transparent;
            InvoicesBtn.BackgroundImage = (Image)resources.GetObject("InvoicesBtn.BackgroundImage");
            InvoicesBtn.BackgroundImageLayout = ImageLayout.Stretch;
            InvoicesBtn.CausesValidation = false;
            InvoicesBtn.Cursor = Cursors.Hand;
            InvoicesBtn.FlatAppearance.BorderSize = 0;
            InvoicesBtn.FlatStyle = FlatStyle.Flat;
            InvoicesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesBtn.ForeColor = SystemColors.ControlText;
            InvoicesBtn.Location = new Point(20, 318);
            InvoicesBtn.Name = "InvoicesBtn";
            InvoicesBtn.Size = new Size(260, 60);
            InvoicesBtn.TabIndex = 6;
            InvoicesBtn.Text = "Invoices";
            InvoicesBtn.UseVisualStyleBackColor = false;
            InvoicesBtn.Click += InvoicesBtn_Click;
            // 
            // CustomersBtn
            // 
            CustomersBtn.BackColor = Color.Transparent;
            CustomersBtn.BackgroundImage = (Image)resources.GetObject("CustomersBtn.BackgroundImage");
            CustomersBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CustomersBtn.CausesValidation = false;
            CustomersBtn.Cursor = Cursors.Hand;
            CustomersBtn.FlatAppearance.BorderSize = 0;
            CustomersBtn.FlatStyle = FlatStyle.Flat;
            CustomersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersBtn.ForeColor = SystemColors.ControlText;
            CustomersBtn.Location = new Point(20, 248);
            CustomersBtn.Name = "CustomersBtn";
            CustomersBtn.Size = new Size(260, 60);
            CustomersBtn.TabIndex = 5;
            CustomersBtn.Text = "Customers";
            CustomersBtn.UseVisualStyleBackColor = false;
            CustomersBtn.Click += CustomersBtn_Click;
            // 
            // EmployeesBtn
            // 
            EmployeesBtn.BackColor = Color.Transparent;
            EmployeesBtn.BackgroundImage = (Image)resources.GetObject("EmployeesBtn.BackgroundImage");
            EmployeesBtn.BackgroundImageLayout = ImageLayout.Stretch;
            EmployeesBtn.CausesValidation = false;
            EmployeesBtn.Cursor = Cursors.Hand;
            EmployeesBtn.FlatAppearance.BorderSize = 0;
            EmployeesBtn.FlatStyle = FlatStyle.Flat;
            EmployeesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmployeesBtn.ForeColor = SystemColors.ControlText;
            EmployeesBtn.Location = new Point(20, 179);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(260, 60);
            EmployeesBtn.TabIndex = 4;
            EmployeesBtn.Text = "Employees";
            EmployeesBtn.UseVisualStyleBackColor = false;
            EmployeesBtn.Click += EmployeesBtn_Click;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.Transparent;
            DashboardBtn.BackgroundImage = (Image)resources.GetObject("DashboardBtn.BackgroundImage");
            DashboardBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardBtn.CausesValidation = false;
            DashboardBtn.Cursor = Cursors.Hand;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = SystemColors.ControlText;
            DashboardBtn.Location = new Point(20, 110);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(260, 60);
            DashboardBtn.TabIndex = 3;
            DashboardBtn.Text = "Dashboard";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += DashboardBtn_Click;
            // 
            // LogoTXT
            // 
            LogoTXT.AutoSize = true;
            LogoTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoTXT.Location = new Point(78, 22);
            LogoTXT.Name = "LogoTXT";
            LogoTXT.Size = new Size(198, 50);
            LogoTXT.TabIndex = 1;
            LogoTXT.Text = "Car Parking \r\nManagement System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FTitleTXT
            // 
            FTitleTXT.AutoSize = true;
            FTitleTXT.BackColor = Color.FromArgb(187, 171, 140);
            FTitleTXT.FlatStyle = FlatStyle.Flat;
            FTitleTXT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FTitleTXT.ForeColor = SystemColors.ControlText;
            FTitleTXT.Location = new Point(1158, 35);
            FTitleTXT.Name = "FTitleTXT";
            FTitleTXT.Size = new Size(90, 32);
            FTitleTXT.TabIndex = 5;
            FTitleTXT.Text = "Admin";
            // 
            // FTitle
            // 
            FTitle.BackColor = Color.Transparent;
            FTitle.BackgroundImage = (Image)resources.GetObject("FTitle.BackgroundImage");
            FTitle.BackgroundImageLayout = ImageLayout.Stretch;
            FTitle.Location = new Point(1124, 22);
            FTitle.Name = "FTitle";
            FTitle.Size = new Size(140, 60);
            FTitle.TabIndex = 4;
            FTitle.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(591, 48);
            Title.Name = "Title";
            Title.Size = new Size(372, 32);
            Title.TabIndex = 35;
            Title.Text = "Current Status of Parking Spots";
            // 
            // StatusDView
            // 
            StatusDView.AllowUserToAddRows = false;
            StatusDView.AllowUserToDeleteRows = false;
            StatusDView.AllowUserToResizeColumns = false;
            StatusDView.AllowUserToResizeRows = false;
            StatusDView.BackgroundColor = Color.FromArgb(253, 247, 228);
            StatusDView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            StatusDView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StatusDView.Location = new Point(351, 108);
            StatusDView.Name = "StatusDView";
            StatusDView.ReadOnly = true;
            StatusDView.RowTemplate.ReadOnly = true;
            StatusDView.ShowCellErrors = false;
            StatusDView.ShowCellToolTips = false;
            StatusDView.ShowEditingIcon = false;
            StatusDView.Size = new Size(870, 530);
            StatusDView.TabIndex = 34;
            // 
            // AStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 247, 228);
            ClientSize = new Size(1264, 681);
            Controls.Add(Title);
            Controls.Add(StatusDView);
            Controls.Add(FTitleTXT);
            Controls.Add(FTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Parking Management System";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusDView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LogoTXT;
        private PictureBox pictureBox1;
        private Button DashboardBtn;
        private Button EmployeesBtn;
        private Button CustomersBtn;
        private Button StatusBtn;
        private Button InvoicesBtn;
        private Label InfoTXT;
        private Label FTitleTXT;
        private PictureBox FTitle;
        private Button LogOutBtn;
        private Label Title;
        private DataGridView StatusDView;
    }
}