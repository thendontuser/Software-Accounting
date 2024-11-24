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
    public partial class AdminForm : Form
    {
        private string AdminName;
        private DataBase DataBase;

        public AdminForm(string adminName)
        {
            InitializeComponent();
            AdminName = adminName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Пользователь: " + AdminName;

            DataBase = new DataBase(DBSettings.ConnectionString);
            if (DataBase.Connect() == -1)
            {
                return;
            }
            RequestTable.DataSource = DataBase.GetTable("Request").Tables[0];
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareData softwareData = new SoftwareData();
            softwareData.Show();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeveloperData developerData = new DeveloperData();
            developerData.Show();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData deviceData = new DeviceData();
            deviceData.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            userData.Show();
        }

        // Обработчик нажатия кнопки анализа заявки. Метод проверяет, есть ли указанное в заявке ПО на конкретном компьютере, а также идет анализ
        // системных требований
        private void CheckSoft_Click(object sender, EventArgs e)
        {
            if (RequestTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Заявка не выбрана");
                return;
            }

            Software software = new Software();
            software.Id = Convert.ToInt32(RequestTable.SelectedRows[0].Cells[1].Value.ToString());
            software.IdDeveloper = Convert.ToInt32(RequestTable.SelectedRows[0].Cells[2].Value.ToString());
            software.IdDevice = Convert.ToInt32(RequestTable.SelectedRows[0].Cells[3].Value.ToString());

            if (DataBase.IsExists(software))
            {
                MessageBox.Show("Данное ПО уже установлено на указанном компьютере");
                return;
            }

            # region Определение системных требований

            DataSet devices = DataBase.GetTable("Device");
            int RAM = -1;

            foreach (DataRow device in devices.Tables[0].Rows)
            {
                if (Convert.ToInt32(device[0].ToString()) == software.IdDevice)
                {
                    RAM = Convert.ToInt32(device[4].ToString());
                    break;
                }
            }

            if (RAM != -1)
            {
                if (RAM < 4)
                {
                    MessageBox.Show($"Требуемый объём оперативной памяти для данного ПО: 4 ГБ\nОбъём оперативной памяти данного ПК: {RAM} ГБ");
                    return;
                }
                MessageBox.Show("Данное программное обеспечение можно установить на данный компьютер");
            }
            else
            {
                MessageBox.Show($"Компьютер с идентификатором {software.IdDevice} не обнаружен в системе");
            }

            #endregion
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}