namespace CPMS
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
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
            EMPdataView = new DataGridView();
            label1 = new Label();
            SearchTxt = new TextBox();
            EditEmpBtn = new Button();
            SearchEmpBtn = new Button();
            AddEmpBtn = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            DelEMPTxt = new TextBox();
            DelEmpBtn = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EMPdataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            LogOutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            InfoTXT.Font = new Font("Segoe UI", 9.75F);
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
            StatusBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            StatusBtn.ForeColor = SystemColors.ControlText;
            StatusBtn.Location = new Point(20, 388);
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
            InvoicesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            CustomersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            EmployeesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmployeesBtn.ForeColor = SystemColors.ControlText;
            EmployeesBtn.Location = new Point(20, 179);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(260, 60);
            EmployeesBtn.TabIndex = 4;
            EmployeesBtn.Text = "Employees";
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
            DashboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            LogoTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
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
            FTitleTXT.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
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
            // EMPdataView
            // 
            EMPdataView.AllowUserToAddRows = false;
            EMPdataView.AllowUserToDeleteRows = false;
            EMPdataView.AllowUserToResizeColumns = false;
            EMPdataView.AllowUserToResizeRows = false;
            EMPdataView.BackgroundColor = Color.FromArgb(253, 247, 228);
            EMPdataView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            EMPdataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EMPdataView.Location = new Point(351, 110);
            EMPdataView.MultiSelect = false;
            EMPdataView.Name = "EMPdataView";
            EMPdataView.ReadOnly = true;
            EMPdataView.RowTemplate.ReadOnly = true;
            EMPdataView.ShowCellErrors = false;
            EMPdataView.ShowCellToolTips = false;
            EMPdataView.ShowEditingIcon = false;
            EMPdataView.Size = new Size(870, 530);
            EMPdataView.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(222, 208, 182);
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(889, 51);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 42;
            label1.Text = "Search (Enter EMP ID) :";
            // 
            // SearchTxt
            // 
            SearchTxt.BorderStyle = BorderStyle.None;
            SearchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTxt.Location = new Point(889, 69);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(154, 22);
            SearchTxt.TabIndex = 40;
            SearchTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // EditEmpBtn
            // 
            EditEmpBtn.BackColor = Color.Transparent;
            EditEmpBtn.BackgroundImage = (Image)resources.GetObject("EditEmpBtn.BackgroundImage");
            EditEmpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            EditEmpBtn.CausesValidation = false;
            EditEmpBtn.Cursor = Cursors.Hand;
            EditEmpBtn.FlatAppearance.BorderSize = 0;
            EditEmpBtn.FlatStyle = FlatStyle.Flat;
            EditEmpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EditEmpBtn.ForeColor = SystemColors.ControlText;
            EditEmpBtn.Location = new Point(505, 46);
            EditEmpBtn.Name = "EditEmpBtn";
            EditEmpBtn.Size = new Size(162, 49);
            EditEmpBtn.TabIndex = 37;
            EditEmpBtn.Text = "      Edit";
            EditEmpBtn.UseVisualStyleBackColor = false;
            EditEmpBtn.Click += EditEmpBtn_Click;
            // 
            // SearchEmpBtn
            // 
            SearchEmpBtn.BackColor = Color.FromArgb(222, 208, 182);
            SearchEmpBtn.BackgroundImage = (Image)resources.GetObject("SearchEmpBtn.BackgroundImage");
            SearchEmpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SearchEmpBtn.CausesValidation = false;
            SearchEmpBtn.Cursor = Cursors.Hand;
            SearchEmpBtn.FlatAppearance.BorderSize = 0;
            SearchEmpBtn.FlatStyle = FlatStyle.Flat;
            SearchEmpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SearchEmpBtn.ForeColor = SystemColors.ControlText;
            SearchEmpBtn.Location = new Point(1056, 51);
            SearchEmpBtn.Name = "SearchEmpBtn";
            SearchEmpBtn.Size = new Size(40, 40);
            SearchEmpBtn.TabIndex = 38;
            SearchEmpBtn.UseVisualStyleBackColor = false;
            SearchEmpBtn.Click += SearchEmpBtn_Click;
            // 
            // AddEmpBtn
            // 
            AddEmpBtn.BackColor = Color.Transparent;
            AddEmpBtn.BackgroundImage = (Image)resources.GetObject("AddEmpBtn.BackgroundImage");
            AddEmpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AddEmpBtn.CausesValidation = false;
            AddEmpBtn.Cursor = Cursors.Hand;
            AddEmpBtn.FlatAppearance.BorderSize = 0;
            AddEmpBtn.FlatStyle = FlatStyle.Flat;
            AddEmpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AddEmpBtn.ForeColor = SystemColors.ControlText;
            AddEmpBtn.Location = new Point(337, 46);
            AddEmpBtn.Name = "AddEmpBtn";
            AddEmpBtn.Size = new Size(161, 49);
            AddEmpBtn.TabIndex = 39;
            AddEmpBtn.Text = "     Add";
            AddEmpBtn.UseVisualStyleBackColor = false;
            AddEmpBtn.Click += AddEmpBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(865, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 49);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(222, 208, 182);
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 51);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 46;
            label2.Text = "Delete Employee :";
            // 
            // DelEMPTxt
            // 
            DelEMPTxt.BorderStyle = BorderStyle.None;
            DelEMPTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelEMPTxt.Location = new Point(691, 69);
            DelEMPTxt.Name = "DelEMPTxt";
            DelEMPTxt.Size = new Size(93, 22);
            DelEMPTxt.TabIndex = 44;
            DelEMPTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // DelEmpBtn
            // 
            DelEmpBtn.BackColor = Color.FromArgb(222, 208, 182);
            DelEmpBtn.BackgroundImage = (Image)resources.GetObject("DelEmpBtn.BackgroundImage");
            DelEmpBtn.BackgroundImageLayout = ImageLayout.Stretch;
            DelEmpBtn.CausesValidation = false;
            DelEmpBtn.Cursor = Cursors.Hand;
            DelEmpBtn.FlatAppearance.BorderSize = 0;
            DelEmpBtn.FlatStyle = FlatStyle.Flat;
            DelEmpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DelEmpBtn.ForeColor = SystemColors.ControlText;
            DelEmpBtn.Location = new Point(800, 51);
            DelEmpBtn.Name = "DelEmpBtn";
            DelEmpBtn.Size = new Size(40, 40);
            DelEmpBtn.TabIndex = 43;
            DelEmpBtn.UseVisualStyleBackColor = false;
            DelEmpBtn.Click += DelEmpBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(672, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 49);
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 247, 228);
            ClientSize = new Size(1264, 681);
            Controls.Add(label2);
            Controls.Add(DelEMPTxt);
            Controls.Add(DelEmpBtn);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(SearchTxt);
            Controls.Add(EditEmpBtn);
            Controls.Add(SearchEmpBtn);
            Controls.Add(AddEmpBtn);
            Controls.Add(pictureBox2);
            Controls.Add(EMPdataView);
            Controls.Add(FTitleTXT);
            Controls.Add(FTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Parking Management System";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)EMPdataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private DataGridView EMPdataView;
        private Label label1;
        private TextBox SearchTxt;
        private Button EditEmpBtn;
        private Button SearchEmpBtn;
        private Button AddEmpBtn;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox DelEMPTxt;
        private Button DelEmpBtn;
        private PictureBox pictureBox3;
    }
}