namespace WindowsFormsApp_LoginScreen
{
    partial class UpdateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_upload = new System.Windows.Forms.PictureBox();
            this.button_selectphoto = new System.Windows.Forms.Button();
            this.button_saveupload = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.label_comment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.label_content = new System.Windows.Forms.Label();
            this.comboBox_content = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_upload)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 41);
            this.panel1.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Black;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(456, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(33, 41);
            this.button_close.TabIndex = 2;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upload Content";
            // 
            // pictureBox_upload
            // 
            this.pictureBox_upload.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_upload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_upload.Location = new System.Drawing.Point(28, 55);
            this.pictureBox_upload.Name = "pictureBox_upload";
            this.pictureBox_upload.Size = new System.Drawing.Size(433, 258);
            this.pictureBox_upload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_upload.TabIndex = 1;
            this.pictureBox_upload.TabStop = false;
            // 
            // button_selectphoto
            // 
            this.button_selectphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button_selectphoto.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_selectphoto.ForeColor = System.Drawing.Color.White;
            this.button_selectphoto.Location = new System.Drawing.Point(28, 320);
            this.button_selectphoto.Name = "button_selectphoto";
            this.button_selectphoto.Size = new System.Drawing.Size(433, 42);
            this.button_selectphoto.TabIndex = 2;
            this.button_selectphoto.Text = "Select Photo";
            this.button_selectphoto.UseVisualStyleBackColor = false;
            this.button_selectphoto.Click += new System.EventHandler(this.button_selectphoto_Click);
            // 
            // button_saveupload
            // 
            this.button_saveupload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button_saveupload.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_saveupload.ForeColor = System.Drawing.Color.White;
            this.button_saveupload.Location = new System.Drawing.Point(249, 629);
            this.button_saveupload.Name = "button_saveupload";
            this.button_saveupload.Size = new System.Drawing.Size(212, 39);
            this.button_saveupload.TabIndex = 3;
            this.button_saveupload.Text = "Save";
            this.button_saveupload.UseVisualStyleBackColor = false;
            this.button_saveupload.Click += new System.EventHandler(this.button_saveupload_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_title.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(28, 398);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(50, 22);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Title:";
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_comment.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_comment.ForeColor = System.Drawing.Color.White;
            this.label_comment.Location = new System.Drawing.Point(249, 398);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(91, 22);
            this.label_comment.TabIndex = 5;
            this.label_comment.Text = "Comment:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(28, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 30);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(249, 425);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(212, 169);
            this.textBox2.TabIndex = 7;
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_rate.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_rate.ForeColor = System.Drawing.Color.White;
            this.label_rate.Location = new System.Drawing.Point(28, 612);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(49, 22);
            this.label_rate.TabIndex = 9;
            this.label_rate.Text = "Rate:";
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_content.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_content.ForeColor = System.Drawing.Color.White;
            this.label_content.Location = new System.Drawing.Point(28, 467);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(77, 22);
            this.label_content.TabIndex = 10;
            this.label_content.Text = "Content:";
            // 
            // comboBox_content
            // 
            this.comboBox_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_content.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_content.ForeColor = System.Drawing.Color.White;
            this.comboBox_content.FormattingEnabled = true;
            this.comboBox_content.Items.AddRange(new object[] {
            "Book",
            "Movie",
            "Game"});
            this.comboBox_content.Location = new System.Drawing.Point(28, 493);
            this.comboBox_content.Name = "comboBox_content";
            this.comboBox_content.Size = new System.Drawing.Size(169, 30);
            this.comboBox_content.TabIndex = 11;
            this.comboBox_content.SelectedIndexChanged += new System.EventHandler(this.comboBox_content_SelectedIndexChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label_type.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(28, 539);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(52, 22);
            this.label_type.TabIndex = 12;
            this.label_type.Text = "Type:";
            // 
            // comboBox_type
            // 
            this.comboBox_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_type.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_type.ForeColor = System.Drawing.Color.White;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(28, 566);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(169, 30);
            this.comboBox_type.TabIndex = 13;
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox_rate.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_rate.ForeColor = System.Drawing.Color.White;
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_rate.Location = new System.Drawing.Point(28, 638);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(169, 30);
            this.comboBox_rate.TabIndex = 14;
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 738);
            this.Controls.Add(this.comboBox_rate);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_content);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_saveupload);
            this.Controls.Add(this.button_selectphoto);
            this.Controls.Add(this.pictureBox_upload);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdateItem";
            this.Text = "UpdateItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_upload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_selectphoto;
        public System.Windows.Forms.Button button_saveupload;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.Label label_type;
        public System.Windows.Forms.PictureBox pictureBox_upload;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.ComboBox comboBox_content;
        public System.Windows.Forms.ComboBox comboBox_type;
        public System.Windows.Forms.ComboBox comboBox_rate;
    }
}