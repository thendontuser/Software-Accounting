namespace Software_Accounting_Client_
{
    partial class SoftwareData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.LicenseBeginTextBox = new System.Windows.Forms.TextBox();
            this.LicenseEndTextBox = new System.Windows.Forms.TextBox();
            this.DeveloperBox = new System.Windows.Forms.ComboBox();
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            this.LogoTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseBeginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeveloperColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.VersionColumn,
            this.LicenseColumn,
            this.LicenseBeginColumn,
            this.LicenseEndColumn,
            this.DeveloperColumn,
            this.DeviceColumn,
            this.LogoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1580, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Изменение данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Версия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(374, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Лицензия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(510, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата начала действия лицензии";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(803, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата окончания действия лицензии";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1150, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Разработчик";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1294, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Установлено на устройстве";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(124, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Логотип";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 526);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(168, 22);
            this.NameTextBox.TabIndex = 10;
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Location = new System.Drawing.Point(186, 526);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(139, 22);
            this.VersionTextBox.TabIndex = 11;
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Location = new System.Drawing.Point(331, 526);
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.Size = new System.Drawing.Size(168, 22);
            this.LicenseTextBox.TabIndex = 12;
            // 
            // LicenseBeginTextBox
            // 
            this.LicenseBeginTextBox.Location = new System.Drawing.Point(514, 526);
            this.LicenseBeginTextBox.Name = "LicenseBeginTextBox";
            this.LicenseBeginTextBox.Size = new System.Drawing.Size(283, 22);
            this.LicenseBeginTextBox.TabIndex = 13;
            // 
            // LicenseEndTextBox
            // 
            this.LicenseEndTextBox.Location = new System.Drawing.Point(803, 526);
            this.LicenseEndTextBox.Name = "LicenseEndTextBox";
            this.LicenseEndTextBox.Size = new System.Drawing.Size(316, 22);
            this.LicenseEndTextBox.TabIndex = 14;
            // 
            // DeveloperBox
            // 
            this.DeveloperBox.FormattingEnabled = true;
            this.DeveloperBox.Location = new System.Drawing.Point(1125, 526);
            this.DeveloperBox.Name = "DeveloperBox";
            this.DeveloperBox.Size = new System.Drawing.Size(162, 24);
            this.DeveloperBox.Sorted = true;
            this.DeveloperBox.TabIndex = 15;
            // 
            // DeviceBox
            // 
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(1298, 526);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(241, 24);
            this.DeviceBox.Sorted = true;
            this.DeviceBox.TabIndex = 16;
            // 
            // LogoTextBox
            // 
            this.LogoTextBox.Location = new System.Drawing.Point(12, 588);
            this.LogoTextBox.Name = "LogoTextBox";
            this.LogoTextBox.Size = new System.Drawing.Size(313, 22);
            this.LogoTextBox.TabIndex = 17;
            // 
            // ChooseFileBtn
            // 
            this.ChooseFileBtn.Location = new System.Drawing.Point(76, 616);
            this.ChooseFileBtn.Name = "ChooseFileBtn";
            this.ChooseFileBtn.Size = new System.Drawing.Size(177, 46);
            this.ChooseFileBtn.TabIndex = 18;
            this.ChooseFileBtn.Text = "Выбрать файл";
            this.ChooseFileBtn.UseVisualStyleBackColor = true;
            this.ChooseFileBtn.Click += new System.EventHandler(this.ChooseFileBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1362, 616);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(177, 46);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1179, 616);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(177, 46);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(996, 616);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(177, 46);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // VersionColumn
            // 
            this.VersionColumn.HeaderText = "Версия";
            this.VersionColumn.MinimumWidth = 6;
            this.VersionColumn.Name = "VersionColumn";
            // 
            // LicenseColumn
            // 
            this.LicenseColumn.HeaderText = "Лицензия";
            this.LicenseColumn.MinimumWidth = 6;
            this.LicenseColumn.Name = "LicenseColumn";
            // 
            // LicenseBeginColumn
            // 
            this.LicenseBeginColumn.HeaderText = "Начало лицензии";
            this.LicenseBeginColumn.MinimumWidth = 6;
            this.LicenseBeginColumn.Name = "LicenseBeginColumn";
            // 
            // LicenseEndColumn
            // 
            this.LicenseEndColumn.HeaderText = "Завершение лицензии";
            this.LicenseEndColumn.MinimumWidth = 6;
            this.LicenseEndColumn.Name = "LicenseEndColumn";
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
            this.DeviceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LogoColumn
            // 
            this.LogoColumn.HeaderText = "Логотип";
            this.LogoColumn.MinimumWidth = 6;
            this.LogoColumn.Name = "LogoColumn";
            this.LogoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LogoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoftwareData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 674);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ChooseFileBtn);
            this.Controls.Add(this.LogoTextBox);
            this.Controls.Add(this.DeviceBox);
            this.Controls.Add(this.DeveloperBox);
            this.Controls.Add(this.LicenseEndTextBox);
            this.Controls.Add(this.LicenseBeginTextBox);
            this.Controls.Add(this.LicenseTextBox);
            this.Controls.Add(this.VersionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SoftwareData";
            this.Text = "Программное обеспечение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SoftwareData_FormClosed);
            this.Load += new System.EventHandler(this.SoftwareData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.TextBox LicenseTextBox;
        private System.Windows.Forms.TextBox LicenseBeginTextBox;
        private System.Windows.Forms.TextBox LicenseEndTextBox;
        private System.Windows.Forms.ComboBox DeveloperBox;
        private System.Windows.Forms.ComboBox DeviceBox;
        private System.Windows.Forms.TextBox LogoTextBox;
        private System.Windows.Forms.Button ChooseFileBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseBeginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseEndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeveloperColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceColumn;
        private System.Windows.Forms.DataGridViewImageColumn LogoColumn;
    }
}