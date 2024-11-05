﻿using System;
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
            DataBase = new DataBase(DBSettings.ConnsectionString);

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
    }
}