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

        UpdateItem uploaditem;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Diğer yüklemeler burada devam eder...

            // Ana form ayarları burada devam eder...

        }

        // MainPage formu içindeki YeniKartEkle metodu
        public void AddNewCard(string isim, string fotoYolu)
        {
            // Yeni bir kart oluştur
            Panel yeniKart = new Panel();
            yeniKart.Size = new Size(200, 300); // İstediğiniz boyutları ayarlayabilirsiniz
            yeniKart.BorderStyle = BorderStyle.Fixed3D; // Çerçeve rengi için bu satır eklenmiştir

            // Kart içerisindeki Label oluştur
            Label label = new Label();
            label.Text = isim;
            label.Dock = DockStyle.Top;

            // Kart içerisindeki PictureBox oluştur
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(fotoYolu);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;

            // Kart içerisine Label ve PictureBox eklenmesi
            yeniKart.Controls.Add(pictureBox);
            yeniKart.Controls.Add(label);

            // Büyük Panel'e yeni kartın eklenmesi
            myFlowLayoutPanel.Controls.Add(yeniKart);

        }


        private void closebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
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
            uploaditem = new UpdateItem(this); // MainPage formunu referans olarak geçiyoruz
            uploaditem.Owner = this;
            uploaditem.Show();
        }

        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // linklabellere tıklandığında content details penceresi açılmalı ve update itemdeki veriler databaseden buraya aktarılmalı
            details = new ContentDetails();
            details.Owner = this;
            details.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // picboxlara tıklandığında content details penceresi açılmalı ve update itemdeki veriler databaseden buraya aktarılmalı
            details = new ContentDetails();
            details.Owner = this;
            details.Show();
        }
    }
}

 
