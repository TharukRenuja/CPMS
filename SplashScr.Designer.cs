namespace CPMS
{
    partial class splashScr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScr));
            SPicBox = new PictureBox();
            label1 = new Label();
            STitle = new Label();
            SsubTitle = new Label();
            SInfoTxt = new Label();
            panel1 = new Panel();
            SprogressBar = new ProgressBar();
            SLoadTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)SPicBox).BeginInit();
            SuspendLayout();
            // 
            // SPicBox
            // 
            SPicBox.BackColor = Color.Transparent;
            SPicBox.BackgroundImage = (Image)resources.GetObject("SPicBox.BackgroundImage");
            SPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            SPicBox.Location = new Point(0, 43);
            SPicBox.Name = "SPicBox";
            SPicBox.Size = new Size(350, 139);
            SPicBox.TabIndex = 0;
            SPicBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(16, 114, 185);
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Cooper Black", 20.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 4;
            label1.Text = "Car Parking";
            // 
            // STitle
            // 
            STitle.AutoSize = true;
            STitle.BackColor = Color.FromArgb(16, 114, 185);
            STitle.Cursor = Cursors.AppStarting;
            STitle.Font = new Font("Cooper Black", 20.25F);
            STitle.ForeColor = Color.White;
            STitle.Location = new Point(26, 86);
            STitle.Name = "STitle";
            STitle.Size = new Size(294, 31);
            STitle.TabIndex = 5;
            STitle.Text = "Management System";
            // 
            // SsubTitle
            // 
            SsubTitle.AutoSize = true;
            SsubTitle.BackColor = Color.FromArgb(16, 114, 185);
            SsubTitle.Cursor = Cursors.AppStarting;
            SsubTitle.Font = new Font("Ebrima", 14.25F);
            SsubTitle.ForeColor = Color.White;
            SsubTitle.Location = new Point(26, 119);
            SsubTitle.Name = "SsubTitle";
            SsubTitle.Size = new Size(130, 25);
            SsubTitle.TabIndex = 6;
            SsubTitle.Text = "XYZ Company";
            // 
            // SInfoTxt
            // 
            SInfoTxt.AutoSize = true;
            SInfoTxt.BackColor = Color.FromArgb(16, 114, 185);
            SInfoTxt.Cursor = Cursors.AppStarting;
            SInfoTxt.Font = new Font("Dubai", 9.749999F);
            SInfoTxt.ForeColor = Color.White;
            SInfoTxt.Location = new Point(26, 153);
            SInfoTxt.Name = "SInfoTxt";
            SInfoTxt.Size = new Size(170, 22);
            SInfoTxt.TabIndex = 7;
            SInfoTxt.Text = "Project By DiIT 01 - Group 05";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 114, 185);
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 10);
            panel1.TabIndex = 9;
            // 
            // SprogressBar
            // 
            SprogressBar.BackColor = Color.White;
            SprogressBar.ForeColor = SystemColors.Control;
            SprogressBar.Location = new Point(0, 350);
            SprogressBar.Name = "SprogressBar";
            SprogressBar.Size = new Size(700, 10);
            SprogressBar.TabIndex = 8;
            // 
            // SLoadTimer
            // 
            SLoadTimer.Enabled = true;
            SLoadTimer.Interval = 15;
            SLoadTimer.Tick += timer1_Tick;
            // 
            // splashScr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 360);
            Controls.Add(panel1);
            Controls.Add(SprogressBar);
            Controls.Add(SInfoTxt);
            Controls.Add(SsubTitle);
            Controls.Add(STitle);
            Controls.Add(label1);
            Controls.Add(SPicBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "splashScr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            Load += splashScr_Load;
            ((System.ComponentModel.ISupportInitialize)SPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox SPicBox;
        private Label label1;
        private Label STitle;
        private Label SsubTitle;
        private Label SInfoTxt;
        private Panel panel1;
        private ProgressBar SprogressBar;
        private System.Windows.Forms.Timer SLoadTimer;
    }
}
