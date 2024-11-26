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
    public partial class SoftwareData : Form
    {
        DataBase DataBase;

        public SoftwareData()
        {
            InitializeComponent();
        }

        private void SoftwareData_Load(object sender, EventArgs e)
        {
            DataBase = new DataBase(DBSettings.ConnectionString);

            if (DataBase.Connect() == -1)
            {
                return;
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = DataBase.GetTable("Software").Tables[0];
        }

        private void SoftwareData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DataBase != null)
            {
                DataBase.Disconnect();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (string.Equals(Role.CurrentRole, "user"))
            {
                MessageBox.Show("Редактирование таблиц базы данных недоступно обычным пользователям");
                return;
            }
            SoftEditForm softEditForm = new SoftEditForm();
            softEditForm.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Значение столбца равно null");
            this.Close();
        }
    }
}