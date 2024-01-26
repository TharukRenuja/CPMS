namespace CPMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            HomeBtn = new Button();
            InfoTXT = new Label();
            AboutBtn = new Button();
            ContactBtn = new Button();
            StatusBtn = new Button();
            LoginBtn = new Button();
            LogoTXT = new Label();
            pictureBox1 = new PictureBox();
            AdminLoginVBtn = new Button();
            SGuardLoginVBtn = new Button();
            FTitle = new PictureBox();
            FTitleTXT = new Label();
            Title = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(222, 208, 182);
            panel1.Controls.Add(HomeBtn);
            panel1.Controls.Add(InfoTXT);
            panel1.Controls.Add(AboutBtn);
            panel1.Controls.Add(ContactBtn);
            panel1.Controls.Add(StatusBtn);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(LogoTXT);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 680);
            panel1.TabIndex = 0;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.BackgroundImage = (Image)resources.GetObject("HomeBtn.BackgroundImage");
            HomeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            HomeBtn.CausesValidation = false;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = SystemColors.ControlText;
            HomeBtn.Location = new Point(20, 110);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(260, 60);
            HomeBtn.TabIndex = 9;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            HomeBtn.Click += HomeBtn_Click;
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
            // AboutBtn
            // 
            AboutBtn.BackColor = Color.Transparent;
            AboutBtn.BackgroundImage = (Image)resources.GetObject("AboutBtn.BackgroundImage");
            AboutBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AboutBtn.CausesValidation = false;
            AboutBtn.Cursor = Cursors.Hand;
            AboutBtn.FlatAppearance.BorderSize = 0;
            AboutBtn.FlatStyle = FlatStyle.Flat;
            AboutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtn.ForeColor = SystemColors.ControlText;
            AboutBtn.Location = new Point(20, 388);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(260, 60);
            AboutBtn.TabIndex = 7;
            AboutBtn.Text = "About";
            AboutBtn.UseVisualStyleBackColor = false;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // ContactBtn
            // 
            ContactBtn.BackColor = Color.Transparent;
            ContactBtn.BackgroundImage = (Image)resources.GetObject("ContactBtn.BackgroundImage");
            ContactBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ContactBtn.CausesValidation = false;
            ContactBtn.Cursor = Cursors.Hand;
            ContactBtn.FlatAppearance.BorderSize = 0;
            ContactBtn.FlatStyle = FlatStyle.Flat;
            ContactBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtn.ForeColor = SystemColors.ControlText;
            ContactBtn.Location = new Point(20, 318);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Size = new Size(260, 60);
            ContactBtn.TabIndex = 6;
            ContactBtn.Text = "Contact";
            ContactBtn.UseVisualStyleBackColor = false;
            ContactBtn.Click += ContactBtn_Click;
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
            StatusBtn.Location = new Point(20, 248);
            StatusBtn.Name = "StatusBtn";
            StatusBtn.Size = new Size(260, 60);
            StatusBtn.TabIndex = 5;
            StatusBtn.Text = "Status";
            StatusBtn.UseVisualStyleBackColor = false;
            StatusBtn.Click += StatusBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.BackgroundImage = (Image)resources.GetObject("LoginBtn.BackgroundImage");
            LoginBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoginBtn.CausesValidation = false;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ControlText;
            LoginBtn.Location = new Point(20, 179);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(260, 60);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
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
            // AdminLoginVBtn
            // 
            AdminLoginVBtn.BackgroundImage = (Image)resources.GetObject("AdminLoginVBtn.BackgroundImage");
            AdminLoginVBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AdminLoginVBtn.Cursor = Cursors.Hand;
            AdminLoginVBtn.FlatAppearance.BorderSize = 0;
            AdminLoginVBtn.FlatStyle = FlatStyle.Flat;
            AdminLoginVBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLoginVBtn.Location = new Point(459, 206);
            AdminLoginVBtn.Name = "AdminLoginVBtn";
            AdminLoginVBtn.Size = new Size(300, 300);
            AdminLoginVBtn.TabIndex = 1;
            AdminLoginVBtn.UseVisualStyleBackColor = true;
            AdminLoginVBtn.Click += AdminLoginVBtn_Click;
            // 
            // SGuardLoginVBtn
            // 
            SGuardLoginVBtn.BackgroundImage = (Image)resources.GetObject("SGuardLoginVBtn.BackgroundImage");
            SGuardLoginVBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SGuardLoginVBtn.Cursor = Cursors.Hand;
            SGuardLoginVBtn.FlatAppearance.BorderSize = 0;
            SGuardLoginVBtn.FlatStyle = FlatStyle.Flat;
            SGuardLoginVBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SGuardLoginVBtn.Location = new Point(817, 206);
            SGuardLoginVBtn.Name = "SGuardLoginVBtn";
            SGuardLoginVBtn.Size = new Size(300, 300);
            SGuardLoginVBtn.TabIndex = 1;
            SGuardLoginVBtn.UseVisualStyleBackColor = true;
            SGuardLoginVBtn.Click += SGuardLoginVBtn_Click;
            // 
            // FTitle
            // 
            FTitle.BackColor = Color.Transparent;
            FTitle.BackgroundImage = (Image)resources.GetObject("FTitle.BackgroundImage");
            FTitle.BackgroundImageLayout = ImageLayout.Stretch;
            FTitle.Location = new Point(1124, 22);
            FTitle.Name = "FTitle";
            FTitle.Size = new Size(140, 60);
            FTitle.TabIndex = 2;
            FTitle.TabStop = false;
            // 
            // FTitleTXT
            // 
            FTitleTXT.AutoSize = true;
            FTitleTXT.BackColor = Color.FromArgb(187, 171, 140);
            FTitleTXT.FlatStyle = FlatStyle.Flat;
            FTitleTXT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FTitleTXT.ForeColor = SystemColors.ControlText;
            FTitleTXT.Location = new Point(1169, 35);
            FTitleTXT.Name = "FTitleTXT";
            FTitleTXT.Size = new Size(78, 32);
            FTitleTXT.TabIndex = 3;
            FTitleTXT.Text = "Login";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(559, 111);
            Title.Name = "Title";
            Title.Size = new Size(453, 40);
            Title.TabIndex = 4;
            Title.Text = "Choose Your Role To Continue...";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 247, 228);
            ClientSize = new Size(1264, 681);
            Controls.Add(Title);
            Controls.Add(FTitleTXT);
            Controls.Add(FTitle);
            Controls.Add(SGuardLoginVBtn);
            Controls.Add(AdminLoginVBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login | CPMS";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LogoTXT;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private Button StatusBtn;
        private Button AboutBtn;
        private Button ContactBtn;
        private Label InfoTXT;
        private Button HomeBtn;
        private Button AdminLoginVBtn;
        private Button SGuardLoginVBtn;
        private PictureBox FTitle;
        private Label FTitleTXT;
        private Label Title;
    }
}