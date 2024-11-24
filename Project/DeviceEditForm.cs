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
    public partial class DeviceEditForm : Form
    {
        private DataBase DataBase;

        public DeviceEditForm()
        {
            InitializeComponent();
        }

        private void DeviceEditForm_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);
            if (DataBase.Connect() == -1)
            {
                return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!(NameTextBox.Text.Length > 0 && OSTextBox.Text.Length > 0 && IPTextBox.Text.Length > 0 && RAMTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля, кроме идентификатора, должны быть заполнены");
                return;
            }

            Device device = new Device();
            device.Name = NameTextBox.Text;
            device.OS = OSTextBox.Text;
            device.IPAddress = IPTextBox.Text;
            device.RAM = Convert.ToInt32(RAMTextBox.Text);

            DataBase.EditDevice(device, SqlCommand.INSERT);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!(IDTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 && OSTextBox.Text.Length > 0 && IPTextBox.Text.Length > 0 && RAMTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            Device device = new Device();
            device.ID = Convert.ToInt32(IDTextBox.Text);
            device.Name = NameTextBox.Text;
            device.OS = OSTextBox.Text;
            device.IPAddress = IPTextBox.Text;
            device.RAM = Convert.ToInt32(RAMTextBox.Text);

            DataBase.EditDevice(device, SqlCommand.UPDATE);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле идентификатора должно быть заполнено");
                return;
            }

            Device device = new Device();
            device.ID = Convert.ToInt32(IDTextBox.Text);

            DataBase.EditDevice(device, SqlCommand.DELETE);
        }

        private void DeviceEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}