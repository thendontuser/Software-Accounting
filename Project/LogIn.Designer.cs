namespace Software_Accounting_Client_
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.AutorizeBtn = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(158, 144);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(309, 22);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // LogInBtn
            // 
            this.LogInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.Location = new System.Drawing.Point(158, 194);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(145, 39);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Войти";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // AutorizeBtn
            // 
            this.AutorizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutorizeBtn.Location = new System.Drawing.Point(328, 194);
            this.AutorizeBtn.Name = "AutorizeBtn";
            this.AutorizeBtn.Size = new System.Drawing.Size(139, 39);
            this.AutorizeBtn.TabIndex = 7;
            this.AutorizeBtn.Text = "Регистрация";
            this.AutorizeBtn.UseVisualStyleBackColor = true;
            this.AutorizeBtn.Click += new System.EventHandler(this.AutorizeBtn_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(158, 62);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(309, 22);
            this.LoginTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(266, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 253);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutorizeBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button AutorizeBtn;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
    }
}