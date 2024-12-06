namespace Software_Accounting_Client_
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RequestTable = new System.Windows.Forms.DataGridView();
            this.SoftwareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNMColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckSoft = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // RequestTable
            // 
            this.RequestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RequestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoftwareColumn,
            this.DeveloperColumn,
            this.DeviceColumn,
            this.SNMColumn,
            this.StateColumn});
            this.RequestTable.Location = new System.Drawing.Point(16, 129);
            this.RequestTable.Name = "RequestTable";
            this.RequestTable.RowHeadersWidth = 51;
            this.RequestTable.RowTemplate.Height = 24;
            this.RequestTable.Size = new System.Drawing.Size(1137, 512);
            this.RequestTable.TabIndex = 1;
            // 
            // SoftwareColumn
            // 
            this.SoftwareColumn.HeaderText = "Программное обеспечение";
            this.SoftwareColumn.MinimumWidth = 6;
            this.SoftwareColumn.Name = "SoftwareColumn";
            // 
            // DeveloperColumn
            // 
            this.DeveloperColumn.HeaderText = "Разработчик";
            this.DeveloperColumn.MinimumWidth = 6;
            this.DeveloperColumn.Name = "DeveloperColumn";
            // 
            // DeviceColumn
            // 
            this.DeviceColumn.HeaderText = "Устройство";
            this.DeviceColumn.MinimumWidth = 6;
            this.DeviceColumn.Name = "DeviceColumn";
            // 
            // SNMColumn
            // 
            this.SNMColumn.HeaderText = "ФИО";
            this.SNMColumn.MinimumWidth = 6;
            this.SNMColumn.Name = "SNMColumn";
            // 
            // StateColumn
            // 
            this.StateColumn.HeaderText = "Состояние";
            this.StateColumn.MinimumWidth = 6;
            this.StateColumn.Name = "StateColumn";
            this.StateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заявки";
            // 
            // CheckSoft
            // 
            this.CheckSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckSoft.Location = new System.Drawing.Point(16, 647);
            this.CheckSoft.Name = "CheckSoft";
            this.CheckSoft.Size = new System.Drawing.Size(262, 52);
            this.CheckSoft.TabIndex = 3;
            this.CheckSoft.Text = "Анализ заявки";
            this.CheckSoft.UseVisualStyleBackColor = true;
            this.CheckSoft.Click += new System.EventHandler(this.CheckSoft_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DBToolStripMenuItem
            // 
            this.DBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareToolStripMenuItem,
            this.developersToolStripMenuItem,
            this.devicesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.DBToolStripMenuItem.Name = "DBToolStripMenuItem";
            this.DBToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.DBToolStripMenuItem.Text = "База данных";
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.softwareToolStripMenuItem.Text = "Программное обеспечение";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.developersToolStripMenuItem.Text = "Разработчики";
            this.developersToolStripMenuItem.Click += new System.EventHandler(this.developersToolStripMenuItem_Click);
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.devicesToolStripMenuItem.Text = "Компьютеры";
            this.devicesToolStripMenuItem.Click += new System.EventHandler(this.devicesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.Location = new System.Drawing.Point(284, 647);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(262, 52);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Удалить заявку";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 711);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CheckSoft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Учёт ПО(Администратор)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequestTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RequestTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckSoft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoftwareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNMColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StateColumn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}