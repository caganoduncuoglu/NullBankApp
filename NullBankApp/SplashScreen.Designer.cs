namespace NullBankApp
{
	partial class SplashScreen
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			label1 = new Label();
			progressBar1 = new ProgressBar();
			Label = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackgroundImage = Properties.Resources.NULL;
			panel1.BackgroundImageLayout = ImageLayout.Stretch;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(progressBar1);
			panel1.Controls.Add(Label);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 450);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
			label1.ForeColor = Color.Snow;
			label1.Location = new Point(442, 279);
			label1.Name = "label1";
			label1.Size = new Size(140, 16);
			label1.TabIndex = 5;
			label1.Text = "by Çağan Oduncuoğlu";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(12, 419);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(776, 19);
			progressBar1.Style = ProgressBarStyle.Continuous;
			progressBar1.TabIndex = 4;
			// 
			// Label
			// 
			Label.Anchor = AnchorStyles.None;
			Label.AutoSize = true;
			Label.BackColor = Color.Transparent;
			Label.Font = new Font("Century", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			Label.ForeColor = Color.Snow;
			Label.Location = new Point(213, 238);
			Label.Name = "Label";
			Label.Size = new Size(378, 41);
			Label.TabIndex = 3;
			Label.Text = "Management System";
			Label.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick_1;
			// 
			// SplashScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "SplashScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label Label;
		private Label label1;
		private ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
	}
}
