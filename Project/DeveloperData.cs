using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        // Получает данные из таблицы Developer в DataGridView
        private void InitTable()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = DataBase.GetTable("Developer");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row.ItemArray[1].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row.ItemArray[2].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row.ItemArray[3].ToString();
            }
        }

        private void DeveloperData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }
            InitTable();
        }

        private void DeveloperData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        // Проверяет, есть ли данный разработчик в системе
        private bool IsExists()
        {
            Developer dev = new Developer();
            dev.Name = NameTextBox.Text;
            dev.TypeOfCompany = TypeTextBox.Text;
            dev.Location = LocationTextBox.Text;
            return DataBase.IsExists(dev);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0 || TypeTextBox.Text.Length == 0 || LocationTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (IsExists())
            {
                MessageBox.Show("Данный разработчик уже добавлен в систему");
                return;
            }

            DataBase.EditDeveloper(new Developer() { Name = NameTextBox.Text, TypeOfCompany = TypeTextBox.Text, Location = LocationTextBox.Text}, SqlCommand.INSERT);
            InitTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран разработчик");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одного разработчика");
                return;
            }
            if (NameTextBox.Text.Length == 0 || TypeTextBox.Text.Length == 0 || LocationTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            Developer dev = new Developer();

            DataSet ds = DataBase.GetTable("Developer");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), row.ItemArray[1].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), row.ItemArray[2].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), row.ItemArray[3].ToString()))
                {
                    dev.ID = Convert.ToInt32(row.ItemArray[0].ToString());
                }
            }
            dev.Name = NameTextBox.Text;
            dev.TypeOfCompany = TypeTextBox.Text;
            dev.Location = LocationTextBox.Text;

            DataBase.EditDeveloper(dev, SqlCommand.UPDATE);
            InitTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбран разработчик");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одного разработчика");
                return;
            }

            DataSet ds = DataBase.GetTable("Developer");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), row.ItemArray[1].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), row.ItemArray[2].ToString()) &&
                    string.Equals(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), row.ItemArray[3].ToString()))
                {
                    DataBase.EditDeveloper(new Developer() { ID = Convert.ToInt32(row.ItemArray[0].ToString()) }, SqlCommand.DELETE);
                }
            }
            InitTable();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                NameTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                TypeTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                LocationTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}