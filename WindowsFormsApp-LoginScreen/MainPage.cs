using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp_LoginScreen
{
    public partial class MainPage : Form
    {
        ContentDetails details;
        private bool musicPlaying = true;
        SoundPlayer snd = new SoundPlayer();

        Form1 loginscreen;
        UpdateItem uploaditem;

        public MainPage()
        {
            InitializeComponent();

            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                int radius = 15;
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);



                this.Region = new Region(path);


                string dizin = Application.StartupPath + "\\mainpagemusic.wav";
                snd.SoundLocation = dizin;
                snd.PlayLooping();

                


        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                this.Close();

        }

       

        private void picturebox_Mute_Click(object sender, EventArgs e)
        {
            if (musicPlaying == true)
            {
                snd.Stop();
                musicPlaying = false;
            }
            else
            {
                snd.PlayLooping();
                musicPlaying = true;
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            snd.Stop();
            Form1 loginscreen = new Form1();
            loginscreen.Show();
            this.Close(); // database ile kontrol edilecek
            
            
            
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            uploaditem = new UpdateItem();
            uploaditem.Owner = this;
            uploaditem.Show();
        }

        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //linklabellere e tıklandıgında content details penceresi açılmalı ve update itemdeki veriler databaseden buraya aktarılmalı
            details = new ContentDetails();
            details.Owner = this;
            details.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   //picboxlara e tıklandıgında content details penceresi açılmalı ve update itemdeki veriler databaseden buraya aktarılmalı
            details = new ContentDetails();
            details.Owner = this;
            details.Show();
        }
    }
    }

 
