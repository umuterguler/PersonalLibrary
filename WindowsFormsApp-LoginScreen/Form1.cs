using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp_LoginScreen
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;

        SoundPlayer snd = new SoundPlayer();
        MainPage mnpg;
        CreateAccount crtacc;

        public Form1()
        {
            InitializeComponent();
            string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";
            conn = new SqlConnection(connString);

            // Butonun arka plan rengini belirle
            muteButtonForm1.BackColor = Color.FromArgb(75, 255, 255, 255); // 128 = Opacity (0-255), sonraki üç parametre RGB renk değerleri
            unmuteButtonForm1.BackColor = Color.FromArgb(75, 255, 255, 255); // 128 = Opacity (0-255), sonraki üç parametre RGB renk değerleri

            // Eğer butonun kenarlığını görmek istemiyorsanız, FlatStyle özelliğini Flat yapabilirsiniz
            muteButtonForm1.FlatStyle = FlatStyle.Flat;
            unmuteButtonForm1.FlatStyle = FlatStyle.Flat;
        }


        private bool IsEmailValid(string email)
        {
            return email.Length >= 5;
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8 && password.Any(char.IsDigit);
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
                Application.Exit();

        }

        

        private void button_login_Click(object sender, EventArgs e)
        {   
            if (IsEmailValid(textBox_username.Text) && IsPasswordValid(textBox_password.Text))
            {
                if (checkUserLogin(textBox_username.Text, textBox_password.Text))
                {
                    mnpg = new MainPage();
                    mnpg.form1Obj = this; // Form1 referansını MainPage formuna aktar
                    mnpg.Owner = this;
                    this.Hide();

                    mnpg.label_username.Text = textBox_username.Text;
                    mnpg.Show();

                }
                else
                {
                    MessageBox.Show("Account Not Found or Username or Password is Incorrect", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password format. Please check your inputs.", "Error");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            crtacc = new CreateAccount();
            crtacc.Owner = this;
            crtacc.Show();
        }

        

        public void muteMusicFun()
        {
            snd.Stop();
            muteButtonForm1.Enabled = false;
            muteButtonForm1.Visible = false;

            unmuteButtonForm1.Enabled = true;
            unmuteButtonForm1.Visible = true;

        }

        public void unmuteMusicFun()
        {
            string dizin = Application.StartupPath + "\\music.wav";
            snd.SoundLocation = dizin;
            snd.PlayLooping();
            unmuteButtonForm1.Enabled = false;
            unmuteButtonForm1.Visible = false;

            muteButtonForm1.Enabled = true;
            muteButtonForm1.Visible = true;

        }
        private bool checkUserLogin(string username, string password)
        {
            try
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userNumber = (int)command.ExecuteScalar();

                    return userNumber > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                snd.Dispose();
            }

            base.Dispose(disposing);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword();


        }

        public void forgotPassword()
        {
            conn.Open();

            string takenUsername = textBox_username.Text;

            string query = $"SELECT * FROM users WHERE username = '{takenUsername}'";


                using (SqlCommand command = new SqlCommand(query, conn))
                {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string takenPassword = reader.GetString(2);

                            MessageBox.Show("Requirements are done. Password is sended to your mail. (" + takenPassword + ")");

                            textBox_password.Text = takenPassword;
                            query = string.Empty;

                        }
                    }
                    else
                    {
                        if (takenUsername != "")
                        {
                            MessageBox.Show("There is no user that match with: " + takenUsername);
                            textBox_password.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("You have to fill username field.");

                        }



                    }
                }
            
            }
            conn.Close();
        }

        private void unmuteButtonForm1_Click(object sender, EventArgs e)
        {
            unmuteMusicFun();
        }

        private void muteButtonForm1_Click(object sender, EventArgs e)
        {
            muteMusicFun();
        }
    }
}
