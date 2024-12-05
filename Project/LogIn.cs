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
    /// <summary>
    /// Реализует форму входа в систему
    /// </summary>
    public partial class LogIn : Form
    {
        private DataBase DataBase;

        /// <summary>
        /// Инициализирует все компоненты
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
        }

        // Получает данные текущего пользователя и возвращает объект User
        private User GetUser()
        {
            if (LoginTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0)
            {
                User user = new User();
                user.Login = LoginTextBox.Text;
                user.Password = PasswordTextBox.Text.GetHashCode().ToString();
                return user;
            }
            return null;
        }

        // Возникает при нажатии на кнопку "Авторизация". Событие вызывает форму авторизации
        private void AutorizeBtn_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        // Возникает при нажатии на кнопку "Вход". Событие проверяет все введенные пользователем поля, и если такой пользователь есть в системе, то
        // вызывается форма клиента или администратора, в зависимости от значения поля "Роль"
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

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
                DataSet ds = DataBase.GetTable("User");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[7].ToString(), user.Login))
                    {
                        user.Surname = row.ItemArray[1].ToString();
                        user.Name = row.ItemArray[2].ToString();
                        user.Middlename = row.ItemArray[3].ToString();
                        user.Role = row.ItemArray[4].ToString();
                    }
                }

                MessageBox.Show("Вход выполнен");
                if (string.Equals(user.Role, "user"))
                {
                    CloseConnection();
                    ClientForm client = new ClientForm(user.Surname + " " + user.Name + " " + user.Middlename);
                    client.Show();
                }
                else
                {
                    CloseConnection();
                    AdminForm admin = new AdminForm(user.Surname + " " + user.Name + " " + user.Middlename);
                    admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует");
            }
        }

        // Закрывает подключение к базе данных
        private void CloseConnection()
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        // Возникает при закрытии формы. Событие закрывает подключение к базе данных
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }
    }
}