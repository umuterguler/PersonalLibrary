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

namespace WindowsFormsApp_LoginScreen
{
    public partial class Form1 : Form
    {
        

        private bool musicPlaying = true;
        SoundPlayer snd = new SoundPlayer();
        MainPage mnpg;
        CreateAccount crtacc;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15;
            path.AddArc(0, 0, radius, radius, 180, 90); 
            path.AddArc(this.Width - radius,0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
              
             

            this.Region = new Region(path);

            
            string dizin = Application.StartupPath + "\\music.wav";
            snd.SoundLocation = dizin;
            snd.PlayLooping();



        }


        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                snd.Stop();
            Close();

        }

        private void pictureBox_mute_Click(object sender, EventArgs e)
        {

            if (musicPlaying == true)
            {
                snd.Stop();
                musicPlaying = false;
            }
            else
            {
                snd.Play();
                musicPlaying = true;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {   // burda database ile kullanıcı adı sıfre kontrol edılıp girilecek simdilik bos olmamasını sagladım tabı bu yetersız
            if (textBox_username.Text != "" && textBox_password.Text != "")
            {
                mnpg = new MainPage();
                mnpg.Owner = this;
                mnpg.Show();
                this.Hide();
                mnpg.label_username.Text = textBox_username.Text;
            }
            else // burda databasede boyle bırı olup olmadıgı kontrol edılecek kullanıcı adı ve sıfre kontrolu yapılcak o hatalı veya bu hatalı
            {
                MessageBox.Show("Account Not Found or Username or Password is Incorrect", "Error");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            crtacc = new CreateAccount();
            crtacc.Owner = this;
            crtacc.Show();
        }
    }
}
