namespace DbGui
{
	partial class LoginForm
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
			this.AuthGroupBox = new System.Windows.Forms.GroupBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginLabel = new System.Windows.Forms.Label();
			this.AuthGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// AuthGroupBox
			// 
			this.AuthGroupBox.Controls.Add(this.loginButton);
			this.AuthGroupBox.Controls.Add(this.passwordTextBox);
			this.AuthGroupBox.Controls.Add(this.loginTextBox);
			this.AuthGroupBox.Controls.Add(this.passwordLabel);
			this.AuthGroupBox.Controls.Add(this.loginLabel);
			this.AuthGroupBox.Location = new System.Drawing.Point(148, 135);
			this.AuthGroupBox.Name = "AuthGroupBox";
			this.AuthGroupBox.Size = new System.Drawing.Size(466, 179);
			this.AuthGroupBox.TabIndex = 0;
			this.AuthGroupBox.TabStop = false;
			this.AuthGroupBox.Text = "Выполните вход";
			this.AuthGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// loginButton
			// 
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Location = new System.Drawing.Point(338, 150);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(122, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Постучаться и войти";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(132, 85);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(241, 20);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
			// 
			// loginTextBox
			// 
			this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loginTextBox.Location = new System.Drawing.Point(132, 35);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(241, 20);
			this.loginTextBox.TabIndex = 2;
			this.loginTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(58, 92);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Пароль";
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(65, 42);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(38, 13);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Логин";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AuthGroupBox);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "LoginForm";
			this.Text = "Login Form";
			this.AuthGroupBox.ResumeLayout(false);
			this.AuthGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox AuthGroupBox;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button loginButton;
	}
}

