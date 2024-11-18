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
    public partial class AdminForm : Form
    {
        private string AdminName;

        public AdminForm(string adminName)
        {
            InitializeComponent();
            AdminName = adminName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Пользователь: " + AdminName;
        }

        private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoftwareData softwareData = new SoftwareData();
            softwareData.Show();
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeveloperData developerData = new DeveloperData();
            developerData.Show();
        }

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceData deviceData = new DeviceData();
            deviceData.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            userData.Show();
        }
    }
}