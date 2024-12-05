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
    public partial class DeviceData : Form
    {
        private DataBase DataBase;

        public DeviceData()
        {
            InitializeComponent();
        }

        // Получает данные из таблицы Device в DataGridView
        private void InitTable()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row.ItemArray[1].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row.ItemArray[2].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row.ItemArray[3].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row.ItemArray[4].ToString();
            }
        }

        private void DeviceData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }
            InitTable();
        }

        private void DeviceData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0 || OSTextBox.Text.Length == 0 || IPTextBox.Text.Length == 0 || RAMTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (DataBase.IsExists(new Device() { IPAddress = IPTextBox.Text }))
            {
                MessageBox.Show("Устройство с таким же ip-адресом уже добавлено в систему");
                return;
            }

            DataBase.EditDevice(new Device() { Name = NameTextBox.Text, OS = OSTextBox.Text, IPAddress = IPTextBox.Text, RAM = Convert.ToInt32(RAMTextBox.Text) }, SqlCommand.INSERT);
            InitTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Устройство не выбрано");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одно устройство");
                return;
            }
            if (NameTextBox.Text.Length == 0 || OSTextBox.Text.Length == 0 || IPTextBox.Text.Length == 0 || RAMTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            Device device = new Device();

            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), row.ItemArray[1].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), row.ItemArray[2].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), row.ItemArray[3].ToString()))
                {
                    device.ID = Convert.ToInt32(row.ItemArray[0].ToString());
                }
            }

            device.Name = NameTextBox.Text;
            device.OS = OSTextBox.Text;
            device.IPAddress = IPTextBox.Text;
            device.RAM = Convert.ToInt32(RAMTextBox.Text);

            DataBase.EditDevice(device, SqlCommand.UPDATE);
            InitTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Устройство не выбрано");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одно устройство");
                return;
            }

            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), row.ItemArray[1].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), row.ItemArray[2].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), row.ItemArray[3].ToString()))
                {
                    DataBase.EditDevice(new Device() { ID = Convert.ToInt32(row.ItemArray[0].ToString()) }, SqlCommand.DELETE);
                }
            }
            InitTable();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                NameTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                OSTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                IPTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                RAMTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}