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
    public partial class ClientForm : Form
    {
        private string ClientName;

        public ClientForm(string clientName)
        {
            InitializeComponent();
            ClientName = clientName;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UserLbl.Text = "Пользователь: " + ClientName;
        }

        private void SoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareData softwareData = new SoftwareData();
            softwareData.Show();
        }

        private void разработчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeveloperData devData = new DeveloperData();
            devData.Show();
        }

        private void DeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData deviceData = new DeviceData();
            deviceData.Show();
        }
    }
}