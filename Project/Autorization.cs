﻿using System;
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
    public partial class Autorization : Form
    {
        private DataBase DataBase;

        public Autorization()
        {
            InitializeComponent();
        }

        private User GetUser()
        {
            if (SurnameTextBox.Text.Length != 0 && NameTextBox.Text.Length != 0 && MiddlenameTextBox.Text.Length != 0 && RoleTextBox.Text.Length != 0 && 
                IdDeviceTextBox.Text.Length != 0 && PasswordTextBox.Text.Length != 0)
            {
                User user = new User();
                user.Surname = SurnameTextBox.Text;
                user.Name = NameTextBox.Text;
                user.Middlename = MiddlenameTextBox.Text;
                user.Role = RoleTextBox.Text;
                user.IdDevice = Convert.ToInt32(IdDeviceTextBox.Text);
                user.Password = PasswordTextBox.Text;
                return user;
            }
            return null;
        }

        private void AutorizeBtn_Click(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnsectionString);

            if (DataBase.Connect() == -1)
            {
                MessageBox.Show("Ошибка подключения");
            }

            User user = GetUser();

            if (user == null)
            {
                MessageBox.Show("Все поля должы быть заполнены");
                return;
            }
            DataBase.CreateUser(user);
        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}