namespace NullBankApp
{
	partial class Settings
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
			Label = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			textBox2 = new TextBox();
			button5 = new Button();
			button1 = new Button();
			backButton = new Button();
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
			panel1.TabIndex = 2;
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
			// Label
			// 
			Label.Anchor = AnchorStyles.None;
			Label.AutoSize = true;
			Label.BackColor = Color.Transparent;
			Label.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Label.ForeColor = SystemColors.MenuHighlight;
			Label.Location = new Point(462, 22);
			Label.Name = "Label";
			Label.Size = new Size(161, 41);
			Label.TabIndex = 9;
			Label.Text = "Settings";
			Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label2.ForeColor = SystemColors.MenuHighlight;
			label2.Location = new Point(386, 237);
			label2.Name = "label2";
			label2.Size = new Size(206, 23);
			label2.TabIndex = 24;
			label2.Text = "Admin New Password";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			textBox1.Location = new Point(386, 157);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(218, 38);
			textBox1.TabIndex = 23;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.MenuHighlight;
			label1.Location = new Point(386, 131);
			label1.Name = "label1";
			label1.Size = new Size(137, 23);
			label1.TabIndex = 26;
			label1.Text = "Change Name";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			textBox2.Location = new Point(386, 263);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(218, 38);
			textBox2.TabIndex = 25;
			// 
			// button5
			// 
			button5.AutoSize = true;
			button5.BackColor = SystemColors.MenuHighlight;
			button5.Cursor = Cursors.Hand;
			button5.FlatAppearance.BorderSize = 0;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			button5.ForeColor = Color.White;
			button5.Location = new Point(630, 157);
			button5.Name = "button5";
			button5.Size = new Size(92, 38);
			button5.TabIndex = 34;
			button5.Text = "Apply";
			button5.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.BackColor = SystemColors.MenuHighlight;
			button1.Cursor = Cursors.Hand;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			button1.ForeColor = Color.White;
			button1.Location = new Point(630, 263);
			button1.Name = "button1";
			button1.Size = new Size(92, 38);
			button1.TabIndex = 35;
			button1.Text = "Apply";
			button1.UseVisualStyleBackColor = false;
			// 
			// backButton
			// 
			backButton.BackColor = Color.Transparent;
			backButton.BackgroundImage = Properties.Resources.Null_Bank__2__removebg_preview;
			backButton.BackgroundImageLayout = ImageLayout.Stretch;
			backButton.Cursor = Cursors.Hand;
			backButton.FlatAppearance.BorderSize = 0;
			backButton.FlatStyle = FlatStyle.Flat;
			backButton.Location = new Point(308, 12);
			backButton.Name = "backButton";
			backButton.Size = new Size(30, 30);
			backButton.TabIndex = 36;
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click;
			// 
			// Settings
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(backButton);
			Controls.Add(button1);
			Controls.Add(button5);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(Label);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Settings";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Settings";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Label Label;
		private Label label2;
		private TextBox textBox1;
		private Label label1;
		private TextBox textBox2;
		private Button button5;
		private Button button1;
		private Button backButton;
	}
}