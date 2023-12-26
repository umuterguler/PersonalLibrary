using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_LoginScreen
{
    public partial class UpdateItem : Form
    {
        MainPage mnpg;
        ContentDetails details;
        private SqlConnection conn;
        public int currentUserID;
        public string newFileName;

        public UpdateItem(MainPage mainPage)
        {
            InitializeComponent();
            mnpg = mainPage; // MainPage referansını burada alıyoruz
            string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";

            conn = new SqlConnection(connString);
            currentUserID = mnpg.currentUserID;

            //update item sayfası açılınca mainpage update_button tuşunu disabled yap
            mnpg.MakeButtonDisabled(mnpg.button_uploadObj);
            mnpg.MakeButtonDisabled(mnpg.closeButtonMain);
            mnpg.MakeButtonDisabled(mnpg.button_logoutObj);


        }



        private void button_close_Click(object sender, EventArgs e)
        {
                this.Close();
                mnpg.MakeButtonEnabled(mnpg.button_uploadObj);
                mnpg.MakeButtonEnabled(mnpg.closeButtonMain);
                mnpg.MakeButtonEnabled(mnpg.button_logoutObj);
            

        }

        private void comboBox_content_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_content.SelectedItem == comboBox_content.Items[0])
            {
                //
                comboBox_type.Items.Clear();
                comboBox_type.Items.Add("Mystery");
                comboBox_type.Items.Add("Romance");
                comboBox_type.Items.Add("Fantasy");
                comboBox_type.Items.Add("Horror");
                comboBox_type.Items.Add("Manga");
                comboBox_type.Items.Add("Novel");
                comboBox_type.Items.Add("Biography");
                comboBox_type.Items.Add("Fiction");

            }
            if (comboBox_content.SelectedItem == comboBox_content.Items[1])
            {
                comboBox_type.Items.Clear();
                comboBox_type.Items.Add("Western");
                comboBox_type.Items.Add("Drama");
                comboBox_type.Items.Add("Action");
                comboBox_type.Items.Add("Horror");
                comboBox_type.Items.Add("Anime");
                comboBox_type.Items.Add("Animation");
                comboBox_type.Items.Add("Documantary");
                comboBox_type.Items.Add("Fiction");

            }
            if (comboBox_content.SelectedItem == comboBox_content.Items[2])
            {
                comboBox_type.Items.Clear();
                comboBox_type.Items.Add("MMORPG");
                comboBox_type.Items.Add("RPG");
                comboBox_type.Items.Add("Racing");
                comboBox_type.Items.Add("Strategy");
                comboBox_type.Items.Add("BattleRoyale");
                comboBox_type.Items.Add("Sport");
                comboBox_type.Items.Add("FPS");
                comboBox_type.Items.Add("Moba");

            }
        }

        private void button_selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                pictureBox_upload.Image = new System.Drawing.Bitmap(filePath);

                try
                {

                    string targetDirectory = @"C:\Users\Melih\source\repos\PersonalLibrary1\loginscreen-assets\useruploads\";

                    newFileName = Path.GetFileNameWithoutExtension(filePath) + "_" + GetRandomNumber() + Path.GetExtension(filePath);

                    string targetFilePath = Path.Combine(targetDirectory, newFileName);

                    File.Copy(filePath, targetFilePath, true);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kopyalama sırasında bir hata oluştu: " + ex.Message);

                }
            }
        }

        // UpdateItem formu içindeki button_saveupload_Click metodu
        private void button_saveupload_Click(object sender, EventArgs e)
        {
            if (pictureBox_upload.Image != null
                && !string.IsNullOrWhiteSpace(textBox1.Text)
                && comboBox_content.SelectedIndex != -1
                && comboBox_type.SelectedIndex != -1
                && comboBox_rate.SelectedIndex != -1
                && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                try
                {
                    conn.Open();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        if (comboBox_content.SelectedItem.ToString() == "Movie" || comboBox_content.SelectedItem.ToString() == "Book" || comboBox_content.SelectedItem.ToString() == "Game")
                        {
                            string query = "INSERT INTO dbo." + comboBox_content.SelectedItem.ToString().ToLower() + "s VALUES (@currentUserID, @TextBox1, @ComboBoxContent, @ComboBoxType, @ComboBoxRate, @TextBox2 , @ImageName)";

                            using (SqlCommand command = new SqlCommand(query, conn))
                            {
                                command.Parameters.AddWithValue("@currentUserID", currentUserID);
                                command.Parameters.AddWithValue("@TextBox1", textBox1.Text);
                                command.Parameters.AddWithValue("@ComboBoxContent", comboBox_content.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@ComboBoxType", comboBox_type.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@ComboBoxRate", comboBox_rate.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@TextBox2", textBox2.Text);
                                command.Parameters.AddWithValue("@ImageName", newFileName);

                                command.ExecuteNonQuery();


                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid content type selected.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is an error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {


                    mnpg.MainPage_Load(this, e);
                    conn.Close();
                    //mainpage update_item butonunu tekrar enabled yap
                    mnpg.MakeButtonEnabled(mnpg.button_uploadObj);
                    mnpg.MakeButtonEnabled(mnpg.closeButtonMain);
                    mnpg.MakeButtonEnabled(mnpg.button_logoutObj);

                    // Formu kapat
                    this.Close();
                }


                
            }
            else
            {
                MessageBox.Show("Please fill all properties");
            }
        }
        static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999); // İstediğiniz aralığı belirleyebilirsiniz
        }
    }
}
