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
    public partial class DevEditForm : Form
    {
        private DataBase DataBase;

        public DevEditForm()
        {
            InitializeComponent();
        }

        private void DevEditForm_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);
            if (DataBase.Connect() == -1)
            {
                return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (!(NameTextBox.Text.Length > 0 && TypeOfCompanyTextBox.Text.Length > 0 && LocationTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля, кроме идентификатора, должны быть заполнены");
                return;
            }

            Developer dev = new Developer();
            dev.Name = NameTextBox.Text;
            dev.TypeOfCompany = TypeOfCompanyTextBox.Text;
            dev.Location = LocationTextBox.Text;

            DataBase.EditDeveloper(dev, SqlCommand.INSERT);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (!(IDTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 && TypeOfCompanyTextBox.Text.Length > 0 && LocationTextBox.Text.Length > 0))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            Developer dev = new Developer();
            dev.ID = Convert.ToInt32(IDTextBox.Text);
            dev.Name = NameTextBox.Text;
            dev.TypeOfCompany = TypeOfCompanyTextBox.Text;
            dev.Location = LocationTextBox.Text;

            DataBase.EditDeveloper(dev, SqlCommand.UPDATE);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (IDTextBox.Text.Length == 0)
            {
                MessageBox.Show("Идентификатор должен быть заполнен");
                return;
            }

            Developer dev = new Developer();
            dev.ID = Convert.ToInt32(IDTextBox.Text);

            DataBase.EditDeveloper(dev, SqlCommand.DELETE);
        }

        private void DevEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }
    }
}