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
    /// Реализует форму авторизации
    /// </summary>
    public partial class Autorization : Form
    {
        private DataBase DataBase;

        /// <summary>
        /// Инициализирует все компоненты
        /// </summary>
        public Autorization()
        {
            InitializeComponent();
        }

        // Создает нового пользователя и возвращает объект User
        private User GetUser()
        {
            if (SurnameTextBox.Text.Length != 0 && NameTextBox.Text.Length != 0 && MiddlenameTextBox.Text.Length != 0 && (UserRB.Checked || AdminRB.Checked) && 
                IdDeviceTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0 && LoginTextBox.Text.Length != 0)
            {
                User user = new User();
                user.Surname = SurnameTextBox.Text;
                user.Name = NameTextBox.Text;
                user.Middlename = MiddlenameTextBox.Text;
                user.Role = UserRB.Checked ? "user" : "admin";
                user.IdDevice = Convert.ToInt32(IdDeviceTextBox.Text);
                user.Password = PasswordTextBox.Text;
                user.Login = LoginTextBox.Text;
                return user;
            }
            return null;
        }

        // Возникает при нажатии на кнопку "Авторизация". Событие проверяет на корректность все введенные поля и заносит нового пользователя в базу данных
        private void AutorizeBtn_Click(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }

            User user = GetUser();

            if (user == null)
            {
                MessageBox.Show("Все поля должы быть заполнены");
                return;
            }

            DataSet ds = DataBase.GetTable("User");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[7].ToString(), user.Login))
                {
                    MessageBox.Show("Пользователь с таким же логином уже существует");
                    return;
                }
            }

            DataBase.CreateUser(user);
        }

        // Возникает при закрытии формы. Событие закрывает подключение к базе данных
        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}