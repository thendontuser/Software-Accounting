using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Accounting_Client_
{
    public partial class SoftwareData : Form
    {
        DataBase DataBase;

        public SoftwareData()
        {
            InitializeComponent();
        }

        // Получает данные из таблицы Software в DataGridView
        private void InitTable()
        {
            dataGridView1.Rows.Clear();

            DataSet ds = DataBase.GetTable("Software");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string developer = string.Empty, device = string.Empty;
                DataSet tables = new DataSet();

                // Получение названия разработчика
                tables = DataBase.GetTable("Developer");
                foreach (DataRow dataRow in tables.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[7].ToString(), dataRow.ItemArray[0].ToString()))
                    {
                        developer = dataRow.ItemArray[1].ToString();
                        break;
                    }
                }

                // Получение названия устройства
                tables = DataBase.GetTable("Device");
                foreach (DataRow dataRow in tables.Tables[0].Rows)
                {
                    if (string.Equals(row.ItemArray[6].ToString(), dataRow.ItemArray[0].ToString()))
                    {
                        device = dataRow.ItemArray[1].ToString();
                        break;
                    }
                }

                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row.ItemArray[1].ToString();
                dataGridView1.Rows[index].Cells[1].Value = row.ItemArray[2].ToString();
                dataGridView1.Rows[index].Cells[2].Value = row.ItemArray[3].ToString();
                dataGridView1.Rows[index].Cells[3].Value = (row.ItemArray[4].ToString().Split(' '))[0];
                dataGridView1.Rows[index].Cells[4].Value = (row.ItemArray[5].ToString().Split(' '))[0];
                dataGridView1.Rows[index].Cells[5].Value = developer;
                dataGridView1.Rows[index].Cells[6].Value = device;
                dataGridView1.Rows[index].Cells[7].Value = GetImage(row.ItemArray[8].ToString());
            }
        }

        // Заполняет данными выпадающие поля
        private void FillComboBox(string table, string comboBox)
        {
            List<string> items = new List<string>();
            DataBase dataBase = new DataBase(DBSettings.ConnectionString);

            if (dataBase.Connect() == -1)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
                return;
            }

            DataSet ds = dataBase.GetTable(table);

            switch (comboBox)
            {
                case "dev":
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        items.Add(row.ItemArray[1].ToString());
                    }
                    DeveloperBox.Items.AddRange(items.ToArray());
                    break;
                case "device":
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        items.Add(row.ItemArray[0].ToString() + ", " + row.ItemArray[1].ToString());
                    }
                    DeviceBox.Items.AddRange(items.ToArray());
                    break;
            }
        }

        /// <summary>
        /// Возвращает изображение по указанному пути
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Image</returns>
        public static Image GetImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(new BufferedStream(fs)))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        return Image.FromStream(ms);
                    }
                }
            }
        }

        // Возвращает id устройства, указанного в DeviceBox. Метод используется для функций добавления и обноления записи в таблице Software
        private int GetDeviceId()
        {
            int deviceId = 0;

            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(" " + row.ItemArray[1].ToString(), DeviceBox.Text.Split(',')[1]))
                {
                    deviceId = Convert.ToInt32(row.ItemArray[0].ToString());
                }
            }
            return deviceId;
        }

        // Возвращает id разработчика, указанного в DeveloperBox. Метод используется для функций добавления и обноления записи в таблице Software
        public int GetDeveloperId()
        {
            int devId = 0;
            DataSet ds = DataBase.GetTable("Developer");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), DeveloperBox.Text))
                {
                    devId = Convert.ToInt32(row.ItemArray[0].ToString());
                }
            }
            return devId;
        }

        private void SoftwareData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }
            InitTable();
            FillComboBox("Developer", "dev");
            FillComboBox("Device", "device");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Значение столбца равно null");
            this.Close();
        }

        private void SoftwareData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        private void ChooseFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.ico|*.ICO";

            if (file.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < file.FileName.Length; i++)
                {
                    if (file.FileName[i] == '\\')
                    {
                        LogoTextBox.Text += file.FileName[i] + "\\";
                    }
                    else
                    {
                        LogoTextBox.Text += file.FileName[i];
                    }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                NameTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                VersionTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                LicenseTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                LicenseBeginTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                LicenseEndTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                DeveloperBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                DeviceBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0 || VersionTextBox.Text.Length == 0 || LicenseTextBox.Text.Length == 0 || LicenseBeginTextBox.Text.Length == 0
                || LicenseEndTextBox.Text.Length == 0 || DeveloperBox.Text.Length == 0 || DeviceBox.Text.Length == 0 || LogoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            Software software = new Software()
            {
                Name = NameTextBox.Text,
                Version = VersionTextBox.Text,
                License = LicenseTextBox.Text,
                LicenseBegin = LicenseBeginTextBox.Text,
                LicenseEnd = LicenseEndTextBox.Text,
                IdDeveloper = GetDeveloperId(),
                IdDevice = GetDeviceId(),
                LogoPath = LogoTextBox.Text,
            };

            if (DataBase.IsExists(software, true))
            {
                MessageBox.Show("Данное ПО уже добавлено в систему");
                return;
            }

            DataBase.EditSoftware(software, SqlCommand.INSERT);
            InitTable();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Программное обеспечение не выбрано");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одно программное обеспечение");
                return;
            }

            int id = 0;
            DataSet ds = DataBase.GetTable("Software");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) && 
                    string.Equals(row.ItemArray[6].ToString(), GetDeviceId().ToString()))
                {
                    id = Convert.ToInt32(row.ItemArray[0].ToString());
                    break;
                }
            }

            Software software = new Software()
            {
                Id = id,
                Name = NameTextBox.Text,
                Version = VersionTextBox.Text,
                License = LicenseTextBox.Text,
                LicenseBegin = LicenseBeginTextBox.Text,
                LicenseEnd = LicenseEndTextBox.Text,
                IdDeveloper = GetDeveloperId(),
                IdDevice = GetDeviceId(),
                LogoPath = LogoTextBox.Text
            };

            DataBase.EditSoftware(software, SqlCommand.UPDATE);
            InitTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Программное обеспечение не выбрано");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одно программное обеспечение");
                return;
            }

            int deviceId = 0;
            DataSet ds = DataBase.GetTable("Device");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), DeviceBox.Text))
                {
                    deviceId = Convert.ToInt32(row.ItemArray[0].ToString());
                    break;
                }
            }

            ds = DataBase.GetTable("Software");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[1].ToString(), dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) &&
                    string.Equals(row.ItemArray[6].ToString(), deviceId.ToString()))
                {
                    DataBase.EditSoftware(new Software() { Id = Convert.ToInt32(row.ItemArray[0].ToString()) }, SqlCommand.DELETE);
                }
            }
            InitTable();
        }
    }
}