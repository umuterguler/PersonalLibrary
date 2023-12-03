using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public UpdateItem()
        {
            InitializeComponent();
        }

      

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {     
                this.Close();
            }
                
        }

        private void comboBox_content_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_content.SelectedItem == comboBox_content.Items[0])
            {
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
            }
        }

        private void button_saveupload_Click(object sender, EventArgs e)
        {
            // database tabanlı yapılacak.


   

        }
    }
}
