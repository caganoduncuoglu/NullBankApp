using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullBankApp
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
			updateUsername();
		}

		private void updateUsername()
		{
			userNameLabel.Text = UserSession.CurrentUserName;
		}
		private void accountsButton_Click(object sender, EventArgs e)
		{
			AccountsPage accounts = new AccountsPage();
			accounts.Show();
			this.Hide();
		}

		private void transactionButton_Click(object sender, EventArgs e)
		{
			Transactions transactions = new Transactions();
			transactions.Show();
			this.Hide();
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			Settings settings = new Settings();
			settings.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void investmentsBtn_Click(object sender, EventArgs e)
		{
			Investments investments = new Investments();
			investments.Show();
			this.Hide();
		}
	}
}
