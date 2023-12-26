namespace WindowsFormsApp_LoginScreen
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.toppanel = new System.Windows.Forms.Panel();
            this.labelofapp = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.navbar = new System.Windows.Forms.Panel();
            this.buttonForMute = new System.Windows.Forms.Button();
            this.buttonForUnmute = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.booksLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFirst = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.gamesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moviesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toppanel.SuspendLayout();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Black;
            this.toppanel.Controls.Add(this.labelofapp);
            this.toppanel.Controls.Add(this.closebutton);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1920, 39);
            this.toppanel.TabIndex = 0;
            // 
            // labelofapp
            // 
            this.labelofapp.AutoSize = true;
            this.labelofapp.ForeColor = System.Drawing.Color.White;
            this.labelofapp.Location = new System.Drawing.Point(3, 10);
            this.labelofapp.Name = "labelofapp";
            this.labelofapp.Size = new System.Drawing.Size(113, 20);
            this.labelofapp.TabIndex = 5;
            this.labelofapp.Text = "Personal Library";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Black;
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closebutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Location = new System.Drawing.Point(1880, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(40, 39);
            this.closebutton.TabIndex = 0;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.Black;
            this.navbar.Controls.Add(this.buttonForMute);
            this.navbar.Controls.Add(this.buttonForUnmute);
            this.navbar.Controls.Add(this.button_upload);
            this.navbar.Controls.Add(this.label_username);
            this.navbar.Controls.Add(this.label_welcome);
            this.navbar.Controls.Add(this.button_logout);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navbar.Location = new System.Drawing.Point(0, 1009);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1920, 46);
            this.navbar.TabIndex = 2;
            // 
            // buttonForMute
            // 
            this.buttonForMute.Image = ((System.Drawing.Image)(resources.GetObject("buttonForMute.Image")));
            this.buttonForMute.Location = new System.Drawing.Point(1487, 0);
            this.buttonForMute.Name = "buttonForMute";
            this.buttonForMute.Size = new System.Drawing.Size(40, 46);
            this.buttonForMute.TabIndex = 8;
            this.buttonForMute.UseVisualStyleBackColor = true;
            this.buttonForMute.Click += new System.EventHandler(this.buttonForMute_Click);
            // 
            // buttonForUnmute
            // 
            this.buttonForUnmute.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonForUnmute.Enabled = false;
            this.buttonForUnmute.Image = ((System.Drawing.Image)(resources.GetObject("buttonForUnmute.Image")));
            this.buttonForUnmute.Location = new System.Drawing.Point(1487, 0);
            this.buttonForUnmute.Name = "buttonForUnmute";
            this.buttonForUnmute.Size = new System.Drawing.Size(40, 46);
            this.buttonForUnmute.TabIndex = 7;
            this.buttonForUnmute.UseVisualStyleBackColor = true;
            this.buttonForUnmute.Visible = false;
            this.buttonForUnmute.Click += new System.EventHandler(this.buttonForUnmute_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Black;
            this.button_upload.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(1527, 0);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(211, 46);
            this.button_upload.TabIndex = 5;
            this.button_upload.Text = "Upload Content";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(66, 13);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(98, 27);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "username";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(3, 18);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(71, 20);
            this.label_welcome.TabIndex = 4;
            this.label_welcome.Text = "Welcome";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Black;
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(1738, 0);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(182, 46);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // booksLayoutPanel
            // 
            this.booksLayoutPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.booksLayoutPanel.Location = new System.Drawing.Point(71, 130);
            this.booksLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.booksLayoutPanel.Name = "booksLayoutPanel";
            this.booksLayoutPanel.Size = new System.Drawing.Size(1400, 650);
            this.booksLayoutPanel.TabIndex = 6;
            // 
            // labelFirst
            // 
            this.labelFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelFirst.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFirst.ForeColor = System.Drawing.Color.White;
            this.labelFirst.Location = new System.Drawing.Point(1352, 64);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(128, 56);
            this.labelFirst.TabIndex = 7;
            this.labelFirst.Text = "Books";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFirst.Click += new System.EventHandler(this.labelFirst_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Ink Free", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(57, 42);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(310, 88);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Movies";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecond
            // 
            this.labelSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelSecond.Font = new System.Drawing.Font("Ink Free", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelSecond.ForeColor = System.Drawing.Color.White;
            this.labelSecond.Location = new System.Drawing.Point(1486, 64);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(128, 56);
            this.labelSecond.TabIndex = 13;
            this.labelSecond.Text = "Games";
            this.labelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSecond.Click += new System.EventHandler(this.labelSecond_Click);
            // 
            // gamesLayoutPanel
            // 
            this.gamesLayoutPanel.BackColor = System.Drawing.Color.IndianRed;
            this.gamesLayoutPanel.Location = new System.Drawing.Point(71, 130);
            this.gamesLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.gamesLayoutPanel.Name = "gamesLayoutPanel";
            this.gamesLayoutPanel.Size = new System.Drawing.Size(1400, 650);
            this.gamesLayoutPanel.TabIndex = 7;
            // 
            // moviesLayoutPanel
            // 
            this.moviesLayoutPanel.BackColor = System.Drawing.Color.Gray;
            this.moviesLayoutPanel.Location = new System.Drawing.Point(71, 130);
            this.moviesLayoutPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.moviesLayoutPanel.Name = "moviesLayoutPanel";
            this.moviesLayoutPanel.Size = new System.Drawing.Size(1400, 650);
            this.moviesLayoutPanel.TabIndex = 7;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.moviesLayoutPanel);
            this.Controls.Add(this.gamesLayoutPanel);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.booksLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label labelofapp;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_welcome;
        public System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.FlowLayoutPanel booksLayoutPanel;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Button buttonForMute;
        private System.Windows.Forms.Button buttonForUnmute;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.FlowLayoutPanel gamesLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel moviesLayoutPanel;
    }
}