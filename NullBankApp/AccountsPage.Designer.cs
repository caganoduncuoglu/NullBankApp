namespace NullBankApp
{
	partial class AccountsPage
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			panel1 = new Panel();
			pictureBox1 = new PictureBox();
			transactionsButton = new Button();
			accountsButton = new Button();
			backButton = new Button();
			closeButton = new Button();
			Label = new Label();
			label2 = new Label();
			acNameTB = new TextBox();
			label1 = new Label();
			acPhoneTB = new TextBox();
			label3 = new Label();
			acAddressTB = new TextBox();
			label4 = new Label();
			acIncomeTB = new TextBox();
			educationCB = new ComboBox();
			label5 = new Label();
			label6 = new Label();
			countryCB = new ComboBox();
			submitButton = new Button();
			AccountsDGV = new DataGridView();
			editButton = new Button();
			deleteButton = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)AccountsDGV).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.MenuHighlight;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(transactionsButton);
			panel1.Controls.Add(accountsButton);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(84, 721);
			panel1.TabIndex = 0;
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
			// transactionsButton
			// 
			transactionsButton.BackColor = Color.Transparent;
			transactionsButton.BackgroundImage = Properties.Resources.Null_Bank__9__removebg_preview;
			transactionsButton.BackgroundImageLayout = ImageLayout.Zoom;
			transactionsButton.Cursor = Cursors.Hand;
			transactionsButton.FlatAppearance.BorderSize = 0;
			transactionsButton.FlatStyle = FlatStyle.Flat;
			transactionsButton.Location = new Point(0, 175);
			transactionsButton.Name = "transactionsButton";
			transactionsButton.Size = new Size(84, 75);
			transactionsButton.TabIndex = 3;
			transactionsButton.UseVisualStyleBackColor = false;
			transactionsButton.Click += transactionsButton_Click;
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
			backButton.TabIndex = 4;
			backButton.UseVisualStyleBackColor = false;
			backButton.Click += backButton_Click;
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
			closeButton.TabIndex = 19;
			closeButton.UseVisualStyleBackColor = false;
			closeButton.Click += closeButton_Click;
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
			Label.Size = new Size(291, 34);
			Label.TabIndex = 20;
			Label.Text = "New Account Form";
			Label.TextAlign = ContentAlignment.MiddleCenter;
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
			label2.TabIndex = 22;
			label2.Text = "Name";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acNameTB
			// 
			acNameTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acNameTB.Location = new Point(184, 131);
			acNameTB.Name = "acNameTB";
			acNameTB.Size = new Size(218, 38);
			acNameTB.TabIndex = 21;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label1.ForeColor = SystemColors.MenuHighlight;
			label1.Location = new Point(446, 105);
			label1.Name = "label1";
			label1.Size = new Size(67, 23);
			label1.TabIndex = 24;
			label1.Text = "Phone";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acPhoneTB
			// 
			acPhoneTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acPhoneTB.Location = new Point(446, 131);
			acPhoneTB.Name = "acPhoneTB";
			acPhoneTB.Size = new Size(218, 38);
			acPhoneTB.TabIndex = 23;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label3.ForeColor = SystemColors.MenuHighlight;
			label3.Location = new Point(704, 105);
			label3.Name = "label3";
			label3.Size = new Size(82, 23);
			label3.TabIndex = 26;
			label3.Text = "Address";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acAddressTB
			// 
			acAddressTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acAddressTB.Location = new Point(704, 131);
			acAddressTB.Multiline = true;
			acAddressTB.Name = "acAddressTB";
			acAddressTB.Size = new Size(229, 119);
			acAddressTB.TabIndex = 25;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label4.ForeColor = SystemColors.MenuHighlight;
			label4.Location = new Point(446, 186);
			label4.Name = "label4";
			label4.Size = new Size(75, 23);
			label4.TabIndex = 28;
			label4.Text = "Income";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// acIncomeTB
			// 
			acIncomeTB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			acIncomeTB.Location = new Point(446, 212);
			acIncomeTB.Name = "acIncomeTB";
			acIncomeTB.Size = new Size(218, 38);
			acIncomeTB.TabIndex = 27;
			// 
			// educationCB
			// 
			educationCB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			educationCB.FormattingEnabled = true;
			educationCB.Items.AddRange(new object[] { "No Formal Education", "High School Diploma or Equivalent", "Associate's Degree", "Bachelor's Degree", "Master's Degree", "Doctorate (Ph.D.)", "Professional Certification", "Some College, No Degree", "Technical Diploma", "GED", "Other" });
			educationCB.Location = new Point(184, 208);
			educationCB.Name = "educationCB";
			educationCB.Size = new Size(218, 42);
			educationCB.TabIndex = 29;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label5.ForeColor = SystemColors.MenuHighlight;
			label5.Location = new Point(184, 179);
			label5.Name = "label5";
			label5.Size = new Size(101, 23);
			label5.TabIndex = 30;
			label5.Text = "Education";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			label6.ForeColor = SystemColors.MenuHighlight;
			label6.Location = new Point(973, 105);
			label6.Name = "label6";
			label6.Size = new Size(83, 23);
			label6.TabIndex = 32;
			label6.Text = "Country";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// countryCB
			// 
			countryCB.Font = new Font("Franklin Gothic Book", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
			countryCB.FormattingEnabled = true;
			countryCB.Items.AddRange(new object[] { "Turkiye", "United States", "", "Canada", "", "United Kingdom", "", "Germany", "", "France", "", "China", "", "India", "", "Japan", "", "Australia", "", "Brazil", "", "Mexico", "", "Russia", "", "South Korea", "", "Italy", "", "Spain", "", "Netherlands", "", "Switzerland", "", "Sweden", "", "South Africa", "", "New Zealand", "", "Other" });
			countryCB.Location = new Point(973, 131);
			countryCB.Name = "countryCB";
			countryCB.Size = new Size(164, 42);
			countryCB.TabIndex = 31;
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
			submitButton.Size = new Size(84, 42);
			submitButton.TabIndex = 33;
			submitButton.Text = "Submit";
			submitButton.UseVisualStyleBackColor = false;
			submitButton.Click += submitButton_Click;
			// 
			// AccountsDGV
			// 
			AccountsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			AccountsDGV.BackgroundColor = Color.Gainsboro;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
			AccountsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			AccountsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			AccountsDGV.DefaultCellStyle = dataGridViewCellStyle2;
			AccountsDGV.Location = new Point(145, 309);
			AccountsDGV.Name = "AccountsDGV";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			AccountsDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
			AccountsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			AccountsDGV.Size = new Size(1085, 372);
			AccountsDGV.TabIndex = 34;
			AccountsDGV.CellContentClick += AccountsDGV_CellContentClick;
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
			editButton.TabIndex = 35;
			editButton.Text = "Edit";
			editButton.UseVisualStyleBackColor = false;
			editButton.Click += editButton_Click;
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
			deleteButton.TabIndex = 36;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = false;
			deleteButton.Click += deleteButton_Click;
			// 
			// AccountsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1280, 720);
			Controls.Add(deleteButton);
			Controls.Add(editButton);
			Controls.Add(AccountsDGV);
			Controls.Add(submitButton);
			Controls.Add(label6);
			Controls.Add(countryCB);
			Controls.Add(label5);
			Controls.Add(educationCB);
			Controls.Add(label4);
			Controls.Add(acIncomeTB);
			Controls.Add(label3);
			Controls.Add(acAddressTB);
			Controls.Add(label1);
			Controls.Add(acPhoneTB);
			Controls.Add(label2);
			Controls.Add(acNameTB);
			Controls.Add(Label);
			Controls.Add(closeButton);
			Controls.Add(panel1);
			Controls.Add(backButton);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AccountsPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AccountsPage";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)AccountsDGV).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Button backButton;
		private Button transactionsButton;
		private Button accountsButton;
		private Button closeButton;
		private Label Label;
		private Label label2;
		private TextBox acNameTB;
		private Label label1;
		private TextBox acPhoneTB;
		private Label label3;
		private TextBox acAddressTB;
		private Label label4;
		private TextBox acIncomeTB;
		private ComboBox educationCB;
		private Label label5;
		private Label label6;
		private ComboBox countryCB;
		private Button submitButton;
		private DataGridView AccountsDGV;
		private Button editButton;
		private Button deleteButton;
	}
}