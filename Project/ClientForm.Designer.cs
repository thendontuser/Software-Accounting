namespace Software_Accounting_Client_
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.UserLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdSoftTextBox = new System.Windows.Forms.TextBox();
            this.IdDevTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdDeviceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.GetReportBtn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.DBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLbl.Location = new System.Drawing.Point(12, 33);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(58, 22);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(222, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Данные заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите ID программного обеспечения:";
            // 
            // IdSoftTextBox
            // 
            this.IdSoftTextBox.Location = new System.Drawing.Point(392, 130);
            this.IdSoftTextBox.Name = "IdSoftTextBox";
            this.IdSoftTextBox.Size = new System.Drawing.Size(159, 22);
            this.IdSoftTextBox.TabIndex = 3;
            // 
            // IdDevTextBox
            // 
            this.IdDevTextBox.Location = new System.Drawing.Point(270, 180);
            this.IdDevTextBox.Name = "IdDevTextBox";
            this.IdDevTextBox.Size = new System.Drawing.Size(281, 22);
            this.IdDevTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Укажите ID разработчика:";
            // 
            // IdDeviceTextBox
            // 
            this.IdDeviceTextBox.Location = new System.Drawing.Point(270, 231);
            this.IdDeviceTextBox.Name = "IdDeviceTextBox";
            this.IdDeviceTextBox.Size = new System.Drawing.Size(281, 22);
            this.IdDeviceTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Укажите ID компьютера:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.Location = new System.Drawing.Point(17, 290);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(226, 35);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Подать заявку";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // GetReportBtn
            // 
            this.GetReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetReportBtn.Location = new System.Drawing.Point(287, 290);
            this.GetReportBtn.Name = "GetReportBtn";
            this.GetReportBtn.Size = new System.Drawing.Size(226, 35);
            this.GetReportBtn.TabIndex = 9;
            this.GetReportBtn.Text = "Получить отчет";
            this.GetReportBtn.UseVisualStyleBackColor = true;
            this.GetReportBtn.Click += new System.EventHandler(this.GetReportBtn_Click);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(563, 28);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "menuStrip1";
            // 
            // DBToolStripMenuItem
            // 
            this.DBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SoftwareToolStripMenuItem,
            this.DevelopersToolStripMenuItem,
            this.DeviceToolStripMenuItem});
            this.DBToolStripMenuItem.Name = "DBToolStripMenuItem";
            this.DBToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.DBToolStripMenuItem.Text = "База данных";
            // 
            // SoftwareToolStripMenuItem
            // 
            this.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem";
            this.SoftwareToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.SoftwareToolStripMenuItem.Text = "Программное обеспечение";
            this.SoftwareToolStripMenuItem.Click += new System.EventHandler(this.SoftwareToolStripMenuItem_Click);
            // 
            // DevelopersToolStripMenuItem
            // 
            this.DevelopersToolStripMenuItem.Name = "DevelopersToolStripMenuItem";
            this.DevelopersToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.DevelopersToolStripMenuItem.Text = "Разработчики";
            this.DevelopersToolStripMenuItem.Click += new System.EventHandler(this.DevelopersToolStripMenuItem_Click);
            // 
            // DeviceToolStripMenuItem
            // 
            this.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem";
            this.DeviceToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.DeviceToolStripMenuItem.Text = "Компьютеры";
            this.DeviceToolStripMenuItem.Click += new System.EventHandler(this.DeviceToolStripMenuItem_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportTextBox.Location = new System.Drawing.Point(17, 373);
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.Size = new System.Drawing.Size(534, 131);
            this.ReportTextBox.TabIndex = 11;
            this.ReportTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчёты";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.GetReportBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.IdDeviceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdDevTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdSoftTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Учёт ПО(Клиент)";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdSoftTextBox;
        private System.Windows.Forms.TextBox IdDevTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdDeviceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button GetReportBtn;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem DBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DevelopersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ReportTextBox;
        private System.Windows.Forms.Label label5;
    }
}