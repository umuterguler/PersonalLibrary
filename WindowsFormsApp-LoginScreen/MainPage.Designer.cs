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
            this.booksLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFirst = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.gamesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moviesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderbycombobox = new System.Windows.Forms.ComboBox();
            this.userIDCOKGIZLI = new System.Windows.Forms.Label();
            this.labelofapp = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.mylibraryButton = new System.Windows.Forms.Button();
            this.userlistButton = new System.Windows.Forms.Button();
            this.usersCombobox = new System.Windows.Forms.ComboBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonForUnmute = new System.Windows.Forms.Button();
            this.buttonForMute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksLayoutPanel
            // 
            this.booksLayoutPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.booksLayoutPanel.Location = new System.Drawing.Point(71, 130);
            this.booksLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.booksLayoutPanel.Name = "booksLayoutPanel";
            this.booksLayoutPanel.Size = new System.Drawing.Size(1400, 650);
            this.booksLayoutPanel.TabIndex = 6;
            // 
            // labelFirst
            // 
            this.labelFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelFirst.Font = new System.Drawing.Font("Garamond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFirst.ForeColor = System.Drawing.Color.White;
            this.labelFirst.Location = new System.Drawing.Point(1366, 62);
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
            this.mainLabel.Font = new System.Drawing.Font("Garamond", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(72, 51);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(243, 69);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Movies";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecond
            // 
            this.labelSecond.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelSecond.Font = new System.Drawing.Font("Garamond", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSecond.ForeColor = System.Drawing.Color.White;
            this.labelSecond.Location = new System.Drawing.Point(1510, 62);
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
            this.gamesLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gamesLayoutPanel.Name = "gamesLayoutPanel";
            this.gamesLayoutPanel.Size = new System.Drawing.Size(1400, 650);
            this.gamesLayoutPanel.TabIndex = 7;
            // 
            // moviesLayoutPanel
            // 
            this.moviesLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.moviesLayoutPanel.Location = new System.Drawing.Point(71, 130);
            this.moviesLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.moviesLayoutPanel.Name = "moviesLayoutPanel";
            this.moviesLayoutPanel.Size = new System.Drawing.Size(1423, 650);
            this.moviesLayoutPanel.TabIndex = 7;
            // 
            // orderbycombobox
            // 
            this.orderbycombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.orderbycombobox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderbycombobox.ForeColor = System.Drawing.Color.White;
            this.orderbycombobox.FormattingEnabled = true;
            this.orderbycombobox.Items.AddRange(new object[] {
            "Date",
            "Name",
            "Rate"});
            this.orderbycombobox.Location = new System.Drawing.Point(969, 74);
            this.orderbycombobox.Name = "orderbycombobox";
            this.orderbycombobox.Size = new System.Drawing.Size(158, 38);
            this.orderbycombobox.TabIndex = 20;
            this.orderbycombobox.SelectedIndexChanged += new System.EventHandler(this.orderbycombobox_SelectedIndexChanged);
            // 
            // userIDCOKGIZLI
            // 
            this.userIDCOKGIZLI.AutoSize = true;
            this.userIDCOKGIZLI.Location = new System.Drawing.Point(3, 0);
            this.userIDCOKGIZLI.Name = "userIDCOKGIZLI";
            this.userIDCOKGIZLI.Size = new System.Drawing.Size(50, 20);
            this.userIDCOKGIZLI.TabIndex = 36;
            this.userIDCOKGIZLI.Text = "label2";
            // 
            // labelofapp
            // 
            this.labelofapp.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelofapp.ForeColor = System.Drawing.Color.White;
            this.labelofapp.Location = new System.Drawing.Point(3, 0);
            this.labelofapp.Name = "labelofapp";
            this.labelofapp.Size = new System.Drawing.Size(1524, 30);
            this.labelofapp.TabIndex = 5;
            this.labelofapp.Text = "Personal Library";
            this.labelofapp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closebutton.Size = new System.Drawing.Size(40, 35);
            this.closebutton.TabIndex = 0;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Black;
            this.toppanel.Controls.Add(this.closebutton);
            this.toppanel.Controls.Add(this.labelofapp);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1920, 35);
            this.toppanel.TabIndex = 0;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(23, 16);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(104, 26);
            this.label_welcome.TabIndex = 4;
            this.label_welcome.Text = "Welcome";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(140, 14);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(129, 31);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "username";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Black;
            this.button_logout.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(1222, 7);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(210, 45);
            this.button_logout.TabIndex = 37;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Black;
            this.button_upload.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(988, 6);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(211, 46);
            this.button_upload.TabIndex = 38;
            this.button_upload.Text = "Upload Content";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // mylibraryButton
            // 
            this.mylibraryButton.BackColor = System.Drawing.Color.Black;
            this.mylibraryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mylibraryButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mylibraryButton.ForeColor = System.Drawing.Color.White;
            this.mylibraryButton.Location = new System.Drawing.Point(264, 9);
            this.mylibraryButton.Name = "mylibraryButton";
            this.mylibraryButton.Size = new System.Drawing.Size(168, 45);
            this.mylibraryButton.TabIndex = 41;
            this.mylibraryButton.Text = "My Library";
            this.mylibraryButton.UseVisualStyleBackColor = false;
            this.mylibraryButton.Click += new System.EventHandler(this.mylibraryButton_Click);
            // 
            // userlistButton
            // 
            this.userlistButton.BackColor = System.Drawing.Color.Black;
            this.userlistButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.userlistButton.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userlistButton.ForeColor = System.Drawing.Color.White;
            this.userlistButton.Location = new System.Drawing.Point(452, 9);
            this.userlistButton.Name = "userlistButton";
            this.userlistButton.Size = new System.Drawing.Size(174, 45);
            this.userlistButton.TabIndex = 40;
            this.userlistButton.Text = "User List";
            this.userlistButton.UseVisualStyleBackColor = false;
            this.userlistButton.Click += new System.EventHandler(this.userlistButton_Click);
            // 
            // usersCombobox
            // 
            this.usersCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.usersCombobox.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usersCombobox.ForeColor = System.Drawing.Color.White;
            this.usersCombobox.FormattingEnabled = true;
            this.usersCombobox.Location = new System.Drawing.Point(718, 13);
            this.usersCombobox.Name = "usersCombobox";
            this.usersCombobox.Size = new System.Drawing.Size(245, 38);
            this.usersCombobox.TabIndex = 42;
            this.usersCombobox.Visible = false;
            this.usersCombobox.SelectedIndexChanged += new System.EventHandler(this.usersCombobox_SelectedIndexChanged);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usersLabel.ForeColor = System.Drawing.Color.White;
            this.usersLabel.Location = new System.Drawing.Point(644, 21);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(74, 26);
            this.usersLabel.TabIndex = 43;
            this.usersLabel.Text = "Users ";
            this.usersLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonForUnmute);
            this.panel1.Controls.Add(this.buttonForMute);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Controls.Add(this.label_welcome);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.usersCombobox);
            this.panel1.Controls.Add(this.userlistButton);
            this.panel1.Controls.Add(this.button_upload);
            this.panel1.Controls.Add(this.mylibraryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 998);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 57);
            this.panel1.TabIndex = 44;
            // 
            // buttonForUnmute
            // 
            this.buttonForUnmute.BackColor = System.Drawing.Color.Black;
            this.buttonForUnmute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonForUnmute.BackgroundImage")));
            this.buttonForUnmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonForUnmute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonForUnmute.ForeColor = System.Drawing.Color.White;
            this.buttonForUnmute.Location = new System.Drawing.Point(1462, 6);
            this.buttonForUnmute.Name = "buttonForUnmute";
            this.buttonForUnmute.Size = new System.Drawing.Size(54, 46);
            this.buttonForUnmute.TabIndex = 45;
            this.buttonForUnmute.UseVisualStyleBackColor = false;
            this.buttonForUnmute.Visible = false;
            this.buttonForUnmute.Click += new System.EventHandler(this.buttonForUnmute_Click);
            // 
            // buttonForMute
            // 
            this.buttonForMute.BackColor = System.Drawing.Color.Black;
            this.buttonForMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonForMute.BackgroundImage")));
            this.buttonForMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonForMute.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonForMute.ForeColor = System.Drawing.Color.White;
            this.buttonForMute.Location = new System.Drawing.Point(1462, 7);
            this.buttonForMute.Name = "buttonForMute";
            this.buttonForMute.Size = new System.Drawing.Size(54, 46);
            this.buttonForMute.TabIndex = 44;
            this.buttonForMute.UseVisualStyleBackColor = false;
            this.buttonForMute.Click += new System.EventHandler(this.buttonForMute_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(823, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 56);
            this.label1.TabIndex = 35;
            this.label1.Text = "  Order By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userIDCOKGIZLI);
            this.Controls.Add(this.orderbycombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moviesLayoutPanel);
            this.Controls.Add(this.gamesLayoutPanel);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.toppanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel booksLayoutPanel;
        private System.Windows.Forms.Label labelFirst;
        public System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.FlowLayoutPanel gamesLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel moviesLayoutPanel;
        private System.Windows.Forms.ComboBox orderbycombobox;
        public System.Windows.Forms.Label userIDCOKGIZLI;
        private System.Windows.Forms.Label labelofapp;
        private System.Windows.Forms.Button closebutton;
        public System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label label_welcome;
        public System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_upload;
        public System.Windows.Forms.Button mylibraryButton;
        private System.Windows.Forms.Button userlistButton;
        private System.Windows.Forms.ComboBox usersCombobox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonForUnmute;
        private System.Windows.Forms.Button buttonForMute;
    }
}