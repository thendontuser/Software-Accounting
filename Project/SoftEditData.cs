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
    public partial class SoftEditForm : Form
    {
        private DataBase DataBase;

        public SoftEditForm()
        {
            InitializeComponent();
        }

        private void SoftEditForm_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);
            if (DataBase.Connect() == -1)
            {
                return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!(NameTextBox.Text.Length > 0 && VersionTextBox.Text.Length > 0 && LicenseTextBox.Text.Length > 0 && LicenseBeginTextBox.Text.Length > 0
                && LicenseEndTextBox.Text.Length > 0 && IDDeviceTextBox.Text.Length > 0 && IDDevTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля, кроме идентификатора, должны быть заполнены");
                return;
            }

            Software soft = new Software();
            soft.Name = NameTextBox.Text;
            soft.Version = VersionTextBox.Text;
            soft.License = LicenseTextBox.Text;
            soft.LicenseBegin = LicenseBeginTextBox.Text;
            soft.LicenseEnd = LicenseEndTextBox.Text;
            soft.IdDevice = Convert.ToInt32(IDDeviceTextBox.Text.ToString());
            soft.IdDeveloper = Convert.ToInt32(IDDevTextBox.Text.ToString());

            DataBase.EditSoftware(soft, SqlCommand.INSERT);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!(IDTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 && VersionTextBox.Text.Length > 0 && LicenseTextBox.Text.Length > 0 && LicenseBeginTextBox.Text.Length > 0
                && LicenseEndTextBox.Text.Length > 0 && IDDeviceTextBox.Text.Length > 0 && IDDevTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            Software soft = new Software();
            soft.Id = Convert.ToInt32(IDTextBox.Text);
            soft.Name = NameTextBox.Text;
            soft.Version = VersionTextBox.Text;
            soft.License = LicenseTextBox.Text;
            soft.LicenseBegin = LicenseBeginTextBox.Text;
            soft.LicenseEnd = LicenseEndTextBox.Text;
            soft.IdDevice = Convert.ToInt32(IDDeviceTextBox.Text.ToString());
            soft.IdDeveloper = Convert.ToInt32(IDDevTextBox.Text.ToString());

            DataBase.EditSoftware(soft, SqlCommand.UPDATE);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Поле идентификатора должно быть заполнено");
                return;
            }

            Software soft = new Software();
            soft.Id = Convert.ToInt32(IDTextBox.Text);

            DataBase.EditSoftware(soft, SqlCommand.DELETE);
        }

        private void SoftEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}