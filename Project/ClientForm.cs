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
    /// Реализует форму клиента
    /// </summary>
    public partial class ClientForm : Form
    {
        private string ClientName;

        // Поле используется для олучения отчёта по текущей заявке
        private Request CurrentRequest;

        /// <summary>
        /// Инициализирует все компоненты
        /// </summary>
        /// <param name="clientName">Имя пользователя</param>
        public ClientForm(string clientName)
        {
            InitializeComponent();
            ClientName = clientName;
        }

        // Заполняет данными выпадающие поля
        private void FillComboBox(string table, char comboBox)
        {
            List<string> items = new List<string>();
            DataBase dataBase = new DataBase(DBSettings.ConnectionString);

            if (dataBase.Connect() == -1)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                return;
            }

            DataSet ds = dataBase.GetTable(table);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                items.Add(row.ItemArray[1].ToString());
            }
            
            switch (comboBox)
            {
                case 's':
                    SoftwareComboBox.Items.AddRange(items.ToArray());
                    break;
                case 'd':
                    DeviceComboBox.Items.AddRange(items.ToArray());
                    break;
            }
            dataBase.Disconnect();
        }

        // Возникает при загрузке формы. Событие выводит ФИО пользователя на форму
        private void ClientForm_Load(object sender, EventArgs e)
        {
            UserLbl.Text = "Пользователь: " + ClientName;
            FillComboBox("Software", 's');
            FillComboBox("Device", 'd');
        }

        // Возникает при нажатии на кнопку "Подать заявку". Событие проверяет корректность введенных данных в поля и заносит эти данные в таблицу
        // "Request" базы данных
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (SoftwareComboBox.SelectedItem == null || DeviceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            try
            {
                DataBase dataBase = new DataBase(DBSettings.ConnectionString);
                Request request = new Request();
                DataSet ds = new DataSet();

                if (dataBase.Connect() == -1)
                {
                    MessageBox.Show("Не удалось подключиться к базе данных");
                    return;
                }

                ds = dataBase.GetTable("Software");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1].ToString(), SoftwareComboBox.SelectedItem.ToString()))
                    {
                        request.IdSoftware = Convert.ToInt32(row.ItemArray[0].ToString());
                        request.IdDeveloper = Convert.ToInt32(row.ItemArray[7].ToString());
                        break;
                    }
                }

                ds = dataBase.GetTable("Device");
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[1].ToString(), DeviceComboBox.SelectedItem.ToString()))
                    {
                        request.IdDevice = Convert.ToInt32(row.ItemArray[0].ToString());
                    }
                }

                request.SNM = ClientName;
                dataBase.EditRequest(request, SqlCommand.INSERT);
                CurrentRequest = request;
                dataBase.Disconnect();
                MessageBox.Show("Заявка отправлена на рассмотрение");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Возникает при нажатии на кнопку "Получить отчёт". Событие делает выборку из таблицы Request и выводит в текстовое поле информацию о последней заявке
        private void GetReportBtn_Click(object sender, EventArgs e)
        {
            if (CurrentRequest == null)
            {
                MessageBox.Show("Не удалось найти последнюю заявку");
                return;
            }

            DataBase dataBase = new DataBase(DBSettings.ConnectionString);
            if (dataBase.Connect() == -1)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                return;
            }

            List<string> data = dataBase.GetLastRequest(CurrentRequest);
            if (data.Count == 0)
            {
                MessageBox.Show("Не удалось найти последнюю заявку");
                return;
            }

            ReportTextBox.Clear();
            ReportTextBox.Text += "Отправитель: " + ClientName + "\n";
            ReportTextBox.Text += "Название ПО: " + data[0] + "\n";
            ReportTextBox.Text += "Разработчик: " + data[1] + "\n";
            ReportTextBox.Text += "Устройство: " + data[2] + "\n";

            dataBase.Disconnect();

        }
    }
}