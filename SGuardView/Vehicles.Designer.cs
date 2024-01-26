namespace CPMS
{
    partial class Vehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicles));
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
            VehicleDView = new DataGridView();
            SearchTxt = new TextBox();
            SearchVDBtn = new Button();
            ReserveVBtn = new Button();
            GetInvoiceBtn = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VehicleDView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            StatusBtn.Location = new Point(20, 318);
            StatusBtn.Name = "StatusBtn";
            StatusBtn.Size = new Size(260, 60);
            StatusBtn.TabIndex = 7;
            StatusBtn.Text = "Status";
            StatusBtn.UseVisualStyleBackColor = false;
            StatusBtn.Click += StatusBtn_Click;
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
            InvoicesBtn.Location = new Point(20, 388);
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
            EmployeesBtn.Text = "Vehicles";
            EmployeesBtn.UseVisualStyleBackColor = false;
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
            FTitleTXT.Location = new Point(1150, 35);
            FTitleTXT.Name = "FTitleTXT";
            FTitleTXT.Size = new Size(105, 32);
            FTitleTXT.TabIndex = 5;
            FTitleTXT.Text = "Vehicles";
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
            // VehicleDView
            // 
            VehicleDView.AllowUserToAddRows = false;
            VehicleDView.AllowUserToDeleteRows = false;
            VehicleDView.AllowUserToResizeColumns = false;
            VehicleDView.AllowUserToResizeRows = false;
            VehicleDView.BackgroundColor = Color.FromArgb(253, 247, 228);
            VehicleDView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            VehicleDView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VehicleDView.Location = new Point(352, 110);
            VehicleDView.Name = "VehicleDView";
            VehicleDView.ReadOnly = true;
            VehicleDView.RowTemplate.ReadOnly = true;
            VehicleDView.ShowCellErrors = false;
            VehicleDView.ShowCellToolTips = false;
            VehicleDView.ShowEditingIcon = false;
            VehicleDView.Size = new Size(870, 530);
            VehicleDView.TabIndex = 32;
            // 
            // SearchTxt
            // 
            SearchTxt.BorderStyle = BorderStyle.None;
            SearchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTxt.Location = new Point(828, 67);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(174, 22);
            SearchTxt.TabIndex = 31;
            SearchTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // SearchVDBtn
            // 
            SearchVDBtn.BackColor = Color.FromArgb(222, 208, 182);
            SearchVDBtn.BackgroundImage = (Image)resources.GetObject("SearchVDBtn.BackgroundImage");
            SearchVDBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SearchVDBtn.CausesValidation = false;
            SearchVDBtn.Cursor = Cursors.Hand;
            SearchVDBtn.FlatAppearance.BorderSize = 0;
            SearchVDBtn.FlatStyle = FlatStyle.Flat;
            SearchVDBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SearchVDBtn.ForeColor = SystemColors.ControlText;
            SearchVDBtn.Location = new Point(1018, 49);
            SearchVDBtn.Name = "SearchVDBtn";
            SearchVDBtn.Size = new Size(40, 40);
            SearchVDBtn.TabIndex = 30;
            SearchVDBtn.UseVisualStyleBackColor = false;
            SearchVDBtn.Click += SearchVDBtn_Click;
            // 
            // ReserveVBtn
            // 
            ReserveVBtn.BackColor = Color.Transparent;
            ReserveVBtn.BackgroundImage = (Image)resources.GetObject("ReserveVBtn.BackgroundImage");
            ReserveVBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ReserveVBtn.CausesValidation = false;
            ReserveVBtn.Cursor = Cursors.Hand;
            ReserveVBtn.FlatAppearance.BorderSize = 0;
            ReserveVBtn.FlatStyle = FlatStyle.Flat;
            ReserveVBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ReserveVBtn.ForeColor = SystemColors.ControlText;
            ReserveVBtn.Location = new Point(352, 44);
            ReserveVBtn.Name = "ReserveVBtn";
            ReserveVBtn.Size = new Size(230, 49);
            ReserveVBtn.TabIndex = 30;
            ReserveVBtn.Text = "      Reserve a Spot";
            ReserveVBtn.UseVisualStyleBackColor = false;
            ReserveVBtn.Click += ReserveVBtn_Click;
            // 
            // GetInvoiceBtn
            // 
            GetInvoiceBtn.BackColor = Color.Transparent;
            GetInvoiceBtn.BackgroundImage = (Image)resources.GetObject("GetInvoiceBtn.BackgroundImage");
            GetInvoiceBtn.BackgroundImageLayout = ImageLayout.Stretch;
            GetInvoiceBtn.CausesValidation = false;
            GetInvoiceBtn.Cursor = Cursors.Hand;
            GetInvoiceBtn.FlatAppearance.BorderSize = 0;
            GetInvoiceBtn.FlatStyle = FlatStyle.Flat;
            GetInvoiceBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GetInvoiceBtn.ForeColor = SystemColors.ControlText;
            GetInvoiceBtn.Location = new Point(597, 44);
            GetInvoiceBtn.Name = "GetInvoiceBtn";
            GetInvoiceBtn.Size = new Size(193, 49);
            GetInvoiceBtn.TabIndex = 30;
            GetInvoiceBtn.Text = "Get Invoice       ";
            GetInvoiceBtn.TextAlign = ContentAlignment.MiddleRight;
            GetInvoiceBtn.UseVisualStyleBackColor = false;
            GetInvoiceBtn.Click += GetInvoiceBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(809, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 49);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(222, 208, 182);
            label1.Location = new Point(828, 49);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 34;
            label1.Text = "Enter License Number :";
            // 
            // Vehicles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 247, 228);
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(VehicleDView);
            Controls.Add(SearchTxt);
            Controls.Add(GetInvoiceBtn);
            Controls.Add(ReserveVBtn);
            Controls.Add(SearchVDBtn);
            Controls.Add(FTitleTXT);
            Controls.Add(FTitle);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Vehicles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Parking Management System";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)VehicleDView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private DataGridView VehicleDView;
        private TextBox SearchTxt;
        private Button SearchVDBtn;
        private Button ReserveVBtn;
        private Button GetInvoiceBtn;
        private PictureBox pictureBox2;
        private Label label1;
    }
}