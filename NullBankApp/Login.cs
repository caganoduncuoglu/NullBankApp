using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NullBankApp
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cagan\Documents\NullBankDB.mdf;Integrated Security=True;Connect Timeout=30");

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if(roleCB.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a role");
				return;
			}
			else if (roleCB.SelectedIndex == 0)
			{
				if(usernameTB.Text == "" || passwordTB.Text == "")
				{
					MessageBox.Show("Please fill in all the information");
					return;
				}
				else
				{
					sqlConnection.Open();
					SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTbl where ADName = '" + usernameTB.Text + "' and ADPassword = '" + passwordTB.Text + "'", sqlConnection);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					if (dt.Rows[0][0].ToString() == "1")
					{
						PersonsPage persons = new PersonsPage();
						persons.Show();
						this.Hide();
						sqlConnection.Close();
					}
					else
					{
						MessageBox.Show("Wrong Admin username or password");
						usernameTB.Text = "";
						passwordTB.Text = "";
					}
					sqlConnection.Close();
				}
			}
			else
			{
				if (usernameTB.Text == "" || passwordTB.Text == "")
				{
					MessageBox.Show("Please fill in all the information");
					return;
				}
				else
				{
					sqlConnection.Open();
					SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PersonTbl where AName = '" + usernameTB.Text + "' and APassword = '" + passwordTB.Text + "'", sqlConnection);
					DataTable dt = new DataTable();
					sda.Fill(dt);
					if (dt.Rows[0][0].ToString() == "1")
					{
						UserSession.CurrentUserName = usernameTB.Text;
						MainMenu menu = new MainMenu();
						menu.Show();
						this.Hide();
						sqlConnection.Close();
					}
					else
					{
						MessageBox.Show("Wrong Username or password");
						usernameTB.Text = "";
						passwordTB.Text = "";
					}
					sqlConnection.Close();
				}
			}
		}
	}
}
