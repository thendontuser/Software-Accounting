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
    public partial class DeveloperData : Form
    {
        private DataBase DataBase;

        public DeveloperData()
        {
            InitializeComponent();
        }

        private void DeveloperData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = DataBase.GetTable("Developer").Tables[0];
        }

        private void DeveloperData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.Equals(Role.CurrentRole, "user"))
            {
                MessageBox.Show("Редактирование таблиц базы данных недоступно обычным пользователям");
                return;
            }
            DevEditForm devEditForm = new DevEditForm();
            devEditForm.Show();
        }
    }
}