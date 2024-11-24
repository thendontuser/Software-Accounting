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
    public partial class UserEditForm : Form
    {
        private DataBase DataBase;

        public UserEditForm()
        {
            InitializeComponent();
        }

        private void UserEditForm_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);
            if (DataBase.Connect() == -1)
            {
                return;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!(IDTextBox.Text.Length > 0 && SurnameTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 && MiddlenameTextBox.Text.Length > 0
                && RoleTextBox.Text.Length > 0 && IdDeviceTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            User user = new User();
            user.ID = Convert.ToInt32(IDTextBox.Text);
            user.Surname = SurnameTextBox.Text;
            user.Name = NameTextBox.Text;
            user.Middlename = MiddlenameTextBox.Text;
            user.Role = RoleTextBox.Text;
            user.IdDevice = Convert.ToInt32(IdDeviceTextBox.Text);

            DataBase.EditUser(user, SqlCommand.UPDATE);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле идентификатора должно быть заполнено");
                return;
            }

            User user = new User();
            user.ID = Convert.ToInt32(IDTextBox.Text);

            DataBase.EditUser(user, SqlCommand.DELETE);
        }

        private void UserEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}