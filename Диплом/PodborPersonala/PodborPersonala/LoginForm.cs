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

namespace PodborPersonala
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            textBoxPassword.AutoSize = true;
            textBoxPassword.Size = new Size(textBoxPassword.Size.Width, 40);

            menu = new Menu();
        }
        Menu menu;

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Gray;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми!");
                return;
            }

            string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @Login AND Пароль = @Password";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Login", login);
                    checkCommand.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int existingUsersCount = (int)checkCommand.ExecuteScalar();

                    if (existingUsersCount == 0)
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Успешная авторизация!");
                        menu.Show();
                    }
                }
            }
        }
    }
}
