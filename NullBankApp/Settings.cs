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
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			this.Hide();
		}
	}
}
