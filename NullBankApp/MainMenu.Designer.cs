namespace NullBankApp
{
	partial class MainMenu
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
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			Label = new Label();
			label2 = new Label();
			userNameLabel = new Label();
			accountsButton = new Button();
			transactionButton = new Button();
			settingsButton = new Button();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			button4 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.MenuHighlight;
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(302, 450);
			panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = Properties.Resources.NullBankLogoBG;
			pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			pictureBox1.Location = new Point(0, -66);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(302, 293);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.MenuHighlight;
			label1.Location = new Point(591, 67);
			label1.Name = "label1";
			label1.Size = new Size(140, 16);
			label1.TabIndex = 9;
			label1.Text = "by Çağan Oduncuoğlu";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Label
			// 
			Label.Anchor = AnchorStyles.None;
			Label.AutoSize = true;
			Label.BackColor = Color.Transparent;
			Label.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Label.ForeColor = SystemColors.MenuHighlight;
			Label.Location = new Point(362, 26);
			Label.Name = "Label";
			Label.Size = new Size(378, 41);
			Label.TabIndex = 8;
			Label.Text = "Management System";
			Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label2.ForeColor = SystemColors.MenuHighlight;
			label2.Location = new Point(362, 168);
			label2.Name = "label2";
			label2.Size = new Size(95, 23);
			label2.TabIndex = 10;
			label2.Text = "Welcome,";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// userNameLabel
			// 
			userNameLabel.Anchor = AnchorStyles.None;
			userNameLabel.AutoSize = true;
			userNameLabel.BackColor = Color.Transparent;
			userNameLabel.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			userNameLabel.ForeColor = SystemColors.MenuHighlight;
			userNameLabel.Location = new Point(458, 168);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new Size(52, 23);
			userNameLabel.TabIndex = 11;
			userNameLabel.Text = "User";
			userNameLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// accountsButton
			// 
			accountsButton.BackColor = Color.Transparent;
			accountsButton.BackgroundImage = Properties.Resources.Accounts;
			accountsButton.BackgroundImageLayout = ImageLayout.Zoom;
			accountsButton.FlatAppearance.BorderSize = 0;
			accountsButton.FlatStyle = FlatStyle.Flat;
			accountsButton.Location = new Point(362, 244);
			accountsButton.Name = "accountsButton";
			accountsButton.Size = new Size(80, 80);
			accountsButton.TabIndex = 12;
			accountsButton.UseVisualStyleBackColor = false;
			accountsButton.Click += accountsButton_Click;
			// 
			// transactionButton
			// 
			transactionButton.BackColor = Color.Transparent;
			transactionButton.BackgroundImage = Properties.Resources.Transactions;
			transactionButton.BackgroundImageLayout = ImageLayout.Zoom;
			transactionButton.FlatAppearance.BorderSize = 0;
			transactionButton.FlatStyle = FlatStyle.Flat;
			transactionButton.Location = new Point(510, 244);
			transactionButton.Name = "transactionButton";
			transactionButton.Size = new Size(80, 80);
			transactionButton.TabIndex = 13;
			transactionButton.UseVisualStyleBackColor = false;
			transactionButton.Click += transactionButton_Click;
			// 
			// settingsButton
			// 
			settingsButton.BackColor = Color.Transparent;
			settingsButton.BackgroundImage = Properties.Resources.Settings;
			settingsButton.BackgroundImageLayout = ImageLayout.Zoom;
			settingsButton.FlatAppearance.BorderSize = 0;
			settingsButton.FlatStyle = FlatStyle.Flat;
			settingsButton.Location = new Point(651, 244);
			settingsButton.Name = "settingsButton";
			settingsButton.Size = new Size(80, 80);
			settingsButton.TabIndex = 14;
			settingsButton.UseVisualStyleBackColor = false;
			settingsButton.Click += settingsButton_Click;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Century", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label4.ForeColor = SystemColors.MenuHighlight;
			label4.Location = new Point(362, 327);
			label4.Name = "label4";
			label4.Size = new Size(82, 21);
			label4.TabIndex = 15;
			label4.Text = "Accounts";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Century", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label5.ForeColor = SystemColors.MenuHighlight;
			label5.Location = new Point(498, 327);
			label5.Name = "label5";
			label5.Size = new Size(104, 21);
			label5.TabIndex = 16;
			label5.Text = "Transaction";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Century", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label6.ForeColor = SystemColors.MenuHighlight;
			label6.Location = new Point(655, 327);
			label6.Name = "label6";
			label6.Size = new Size(76, 21);
			label6.TabIndex = 17;
			label6.Text = "Settings";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			button4.BackColor = Color.Transparent;
			button4.BackgroundImage = Properties.Resources.Null_Bank__4__removebg_preview;
			button4.BackgroundImageLayout = ImageLayout.Stretch;
			button4.Cursor = Cursors.Hand;
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = FlatStyle.Flat;
			button4.ForeColor = Color.Transparent;
			button4.Location = new Point(758, 12);
			button4.Name = "button4";
			button4.Size = new Size(30, 30);
			button4.TabIndex = 18;
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button4);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(settingsButton);
			Controls.Add(transactionButton);
			Controls.Add(accountsButton);
			Controls.Add(userNameLabel);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(Label);
			Controls.Add(panel1);
			Cursor = Cursors.Hand;
			FormBorderStyle = FormBorderStyle.None;
			Name = "MainMenu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MainMenu";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label label1;
		private Label Label;
		private Label label2;
		private Label userNameLabel;
		private Button accountsButton;
		private Button transactionButton;
		private Button settingsButton;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button button4;
	}
}