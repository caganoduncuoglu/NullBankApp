namespace NullBankApp
{
	partial class Login
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
			usernameTB = new TextBox();
			passwordTB = new TextBox();
			label2 = new Label();
			label3 = new Label();
			loginButton = new Button();
			button2 = new Button();
			roleCB = new ComboBox();
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
			panel1.TabIndex = 0;
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
			label1.TabIndex = 7;
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
			Label.TabIndex = 6;
			Label.Text = "Management System";
			Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameTB
			// 
			usernameTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			usernameTB.Location = new Point(362, 216);
			usernameTB.Name = "usernameTB";
			usernameTB.Size = new Size(337, 38);
			usernameTB.TabIndex = 1;
			// 
			// passwordTB
			// 
			passwordTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			passwordTB.Location = new Point(362, 291);
			passwordTB.Name = "passwordTB";
			passwordTB.Size = new Size(337, 38);
			passwordTB.TabIndex = 8;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label2.ForeColor = SystemColors.MenuHighlight;
			label2.Location = new Point(362, 190);
			label2.Name = "label2";
			label2.Size = new Size(102, 23);
			label2.TabIndex = 9;
			label2.Text = "Username";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label3.ForeColor = SystemColors.MenuHighlight;
			label3.Location = new Point(362, 265);
			label3.Name = "label3";
			label3.Size = new Size(96, 23);
			label3.TabIndex = 10;
			label3.Text = "Password";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// loginButton
			// 
			loginButton.AutoSize = true;
			loginButton.BackColor = SystemColors.MenuHighlight;
			loginButton.Cursor = Cursors.Hand;
			loginButton.FlatAppearance.BorderSize = 0;
			loginButton.FlatStyle = FlatStyle.Flat;
			loginButton.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			loginButton.ForeColor = Color.White;
			loginButton.Location = new Point(362, 363);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(144, 47);
			loginButton.TabIndex = 11;
			loginButton.Text = "Login";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Transparent;
			button2.BackgroundImage = Properties.Resources.Null_Bank__4__removebg_preview;
			button2.BackgroundImageLayout = ImageLayout.Stretch;
			button2.Cursor = Cursors.Hand;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.ForeColor = Color.Transparent;
			button2.Location = new Point(758, 12);
			button2.Name = "button2";
			button2.Size = new Size(30, 30);
			button2.TabIndex = 12;
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// roleCB
			// 
			roleCB.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			roleCB.FormattingEnabled = true;
			roleCB.Items.AddRange(new object[] { "Admin", "User" });
			roleCB.Location = new Point(362, 141);
			roleCB.Name = "roleCB";
			roleCB.Size = new Size(337, 34);
			roleCB.TabIndex = 31;
			roleCB.Text = "Role";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			ClientSize = new Size(800, 450);
			Controls.Add(roleCB);
			Controls.Add(button2);
			Controls.Add(loginButton);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(passwordTB);
			Controls.Add(usernameTB);
			Controls.Add(label1);
			Controls.Add(Label);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
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
		private TextBox usernameTB;
		private TextBox passwordTB;
		private Label label2;
		private Label label3;
		private Button loginButton;
		private Button button2;
		private ComboBox roleCB;
	}
}