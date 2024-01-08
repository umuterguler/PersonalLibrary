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
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace WindowsFormsApp_LoginScreen
{
    public partial class MainPage : Form
    {
        public ContentDetails details;


        public bool isUSerListView;

        Funcs funcs = new Funcs();

        SoundPlayer snd = new SoundPlayer();

        UpdateItem uploaditem;

        public Form1 form1Obj;

        public Button button_uploadObj;
        public Button button_logoutObj;

        public Button closeButtonMain;


        public int currentUserID;

        public Label clickedLabel;

        public string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";

        

        public MainPage()
        {
            startingFun();

        }

        public void startingFun()
        {
            InitializeComponent();
            this.Load += MainPage_Load;
            button_uploadObj = button_upload;
            button_logoutObj = button_logout;

            closeButtonMain = closebutton;

            orderbycombobox.SelectedIndex = 0;

            MakeLabelBackgroundOpacity(mainLabel);
            MakeLabelBackgroundOpacity(labelFirst);
            MakeLabelBackgroundOpacity(labelSecond);
            MakeLabelBackgroundOpacity(label1);


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
            gamesLayoutPanel.BackColor = Color.Transparent;
            booksLayoutPanel.BackColor = Color.Transparent;

            currentUserID = getUserId();

            booksLayoutPanel.Controls.Clear();
            gamesLayoutPanel.Controls.Clear();
            moviesLayoutPanel.Controls.Clear();

            AddNewCardsForCategory("movie");
            AddNewCardsForCategory("book");
            AddNewCardsForCategory("game");

            moviesLayoutPanel.Enabled = false;
            gamesLayoutPanel.Enabled = false;
            booksLayoutPanel.Enabled = false;

            moviesLayoutPanel.Visible = false;
            gamesLayoutPanel.Visible = false;
            booksLayoutPanel.Visible = false;


            switch (mainLabel.Text)
            {
                case "Books":

                    booksLayoutPanel.Enabled = true;

                    booksLayoutPanel.Visible = true;

                    break;
                case "Movies":
                    moviesLayoutPanel.Enabled = true;

                    moviesLayoutPanel.Visible = true;

                    break;
                case "Games":
                    gamesLayoutPanel.Enabled = true;

                    gamesLayoutPanel.Visible = true;

                    break;
                // İlgili metin yoksa, varsayılan olarak bir şey yapabilirsiniz.
                default:
                    break;
            }

            userIDCOKGIZLI.Text = getUserId().ToString();


        }

        // MainPage formu içindeki YeniKartEkle metodu
        public void AddNewCardsForCategory(string category)
        {

            string folder = "C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\useruploads\\";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string query = "";

                    switch (orderbycombobox.SelectedItem.ToString())
                    {
                        case "Date":
                            query = $"SELECT * FROM dbo.{category}s WHERE user_id = {currentUserID} ORDER BY {category}_id DESC";
                            break;

                        case "Rate":
                            query = $"SELECT * FROM dbo.{category}s WHERE user_id = {currentUserID} ORDER BY {category}_rate DESC";
                            break;

                        case "Name":
                            query = $"SELECT * FROM dbo.{category}s WHERE user_id = {currentUserID} ORDER BY {category}_title ASC";
                            break;

                        default:
                            // Eğer seçilen bir sıralama kriteri yoksa varsayılan bir durumu belirtin
                            // Örneğin, Date'e göre sıralama yapabilirsiniz.
                            query = $"SELECT * FROM dbo.{category}s WHERE user_id = {currentUserID} ORDER BY {category}_id DESC";
                            break;
                    }




                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Label label = new Label();
                                label.Cursor = Cursors.Hand;


                                label.Text = reader[$"{category}_title"].ToString();
                                label.Font = new Font("Garamond", 18f, FontStyle.Bold);
                                label.Dock = DockStyle.Bottom;
                                label.Size = new Size(210,35);
                                label.BackColor = Color.Black;
                                label.ForeColor = Color.White; // Label rengini siyah olarak ayarla
                                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                                label.Click += (sender, e) => Label_Click(sender, e);

                                PictureBox pictureBox = new PictureBox();
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Dock = DockStyle.Fill;
                                pictureBox.Image = Image.FromFile(folder + reader[$"{category}_image"].ToString());


                                Panel yeniKart = new Panel();
                                yeniKart.Size = new Size(210, 315);
                                yeniKart.BorderStyle = BorderStyle.Fixed3D;
                                yeniKart.Margin = new Padding(0, 0, 20, 15);
                                yeniKart.Controls.Add(pictureBox);
                                yeniKart.Controls.Add(label);
                                

                                label.BringToFront();


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

        public void Label_Click(object sender, EventArgs e)
        {
            // Label tıklandığında yapılmasını istediğiniz işlemleri burada gerçekleştirin.
            // Örneğin:
            clickedLabel = (Label)sender;

            ContentDetails contentDetails = new ContentDetails();
            contentDetails.TakeDetails(clickedLabel.Text, mainLabel.Text);
            contentDetails.currentUserName = label_username.Text;
            contentDetails.Owner = this;
            contentDetails.Show();

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
                                //hicbisey yapma
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

        private void labelFirst_Click(object sender, EventArgs e)
        {


            string labelText = labelFirst.Text;

            // Tüm FlowLayoutPanel'leri gizle
            booksLayoutPanel.Enabled = false;
            moviesLayoutPanel.Enabled = false;
            gamesLayoutPanel.Enabled = false;

            booksLayoutPanel.Visible = false;
            moviesLayoutPanel.Visible = false;
            gamesLayoutPanel.Visible = false;





            // İlgili FlowLayoutPanel'ı görünür yap
            switch (labelText)
            {
                case "Books":
                    booksLayoutPanel.Enabled = true;

                    booksLayoutPanel.Visible = true;

                    if(isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\bookbg.jpg");
                    }

                    break;
                case "Movies":
                    moviesLayoutPanel.Enabled = true;

                    moviesLayoutPanel.Visible = true;

                    if (isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\moviebg.jpg");
                    }

                    break;
                case "Games":
                    gamesLayoutPanel.Enabled = true;

                    gamesLayoutPanel.Visible = true;

                    if (isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\gamebg.jpg");
                    }

                    break;
                // İlgili metin yoksa, varsayılan olarak bir şey yapabilirsiniz.
                default:
                    break;
            }

            string temp = mainLabel.Text;
            mainLabel.Text = labelFirst.Text;
            labelFirst.Text = temp;



        }

        private void labelSecond_Click(object sender, EventArgs e)
        {


            string labelText = labelSecond.Text;

            // Tüm FlowLayoutPanel'leri gizle
            booksLayoutPanel.Enabled = false;
            moviesLayoutPanel.Enabled = false;
            gamesLayoutPanel.Enabled = false;


            booksLayoutPanel.Visible = false;
            moviesLayoutPanel.Visible = false;
            gamesLayoutPanel.Visible = false;

            // İlgili FlowLayoutPanel'ı görünür yap
            switch (labelText)
            {
                case "Books":
                    booksLayoutPanel.Enabled = true;

                    booksLayoutPanel.Visible = true;

                    if (isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\bookbg.jpg");
                    }

                    break;
                case "Movies":
                    moviesLayoutPanel.Enabled = true;

                    moviesLayoutPanel.Visible = true;

                    if (isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\moviebg.jpg");
                    }

                    break;
                case "Games":
                    gamesLayoutPanel.Enabled = true;

                    gamesLayoutPanel.Visible = true;

                    if (isUSerListView == false)
                    {
                        this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\gamebg.jpg");
                    }

                    break;
                // İlgili metin yoksa, varsayılan olarak bir şey yapabilirsiniz.
                default:
                    break;
            }

            string temp = mainLabel.Text;
            mainLabel.Text = labelSecond.Text;
            labelSecond.Text = temp;

        }

        private void orderbycombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainPage_Load(this, e);
        }

 

        

        private void getOtherUsers(string category)
        {
            string folder = "C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\useruploads\\";

            string usernameForSearch = usersCombobox.SelectedItem.ToString();



            string query = "";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                int result = 0;

                if (conn.State == ConnectionState.Open)
                {
                    string userFinderQuery = $"SELECT user_id FROM dbo.users WHERE username = '{usernameForSearch}'";
                    using (SqlCommand cmd = new SqlCommand(userFinderQuery, conn))
                    {
                        result = (int)cmd.ExecuteScalar();
                    }

                        switch (orderbycombobox.SelectedItem.ToString())
                        {
                            case "Date":
                                query = $"SELECT * FROM dbo.{category}s WHERE user_id = {result} ORDER BY {category}_id DESC";
                                break;

                            case "Rate":
                                query = $"SELECT * FROM dbo.{category}s WHERE user_id = {result} ORDER BY {category}_rate DESC";
                                break;

                            case "Name":
                                query = $"SELECT * FROM dbo.{category}s WHERE user_id = {result} ORDER BY {category}_title ASC";
                                break;

                            default:
                                // Eğer seçilen bir sıralama kriteri yoksa varsayılan bir durumu belirtin
                                // Örneğin, Date'e göre sıralama yapabilirsiniz.
                                query = $"SELECT * FROM dbo.{category} WHERE user_id = {result} ORDER BY {category}_title DESC";
                                break;
                        }
                    
                    

                    using (SqlCommand cmd2 = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd2.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Label label = new Label();
                                label.Cursor = Cursors.Hand;


                                label.Text = reader[$"{category}_title"].ToString();
                                label.Font = new Font("Garamond", 18f, FontStyle.Bold);
                                label.Dock = DockStyle.Bottom;
                                label.Size = new Size(210, 35);
                                label.BackColor = Color.Black;
                                label.ForeColor = Color.White; // Label rengini siyah olarak ayarla
                                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                                label.Click += Label_Click;

                                PictureBox pictureBox = new PictureBox();
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Dock = DockStyle.Fill;
                                pictureBox.Image = Image.FromFile(folder + reader[$"{category}_image"].ToString());


                                Panel yeniKart = new Panel();
                                yeniKart.Size = new Size(210, 315);
                                yeniKart.BorderStyle = BorderStyle.Fixed3D;
                                yeniKart.Margin = new Padding(0, 0, 20, 15);
                                yeniKart.Controls.Add(pictureBox);
                                yeniKart.Controls.Add(label);

                                label.BringToFront();


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


        public void MakeLabelBackgroundOpacity(Label label)
        {
            label.BackColor = Color.FromArgb((int)(255 * 0.3), 0, 0, 0);
        }





        private void mylibraryButton_Click(object sender, EventArgs e)
        {
            mainLabel.Text = "Movies";
            labelFirst.Text = "Books";
            labelSecond.Text = "Games";

            isUSerListView = false;

            MainPage_Load(this, e);

            booksLayoutPanel.Visible = true;
            gamesLayoutPanel.Visible = true;
            moviesLayoutPanel.Visible = true;



            orderbycombobox.Visible = true;
            label1.Visible = true;

            usersLabel.Visible = false;
            usersCombobox.Visible = false;

            userlistButton.Enabled = true;

            label_welcome.Enabled = true;
            label_username.Enabled = true;
            button_logout.Enabled = true;
            button_upload.Enabled = true;
            buttonForUnmute.Enabled = true;
            buttonForMute.Enabled = true;


            this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\moviebg.jpg");

            mylibraryButton.Enabled = true;



            mainLabel.Visible = true;
            labelFirst.Visible = true;
            labelSecond.Visible = true;

            usersLabel.Enabled = false;
            usersCombobox.Enabled = false;
        }

        private void usersCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainLabel.Text = "Movies";
            labelFirst.Text = "Books";
            labelSecond.Text = "Games";

            booksLayoutPanel.Controls.Clear();
            gamesLayoutPanel.Controls.Clear();
            moviesLayoutPanel.Controls.Clear();

            getOtherUsers("book");
            getOtherUsers("game");
            getOtherUsers("movie");

            funcs.EnablePanels(this);

            booksLayoutPanel.Visible = true;
            gamesLayoutPanel.Visible = true;
            moviesLayoutPanel.Visible = true;


            mainLabel.Visible = true;
            labelFirst.Visible = true;
            labelSecond.Visible = true;
        }

        private void userlistButton_Click(object sender, EventArgs e)
        {

            usersCombobox.Text = string.Empty;

            usersCombobox.Items.Clear();

            mainLabel.Text = "Movies";
            labelFirst.Text = "Books";
            labelSecond.Text = "Games";


            isUSerListView = true;

            orderbycombobox.Visible = false;
            label1.Visible = false;

            usersCombobox.Visible = true;
            usersLabel.Visible = true;

            booksLayoutPanel.Visible = false;
            gamesLayoutPanel.Visible = false;
            moviesLayoutPanel.Visible = false;

            this.BackgroundImage = Image.FromFile("C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\userlistbg.jpg");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string query = "SELECT * FROM dbo.users ORDER BY username ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usersCombobox.Items.Add(reader["username"].ToString());
                            }
                        }
                    }
                }
            }
            usersLabel.Enabled = true;
            usersCombobox.Enabled = true;


            mylibraryButton.Enabled = true;
            userlistButton.Enabled = false;

            label_welcome.Enabled = false;
            label_username.Enabled = false;
            button_logout.Enabled = false;
            button_upload.Enabled = false;
            buttonForUnmute.Enabled = false;
            buttonForMute.Enabled = false;

            mainLabel.Visible = false;
            labelFirst.Visible = false;
            labelSecond.Visible = false;

        }

        private void buttonForMute_Click(object sender, EventArgs e)
        {
            muteMusicFun();
        }

        private void buttonForUnmute_Click(object sender, EventArgs e)
        {
            unmuteMusicFun();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            uploaditem = new UpdateItem(); // MainPage formunu referans olarak geçiyoruz
            uploaditem.Owner = this;
            uploaditem.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                //snd.Stop();
                Form1 loginscreen = new Form1();
                loginscreen.Show();
                this.Close(); // database ile kontrol edilecek}
            }
        }
    }
}