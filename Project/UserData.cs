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
    public partial class UserData : Form
    {
        private DataBase DataBase;

        public UserData()
        {
            InitializeComponent();
        }

        // Получает данные из таблицы User в DataGridView
        private void InitTable()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = DataBase.GetTable("User");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row.ItemArray[1].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row.ItemArray[2].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row.ItemArray[3].ToString();
                dataGridView1.Rows[index].Cells[3].Value = row.ItemArray[7].ToString();
                dataGridView1.Rows[index].Cells[4].Value = row.ItemArray[4].ToString();

                DataSet devices = DataBase.GetTable("Device");
                foreach (DataRow device in devices.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[5].ToString(), device.ItemArray[0].ToString()))
                    {
                        dataGridView1.Rows[index].Cells[5].Value = device.ItemArray[0].ToString() + ", " + device.ItemArray[1].ToString();
                    }
                }
            }
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }
            InitTable();

            List<string> items = new List<string>();

            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                items.Add(row.ItemArray[0].ToString() + ", " + row.ItemArray[1].ToString());
            }
            DeviceBox.Items.AddRange(items.ToArray());
        }

        private void UserData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одного пользователя");
                return;
            }
            if (SurnameTextBox.Text.Length == 0 || NameTextBox.Text.Length == 0 || MiddlenameTextBox.Text.Length == 0 || RoleTextBox.Text.Length == 0 ||
                DeviceBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            User user = new User();

            DataSet ds = DataBase.GetTable("User");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), row.ItemArray[7].ToString()))
                {
                    user.ID = Convert.ToInt32(row.ItemArray[0].ToString());
                }
            }

            user.Surname = SurnameTextBox.Text;
            user.Name = NameTextBox.Text;
            user.Middlename = MiddlenameTextBox.Text;
            user.Role = RoleTextBox.Text;
            if (int.TryParse(DeviceBox.Text, out int id))
            {
                user.IdDevice = Convert.ToInt32(id);
            }
            else
            {
                user.IdDevice = Convert.ToInt32((DeviceBox.Text.Split(','))[0]);
            }

            DataBase.EditUser(user, SqlCommand.UPDATE);
            InitTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одного пользователя");
                return;
            }

            DataSet ds = DataBase.GetTable("User");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), row.ItemArray[7].ToString()))
                {
                    DataBase.EditUser(new User() { ID = Convert.ToInt32(row.ItemArray[0].ToString()) }, SqlCommand.DELETE);
                }
            }
            InitTable();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SurnameTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                NameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                MiddlenameTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                RoleTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                DeviceBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}