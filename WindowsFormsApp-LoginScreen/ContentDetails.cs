using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_LoginScreen
{
    public partial class ContentDetails : Form
    {
        public string currentUserName;

        public string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";
        public string category;
        public string editedCategory;
        MainPage mnpg = Application.OpenForms.OfType<MainPage>().FirstOrDefault();

        UpdateItem updateItem = Application.OpenForms.OfType<UpdateItem>().FirstOrDefault();

        string labelnameThis;
        private SqlConnection conn;

        Funcs funcs = new Funcs();


        public ContentDetails()
        {
            
            InitializeComponent();


            conn = new SqlConnection(connString);

            if (mnpg.isUSerListView == true) 
            {
                deleteBtn.Visible = false;
                changeInfoBtn.Visible = false;
            } else if (mnpg.isUSerListView == false)
            {
                deleteBtn.Visible = true;
                changeInfoBtn.Visible = true;
            }
        }
       

        public void TakeDetails(string labelname , string mainLabel)
        {
            labelnameThis = labelname;
            category = mainLabel;
            editedCategory = category.Substring(0, category.Length - 1);

            string folder = "C:\\Users\\Melih\\Documents\\GitHub\\PersonalLibrary\\loginscreen-assets\\useruploads\\";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                if (conn.State == ConnectionState.Open)
                {
                    string query = $"SELECT * FROM dbo.{category} WHERE {editedCategory.ToLower()}_title = '{labelnameThis}'";



                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                label_title.Text = reader.GetString(2);
                                
                                pictureBox_item.Image = Image.FromFile(folder + reader[$"{editedCategory.ToLower()}_image"].ToString());

                                label_content.Text = reader.GetString(3);
                                label_type.Text = reader.GetString(4);
                                label_rate.Text = reader.GetString(5);
                                textBox_comment.Text = reader.GetString(6);
                                labelofitem.Text = reader.GetString(2);

                               
                            }
                        }
                    }
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            funcs.EnablePanels(mnpg);


            if (mnpg.isUSerListView == true)
            {
                mnpg.mylibraryButton.Enabled = true;
            }



            this.Close();

        }

        

       

        private void changeInfoBtn_Click(object sender, EventArgs e)
        {
            
            updateItem = new UpdateItem();

            updateItem.button_saveupload.Text = "Upload";

            updateItem.textBox1.Text = label_title.Text;
            updateItem.pictureBox_upload.Image = pictureBox_item.Image;
            updateItem.comboBox_rate.SelectedItem = label_rate.Text;
            updateItem.comboBox_content.SelectedItem = label_content.Text;
            updateItem.comboBox_type.SelectedItem = label_type.Text;

            updateItem.textBox2.Text = textBox_comment.Text;
            updateItem.nameForDeleting = label_title.Text.ToString();

            updateItem.comboBox_content.Enabled = false;

            updateItem.Show();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            // UpdateContent metodu, sayfa içeriğini güncelleyen bir metod olmalıdır
            conn.Open();

            string deleteQuery = "DELETE FROM dbo." + label_content.Text.ToString().ToLower() + "s WHERE " + label_content.Text.ToString().ToLower() + "_title = @TitleToDelete";

            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
            {
                deleteCommand.Parameters.AddWithValue("@TitleToDelete", label_title.Text);
                deleteCommand.ExecuteNonQuery();
            }

            conn.Close();

            MainPage existingMainPage = Application.OpenForms.OfType<MainPage>().FirstOrDefault();

            if (existingMainPage != null)
            {
                // Açık bir MainPage penceresi varsa kapat
                existingMainPage.Close();
            }

            // Yeni bir MainPage örneği oluştur ve göster
            MainPage newMainPage = new MainPage();
            newMainPage.label_username.Text = currentUserName;

            newMainPage.Show();

            funcs.EnablePanels(mnpg);

        }


    }
}
