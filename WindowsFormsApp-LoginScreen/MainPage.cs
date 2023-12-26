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
using Button = System.Windows.Forms.Button;
using ContentAlignment = System.Drawing.ContentAlignment;
using System.Data.SqlClient;

namespace WindowsFormsApp_LoginScreen
{
    public partial class MainPage : Form
    {
        ContentDetails details;
        private bool musicPlaying;

        SoundPlayer snd = new SoundPlayer();

        UpdateItem uploaditem;

        public Form1 form1Obj;

        public Button button_uploadObj;
        public Button button_logoutObj;

        public Button closeButtonMain;

        SqlConnection conn;

        public int currentUserID;

        public string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";

        public MainPage()
        {
            InitializeComponent();
            this.Load += MainPage_Load;
            button_uploadObj = button_upload;
            button_logoutObj = button_logout;

            closeButtonMain = closebutton;

            // musicPlaying değerini kontrol et ve duruma göre düğmeleri ayarla
            if (form1Obj != null)
            {
                musicPlaying = form1Obj.musicPlaying;
                
                if (musicPlaying)
                {
                    buttonForUnmute.Enabled = false;
                    buttonForUnmute.Visible = false;
                    buttonForMute.Enabled = true;
                    buttonForMute.Visible = true;
                }
                else
                {
                    buttonForMute.Enabled = false;
                    buttonForMute.Visible = false;
                    buttonForUnmute.Enabled = true;
                    buttonForUnmute.Visible = true;
                }
            }

            string dizin = Application.StartupPath + "\\mainpagemusic.wav";
            snd.SoundLocation = dizin;
            snd.PlayLooping();
        }



        public void MakeButtonEnabled(Button incomingButton)
        {
            incomingButton.Enabled = true;
        }

        public void MakeButtonDisabled(Button incomingButton)
        {
            incomingButton.Enabled = false;
        }



        public void MainPage_Load(object sender, EventArgs e)
        {
            // Diğer yüklemeler burada devam eder...
            this.WindowState = FormWindowState.Maximized;

            currentUserID = getUserId();

            booksLayoutPanel.Controls.Clear();
            gamesLayoutPanel.Controls.Clear();
            moviesLayoutPanel.Controls.Clear();

            AddNewCardsForCategory("movie");
            AddNewCardsForCategory("book");
            AddNewCardsForCategory("game");

            booksLayoutPanel.AutoScroll = true;
            gamesLayoutPanel.AutoScroll = true;
            moviesLayoutPanel.AutoScroll = true;

            booksLayoutPanel.VerticalScroll.Visible = false;
            gamesLayoutPanel.VerticalScroll.Visible = false;
            moviesLayoutPanel.VerticalScroll.Visible = false;
            // Ana form ayarları burada devam eder...
        }

        // MainPage formu içindeki YeniKartEkle metodu
        public void AddNewCardsForCategory(string category)
        {

            string folder = "C:\\Users\\Melih\\source\\repos\\PersonalLibrary1\\loginscreen-assets\\useruploads\\";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string query = $"SELECT * FROM dbo.{category}s WHERE user_id = {currentUserID}";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Label label = new Label();
                                label.Text = reader[$"{category}_title"].ToString();
                                label.Dock = DockStyle.Bottom;
                                label.BackColor = Color.Black;
                                label.ForeColor = Color.White; // Label rengini siyah olarak ayarla
                                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                                PictureBox pictureBox = new PictureBox();
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Dock = DockStyle.Fill;
                                pictureBox.Image = Image.FromFile(folder + reader[$"{category}_image"].ToString());

                                Panel yeniKart = new Panel();
                                yeniKart.Size = new Size(175, 262);
                                yeniKart.BorderStyle = BorderStyle.Fixed3D;
                                yeniKart.Controls.Add(pictureBox);
                                yeniKart.Controls.Add(label);



                                // Büyük Panel'e yeni kartın eklenmesi
                                if (category == "book")
                                {
                                    //Book
                                    booksLayoutPanel.Controls.Add(yeniKart);
                                }
                                else if (category == "movie")
                                {
                                    //Movie
                                    moviesLayoutPanel.Controls.Add(yeniKart);
                                }
                                else if (category == "game")
                                {
                                    //Game
                                    gamesLayoutPanel.Controls.Add(yeniKart);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                //tüm uygulamayı kapatır.
                Application.Exit();
            }
        }



        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                snd.Stop();
                Form1 loginscreen = new Form1();
                loginscreen.Show();
                this.Close(); // database ile kontrol edilecek}
            }
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

        private void booksLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonForMute_Click(object sender, EventArgs e)
        {
            muteMusicFun();
        }

        private void buttonForUnmute_Click(object sender, EventArgs e)
        {
            unmuteMusicFun();
        }

        public void muteMusicFun()
        {
            snd.Stop();
            buttonForMute.Enabled = false;
            buttonForMute.Visible = false;

            buttonForUnmute.Enabled = true;
            buttonForUnmute.Visible = true;
        }

        public void unmuteMusicFun()
        {
            string dizin = Application.StartupPath + "\\mainpagemusic.wav";
            snd.SoundLocation = dizin;
            snd.PlayLooping();
            buttonForUnmute.Enabled = false;
            buttonForUnmute.Visible = false;

            buttonForMute.Enabled = true;
            buttonForMute.Visible = true;
        }

        public int getUserId()
        {
            int userID = 0;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string username = label_username.Text;


                    if (!string.IsNullOrEmpty(username))
                    {
                        string query = "SELECT user_id FROM dbo.users WHERE username = '" + username + "'";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {


                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                userID = Convert.ToInt32(result);

                                return userID;
                            }
                            else
                            {

                                MessageBox.Show("ID ALINAMADI.");

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı boş veya null.");
                    }
                }
                else
                {
                    MessageBox.Show("There is an error");
                }
            }

            return userID;
        }
    }
}

 
