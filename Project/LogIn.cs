using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Accounting_Client_
{
    public partial class LogIn : Form
    {
        DataBase DataBase;

        public LogIn()
        {
            InitializeComponent();
        }

        private User GetUser()
        {
            if (SurnameTextBox.Text.Length != 0 && NameTextBox.Text.Length != 0 && MiddlenameTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0 
                && RoleTextBox.Text.Length != 0)
            {
                if (!string.Equals(RoleTextBox.Text.ToLower(), "user") && !string.Equals(RoleTextBox.Text.ToLower(), "admin"))
                {
                    MessageBox.Show("Поле \"Роль\" должно содеражть значение \"user/admin\"");
                    return null;
                }
                User user = new User();
                user.Surname = SurnameTextBox.Text;
                user.Name = NameTextBox.Text;
                user.Middlename = MiddlenameTextBox.Text;
                user.Password = PasswordTextBox.Text;
                user.Role = RoleTextBox.Text;
                return user;
            }
            return null;
        }

        private void AutorizeBtn_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnsectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }

            User user = GetUser();
            
            if (user == null)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }
            if (DataBase.IsExists(user))
            {
                MessageBox.Show("Вход выполнен");
                ClientForm client = new ClientForm(SurnameTextBox.Text + " " + NameTextBox.Text + " " + MiddlenameTextBox.Text);
                client.Show();
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует");
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}