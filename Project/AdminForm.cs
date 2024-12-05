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

            DataSet ds = DataBase.GetTable("Request");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string software = string.Empty;
                string developer = string.Empty;
                string device = string.Empty;
                DataSet tables = new DataSet();

                // Получение названия ПО
                tables = DataBase.GetTable("Software");
                foreach (DataRow dataRow in tables.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1].ToString(), dataRow.ItemArray[0].ToString()))
                    {
                        software = dataRow.ItemArray[1].ToString();
                        break;
                    }
                }

                // Получение названия разработчика
                tables = DataBase.GetTable("Developer");
                foreach (DataRow dataRow in tables.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[2].ToString(), dataRow.ItemArray[0].ToString()))
                    {
                        developer = dataRow.ItemArray[1].ToString();
                        break;
                    }
                }

                // Получение названия устройства
                tables = DataBase.GetTable("Device");
                foreach (DataRow dataRow in tables.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[3].ToString(), dataRow.ItemArray[0].ToString()))
                    {
                        device = dataRow.ItemArray[1].ToString();
                        break;
                    }
                }

                int index = RequestTable.Rows.Add();
                RequestTable.Rows[index].Cells[0].Value = software.ToString();
                RequestTable.Rows[index].Cells[1].Value = developer.ToString();
                RequestTable.Rows[index].Cells[2].Value = device.ToString();
                RequestTable.Rows[index].Cells[3].Value = row.ItemArray[4].ToString();
            }
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
            else if (RequestTable.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну заявку");
                return;
            }

            Software software = new Software();
            DataSet ds = new DataSet();

            // Получение ID ПО
            ds = DataBase.GetTable("Software");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), RequestTable.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    software.Name = row.ItemArray[1].ToString();
                    break;
                }
            }

            // Получение ID разработчика
            ds = DataBase.GetTable("Developer");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), RequestTable.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    software.IdDeveloper = Convert.ToInt32(row.ItemArray[0].ToString());
                    break;
                }
            }

            // Получение ID разработчика
            ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), RequestTable.SelectedRows[0].Cells[2].Value.ToString()))
                {
                    software.IdDevice = Convert.ToInt32(row.ItemArray[0].ToString());
                    break;
                }
            }

            if (DataBase.IsExists(software, false))
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