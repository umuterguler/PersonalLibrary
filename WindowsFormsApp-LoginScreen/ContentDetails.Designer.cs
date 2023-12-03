namespace WindowsFormsApp_LoginScreen
{
    partial class ContentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_details = new System.Windows.Forms.Label();
            this.labelofitem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_item = new System.Windows.Forms.PictureBox();
            this.label_content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label_details);
            this.panel1.Controls.Add(this.labelofitem);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 39);
            this.panel1.TabIndex = 0;
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.ForeColor = System.Drawing.Color.White;
            this.label_details.Location = new System.Drawing.Point(73, 13);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(39, 13);
            this.label_details.TabIndex = 2;
            this.label_details.Text = "Details";
            // 
            // labelofitem
            // 
            this.labelofitem.AutoSize = true;
            this.labelofitem.ForeColor = System.Drawing.Color.White;
            this.labelofitem.Location = new System.Drawing.Point(13, 13);
            this.labelofitem.Name = "labelofitem";
            this.labelofitem.Size = new System.Drawing.Size(57, 13);
            this.labelofitem.TabIndex = 1;
            this.labelofitem.Text = "labelofitem";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(395, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 39);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Ink Free", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(151, 42);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(130, 60);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Title";
            // 
            // pictureBox_item
            // 
            this.pictureBox_item.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_item.Location = new System.Drawing.Point(43, 105);
            this.pictureBox_item.Name = "pictureBox_item";
            this.pictureBox_item.Size = new System.Drawing.Size(344, 232);
            this.pictureBox_item.TabIndex = 2;
            this.pictureBox_item.TabStop = false;
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.BackColor = System.Drawing.Color.Transparent;
            this.label_content.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_content.ForeColor = System.Drawing.Color.Black;
            this.label_content.Location = new System.Drawing.Point(84, 353);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(121, 37);
            this.label_content.TabIndex = 3;
            this.label_content.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(211, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.Transparent;
            this.label_type.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(254, 353);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(79, 37);
            this.label_type.TabIndex = 5;
            this.label_type.Text = "Type";
            // 
            // textBox_comment
            // 
            this.textBox_comment.BackColor = System.Drawing.Color.Black;
            this.textBox_comment.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_comment.ForeColor = System.Drawing.Color.Bisque;
            this.textBox_comment.Location = new System.Drawing.Point(43, 432);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_comment.Size = new System.Drawing.Size(344, 189);
            this.textBox_comment.TabIndex = 7;
            this.textBox_comment.Text = "bu text silincek burası comment için";
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.BackColor = System.Drawing.Color.Black;
            this.label_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_rate.ForeColor = System.Drawing.Color.Yellow;
            this.label_rate.Location = new System.Drawing.Point(310, 291);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(29, 31);
            this.label_rate.TabIndex = 8;
            this.label_rate.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(339, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ContentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.pictureBox_item);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_title;
        public System.Windows.Forms.PictureBox pictureBox_item;
        public System.Windows.Forms.Label label_content;
        public System.Windows.Forms.Label label_type;
        public System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_rate;
        public System.Windows.Forms.Label labelofitem;
    }
}