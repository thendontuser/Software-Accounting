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
    /// <summary>
    /// Реализует форму клиента
    /// </summary>
    public partial class ClientForm : Form
    {
        private string ClientName;

        /// <summary>
        /// Инициализирует все компоненты
        /// </summary>
        /// <param name="clientName">Имя пользователя</param>
        public ClientForm(string clientName)
        {
            InitializeComponent();
            ClientName = clientName;
        }

        // Возникает при загрузке формы. Событие выводит ФИО пользователя на форму
        private void ClientForm_Load(object sender, EventArgs e)
        {
            UserLbl.Text = "Пользователь: " + ClientName;
        }

        // Возникает при нажатии на кнопку "Программное обеспечение". Событие вызывает форму с таблицей ПО
        private void SoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareData softwareData = new SoftwareData();
            softwareData.Show();
        }

        // Возникает при нажатии на кнопку "Разработчики". Событие вызывает форму с таблицей разработчиков
        private void DevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeveloperData devData = new DeveloperData();
            devData.Show();
        }

        // Возникает при нажатии на кнопку "Компьютеры". Событие вызывает форму с таблицей компьютеров
        private void DeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData deviceData = new DeviceData();
            deviceData.Show();
        }

        // Возникает при нажатии на кнопку "Подать заявку". Событие проверяет корректность введенных данных в поля и заносит эти данные в таблицу
        // "Request" базы данных
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (IdSoftTextBox.Text.Length == 0 || IdDevTextBox.Text.Length == 0 || IdDeviceTextBox.Text.Length == 0)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            int idSoft, idDev, idDevice;

            if (int.TryParse(IdSoftTextBox.Text, out idSoft) && int.TryParse(IdDevTextBox.Text, out idDev) && int.TryParse(IdDeviceTextBox.Text, out idDevice))
            {
                Request request = new Request();
                request.IdSoftware = idSoft;
                request.IdDeveloper = idDev;
                request.IdDevice = idDevice;
                request.SNM = ClientName;

                DataBase dataBase = new DataBase(DBSettings.ConnsectionString);
                if (dataBase.Connect() == -1)
                {
                    return;
                }
                dataBase.AddRequest(request);
                dataBase.Disconnect();
                MessageBox.Show("Заявка отправлена, ждите её рассмотрения");
            }
            else
            {
                MessageBox.Show("Все поля должны быть числом");
            }
        }
    }
}