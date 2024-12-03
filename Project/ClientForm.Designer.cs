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
            this.label4 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.GetReportBtn = new System.Windows.Forms.Button();
            this.ReportTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwareComboBox = new System.Windows.Forms.ComboBox();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLbl.Location = new System.Drawing.Point(12, 9);
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
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите название ПО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Укажите название устройства:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.Location = new System.Drawing.Point(17, 229);
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
            this.GetReportBtn.Location = new System.Drawing.Point(287, 229);
            this.GetReportBtn.Name = "GetReportBtn";
            this.GetReportBtn.Size = new System.Drawing.Size(226, 35);
            this.GetReportBtn.TabIndex = 9;
            this.GetReportBtn.Text = "Получить отчет";
            this.GetReportBtn.UseVisualStyleBackColor = true;
            this.GetReportBtn.Click += new System.EventHandler(this.GetReportBtn_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportTextBox.Location = new System.Drawing.Point(17, 308);
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.Size = new System.Drawing.Size(534, 196);
            this.ReportTextBox.TabIndex = 11;
            this.ReportTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчёты";
            // 
            // SoftwareComboBox
            // 
            this.SoftwareComboBox.FormattingEnabled = true;
            this.SoftwareComboBox.Location = new System.Drawing.Point(287, 132);
            this.SoftwareComboBox.Name = "SoftwareComboBox";
            this.SoftwareComboBox.Size = new System.Drawing.Size(264, 24);
            this.SoftwareComboBox.Sorted = true;
            this.SoftwareComboBox.TabIndex = 13;
            // 
            // DeviceComboBox
            // 
            this.DeviceComboBox.FormattingEnabled = true;
            this.DeviceComboBox.Location = new System.Drawing.Point(306, 174);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(245, 24);
            this.DeviceComboBox.Sorted = true;
            this.DeviceComboBox.TabIndex = 14;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 516);
            this.Controls.Add(this.DeviceComboBox);
            this.Controls.Add(this.SoftwareComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.GetReportBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Учёт ПО(Клиент)";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button GetReportBtn;
        private System.Windows.Forms.RichTextBox ReportTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SoftwareComboBox;
        private System.Windows.Forms.ComboBox DeviceComboBox;
    }
}