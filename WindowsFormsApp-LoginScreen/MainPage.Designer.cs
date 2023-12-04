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
            this.button_upload = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.picturebox_Mute = new System.Windows.Forms.PictureBox();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.labelofcaption = new System.Windows.Forms.Label();
            this.myFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toppanel.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Mute)).BeginInit();
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
            this.toppanel.Size = new System.Drawing.Size(1275, 39);
            this.toppanel.TabIndex = 0;
            // 
            // labelofapp
            // 
            this.labelofapp.AutoSize = true;
            this.labelofapp.ForeColor = System.Drawing.Color.White;
            this.labelofapp.Location = new System.Drawing.Point(3, 10);
            this.labelofapp.Name = "labelofapp";
            this.labelofapp.Size = new System.Drawing.Size(91, 15);
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
            this.closebutton.Location = new System.Drawing.Point(1235, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(40, 39);
            this.closebutton.TabIndex = 0;
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.Black;
            this.navbar.Controls.Add(this.button_upload);
            this.navbar.Controls.Add(this.label_username);
            this.navbar.Controls.Add(this.picturebox_Mute);
            this.navbar.Controls.Add(this.label_welcome);
            this.navbar.Controls.Add(this.button_logout);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navbar.Location = new System.Drawing.Point(0, 661);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1275, 46);
            this.navbar.TabIndex = 2;
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Black;
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(1026, 14);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(104, 23);
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
            this.label_username.Size = new System.Drawing.Size(76, 22);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "username";
            // 
            // picturebox_Mute
            // 
            this.picturebox_Mute.BackColor = System.Drawing.Color.White;
            this.picturebox_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox_Mute.ErrorImage = null;
            this.picturebox_Mute.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_Mute.Image")));
            this.picturebox_Mute.Location = new System.Drawing.Point(1237, 11);
            this.picturebox_Mute.Name = "picturebox_Mute";
            this.picturebox_Mute.Size = new System.Drawing.Size(26, 27);
            this.picturebox_Mute.TabIndex = 3;
            this.picturebox_Mute.TabStop = false;
            this.picturebox_Mute.Click += new System.EventHandler(this.picturebox_Mute_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(3, 18);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(57, 15);
            this.label_welcome.TabIndex = 4;
            this.label_welcome.Text = "Welcome";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Black;
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(1146, 15);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // labelofcaption
            // 
            this.labelofcaption.AutoSize = true;
            this.labelofcaption.BackColor = System.Drawing.Color.Transparent;
            this.labelofcaption.Font = new System.Drawing.Font("Ink Free", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelofcaption.ForeColor = System.Drawing.Color.Linen;
            this.labelofcaption.Location = new System.Drawing.Point(12, 42);
            this.labelofcaption.Name = "labelofcaption";
            this.labelofcaption.Size = new System.Drawing.Size(255, 60);
            this.labelofcaption.TabIndex = 4;
            this.labelofcaption.Text = "My Library";
            // 
            // myFlowLayoutPanel
            // 
            this.myFlowLayoutPanel.AutoScroll = true;
            this.myFlowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.myFlowLayoutPanel.Location = new System.Drawing.Point(16, 129);
            this.myFlowLayoutPanel.Name = "myFlowLayoutPanel";
            this.myFlowLayoutPanel.Size = new System.Drawing.Size(1221, 500);
            this.myFlowLayoutPanel.TabIndex = 5;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 707);
            this.Controls.Add(this.myFlowLayoutPanel);
            this.Controls.Add(this.labelofcaption);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.toppanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Mute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label labelofapp;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.PictureBox picturebox_Mute;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_welcome;
        public System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Label labelofcaption;
        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel;
    }
}