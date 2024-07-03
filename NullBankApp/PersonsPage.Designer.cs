namespace NullBankApp
{
	partial class PersonsPage
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			deleteButton = new Button();
			editButton = new Button();
			PersonsDGV = new DataGridView();
			submitButton = new Button();
			label3 = new Label();
			accountsButton = new Button();
			acAddressTB = new TextBox();
			label1 = new Label();
			label2 = new Label();
			acNameTB = new TextBox();
			Label = new Label();
			closeButton = new Button();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			acPhoneTB = new TextBox();
			backButton = new Button();
			acPassword = new Label();
			acPasswordTB = new TextBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)PersonsDGV).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// deleteButton
			// 
			deleteButton.AutoSize = true;
			deleteButton.BackColor = Color.IndianRed;
			deleteButton.Cursor = Cursors.Hand;
			deleteButton.FlatAppearance.BorderSize = 0;
			deleteButton.FlatStyle = FlatStyle.Flat;
			deleteButton.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			deleteButton.ForeColor = Color.White;
			deleteButton.Location = new Point(1119, 208);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(107, 42);
			deleteButton.TabIndex = 56;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = false;
			deleteButton.Click += deleteButton_Click;
			// 
			// editButton
			// 
			editButton.AutoSize = true;
			editButton.BackColor = SystemColors.MenuHighlight;
			editButton.Cursor = Cursors.Hand;
			editButton.FlatAppearance.BorderSize = 0;
			editButton.FlatStyle = FlatStyle.Flat;
			editButton.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			editButton.ForeColor = Color.White;
			editButton.Location = new Point(973, 208);
			editButton.Name = "editButton";
			editButton.Size = new Size(111, 42);
			editButton.TabIndex = 55;
			editButton.Text = "Edit";
			editButton.UseVisualStyleBackColor = false;
			editButton.Click += editButton_Click;
			// 
			// PersonsDGV
			// 
			PersonsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			PersonsDGV.BackgroundColor = Color.Gainsboro;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			PersonsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			PersonsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			PersonsDGV.DefaultCellStyle = dataGridViewCellStyle5;
			PersonsDGV.Location = new Point(145, 309);
			PersonsDGV.Name = "PersonsDGV";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			PersonsDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
			PersonsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			PersonsDGV.Size = new Size(1085, 372);
			PersonsDGV.TabIndex = 54;
			PersonsDGV.CellContentClick += PersonsDGV_CellContentClick;
			// 
			// submitButton
			// 
			submitButton.AutoSize = true;
			submitButton.BackColor = SystemColors.MenuHighlight;
			submitButton.Cursor = Cursors.Hand;
			submitButton.FlatAppearance.BorderSize = 0;
			submitButton.FlatStyle = FlatStyle.Flat;
			submitButton.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
			submitButton.ForeColor = Color.White;
			submitButton.Location = new Point(1143, 131);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(84, 38);
			submitButton.TabIndex = 53;
			submitButton.Text = "Submit";
			submitButton.UseVisualStyleBackColor = false;
			submitButton.Click += submitButton_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label3.ForeColor = SystemColors.MenuHighlight;
			label3.Location = new Point(696, 105);
			label3.Name = "label3";
			label3.Size = new Size(82, 23);
			label3.TabIndex = 46;
			label3.Text = "Address";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// accountsButton
			// 
			accountsButton.BackColor = Color.Transparent;
			accountsButton.BackgroundImage = Properties.Resources.Null_Bank__10__removebg_preview1;
			accountsButton.BackgroundImageLayout = ImageLayout.Zoom;
			accountsButton.Cursor = Cursors.Hand;
			accountsButton.FlatAppearance.BorderSize = 0;
			accountsButton.FlatStyle = FlatStyle.Flat;
			accountsButton.Location = new Point(0, 94);
			accountsButton.Name = "accountsButton";
			accountsButton.Size = new Size(84, 75);
			accountsButton.TabIndex = 2;
			accountsButton.UseVisualStyleBackColor = false;
			// 
			// acAddressTB
			// 
			acAddressTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acAddressTB.Location = new Point(696, 131);
			acAddressTB.Multiline = true;
			acAddressTB.Name = "acAddressTB";
			acAddressTB.Size = new Size(229, 119);
			acAddressTB.TabIndex = 45;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.MenuHighlight;
			label1.Location = new Point(949, 105);
			label1.Name = "label1";
			label1.Size = new Size(67, 23);
			label1.TabIndex = 44;
			label1.Text = "Phone";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label2.ForeColor = SystemColors.MenuHighlight;
			label2.Location = new Point(184, 105);
			label2.Name = "label2";
			label2.Size = new Size(63, 23);
			label2.TabIndex = 42;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acNameTB
			// 
			acNameTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acNameTB.Location = new Point(184, 131);
			acNameTB.Name = "acNameTB";
			acNameTB.Size = new Size(218, 38);
			acNameTB.TabIndex = 41;
			// 
			// Label
			// 
			Label.Anchor = AnchorStyles.None;
			Label.AutoSize = true;
			Label.BackColor = Color.Transparent;
			Label.Font = new Font("Century", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Label.ForeColor = SystemColors.MenuHighlight;
			Label.Location = new Point(509, 12);
			Label.Name = "Label";
			Label.Size = new Size(365, 34);
			Label.TabIndex = 40;
			Label.Text = "New Person(User) Form";
			Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// closeButton
			// 
			closeButton.BackColor = Color.Transparent;
			closeButton.BackgroundImage = Properties.Resources.Null_Bank__4__removebg_preview;
			closeButton.BackgroundImageLayout = ImageLayout.Stretch;
			closeButton.Cursor = Cursors.Hand;
			closeButton.FlatAppearance.BorderSize = 0;
			closeButton.FlatStyle = FlatStyle.Flat;
			closeButton.ForeColor = Color.Transparent;
			closeButton.Location = new Point(1238, 12);
			closeButton.Name = "closeButton";
			closeButton.Size = new Size(30, 30);
			closeButton.TabIndex = 39;
			closeButton.UseVisualStyleBackColor = false;
			closeButton.Click += closeButton_Click_1;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.MenuHighlight;
			panel1.Controls.Add(label4);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(accountsButton);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(84, 721);
			panel1.TabIndex = 37;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = SystemColors.MenuHighlight;
			pictureBox1.BackgroundImage = Properties.Resources.NullBankLogoBG;
			pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			pictureBox1.Image = Properties.Resources.NullBankLogoBG;
			pictureBox1.Location = new Point(-28, -9);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(143, 107);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// acPhoneTB
			// 
			acPhoneTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acPhoneTB.Location = new Point(949, 131);
			acPhoneTB.Name = "acPhoneTB";
			acPhoneTB.Size = new Size(188, 38);
			acPhoneTB.TabIndex = 43;
			// 
			// backButton
			// 
			backButton.BackColor = Color.Transparent;
			backButton.BackgroundImage = Properties.Resources.Null_Bank__2__removebg_preview;
			backButton.BackgroundImageLayout = ImageLayout.Stretch;
			backButton.Cursor = Cursors.Hand;
			backButton.FlatAppearance.BorderSize = 0;
			backButton.FlatStyle = FlatStyle.Flat;
			backButton.Location = new Point(90, 12);
			backButton.Name = "backButton";
			backButton.Size = new Size(30, 30);
			backButton.TabIndex = 38;
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click_1;
			// 
			// acPassword
			// 
			acPassword.Anchor = AnchorStyles.None;
			acPassword.AutoSize = true;
			acPassword.BackColor = Color.Transparent;
			acPassword.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acPassword.ForeColor = SystemColors.MenuHighlight;
			acPassword.Location = new Point(448, 105);
			acPassword.Name = "acPassword";
			acPassword.Size = new Size(96, 23);
			acPassword.TabIndex = 58;
			acPassword.Text = "Password";
			acPassword.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acPasswordTB
			// 
			acPasswordTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acPasswordTB.Location = new Point(448, 131);
			acPasswordTB.Name = "acPasswordTB";
			acPasswordTB.Size = new Size(218, 38);
			acPasswordTB.TabIndex = 57;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label4.ForeColor = Color.White;
			label4.Location = new Point(7, 165);
			label4.Name = "label4";
			label4.Size = new Size(70, 23);
			label4.TabIndex = 59;
			label4.Text = "Admin";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// PersonsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 720);
			Controls.Add(acPassword);
			Controls.Add(acPasswordTB);
			Controls.Add(deleteButton);
			Controls.Add(editButton);
			Controls.Add(PersonsDGV);
			Controls.Add(submitButton);
			Controls.Add(label3);
			Controls.Add(acAddressTB);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(acNameTB);
			Controls.Add(Label);
			Controls.Add(closeButton);
			Controls.Add(panel1);
			Controls.Add(acPhoneTB);
			Controls.Add(backButton);
			FormBorderStyle = FormBorderStyle.None;
			Name = "PersonsPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PersonsPage";
			((System.ComponentModel.ISupportInitialize)PersonsDGV).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button deleteButton;
		private Button editButton;
		private DataGridView PersonsDGV;
		private Button submitButton;
		private Label label3;
		private Button accountsButton;
		private TextBox acAddressTB;
		private Label label1;
		private Label label2;
		private TextBox acNameTB;
		private Label Label;
		private Button closeButton;
		private Panel panel1;
		private PictureBox pictureBox1;
		private TextBox acPhoneTB;
		private Button backButton;
		private Label acPassword;
		private TextBox acPasswordTB;
		private Label label4;
	}
}