namespace NullBankApp
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}
		int startpoint = 0;
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			startpoint += 1;
			progressBar1.Value = startpoint;
			if (progressBar1.Value == 100)
			{
				progressBar1.Value = 0;
				timer1.Stop();
				Login login = new Login();
				login.Show();
				this.Hide();
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			timer1.Start();
		}
	}
}
