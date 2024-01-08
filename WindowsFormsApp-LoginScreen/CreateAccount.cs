using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_LoginScreen
{
    public partial class CreateAccount : Form
    {
        private SqlConnection conn;
        public string connString = "Data Source=DESKTOP-0FIEU0A\\SQLEXPRESS;Initial Catalog=PersonalLibrary;Integrated Security=True";
        public CreateAccount()
        {
            InitializeComponent();

            // TextBox'a placeholder eklemek için bir örnek
            SetPlaceholder(txtUsername, "5 char. long at least");
            SetPlaceholder(txtPassword, "8 char. long, one number at least");

            // Enter ve Leave olaylarına ilişkin olay dinleyicilerini tanımla
            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;

            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;

            conn = new SqlConnection(connString);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.Tag = placeholder;
            textBox.ForeColor = Color.Gray; // Placeholder rengi
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // TextBox odaklandığında, placeholder'ı temizle
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Gerçek metin rengi
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // TextBox odaktan çıktığında, eğer boşsa placeholder'ı geri ekle
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray; // Placeholder rengi
            }
        }

        private bool IsEmailValid(string email)
        {
            return email.Length >= 5;
        }
        
        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8 && password.Any(char.IsDigit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan mail ve şifre
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            // Mail ve şifre şartlarını kontrol et
            if (IsEmailValid(email) && IsPasswordValid(password))
            {
                conn.Open();

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO dbo.users VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";

                    SqlCommand command = new SqlCommand(query, conn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");


                    conn.Close();
                }
                else
                {
                    MessageBox.Show("There is error");
                }

                // Formu kapat
                this.Close();
            }
            else
            {
                // Kontrolleri geçemiyorsa kullanıcıya bir hata mesajı göster
                MessageBox.Show("Invalid email or password format. Please check your inputs.", "Error");
            }
        }

        
    }
}
