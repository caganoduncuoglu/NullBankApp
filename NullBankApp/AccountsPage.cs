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
	public partial class AccountsPage : Form
	{
		public AccountsPage()
		{
			InitializeComponent();
			DisplayAccounts();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cagan\Documents\NullBankDB.mdf;Integrated Security=True;Connect Timeout=30");

		private void DisplayAccounts()
		{
			try
			{
				sqlConnection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("select * from AccountTbl", sqlConnection);
				SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
				var ds = new DataSet();
				adapter.Fill(ds);
				AccountsDGV.DataSource = ds.Tables[0];
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void backButton_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			this.Hide();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void transactionsButton_Click(object sender, EventArgs e)
		{
			Transactions transactions = new Transactions();
			transactions.Show();
			this.Hide();
		}

		private void Reset()
		{
			acNameTB.Text = "";
			acPhoneTB.Text = "";
			acAddressTB.Text = "";
			acIncomeTB.Text = "";
			typeCB.SelectedIndex = -1;
			countryCB.SelectedIndex = -1;
		}
		private void submitButton_Click(object sender, EventArgs e)
		{
			if (acNameTB.Text == "" || acPhoneTB.Text == "" || acAddressTB.Text == ""
				|| acIncomeTB.Text == "" || typeCB.SelectedIndex == -1 || countryCB.SelectedIndex == -1)
			{
				MessageBox.Show("Please fill in all the information");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					string insertAccountQuery = "INSERT INTO AccountTbl(ACName,ACPhone,ACAddress,ACType,ACCountry,ACBal,ACIncome) " +
									   "VALUES(@AN,@AP,@AA,@AT,@AC,@AB,@AI); SELECT SCOPE_IDENTITY();";
					SqlCommand cmd = new SqlCommand(insertAccountQuery, sqlConnection);
					cmd.Parameters.AddWithValue("@AN", acNameTB.Text);
					cmd.Parameters.AddWithValue("@AP", acPhoneTB.Text);
					cmd.Parameters.AddWithValue("@AA", acAddressTB.Text);
					cmd.Parameters.AddWithValue("@AT", typeCB.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("@AC", countryCB.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("@AB", 0);
					cmd.Parameters.AddWithValue("@AI", acIncomeTB.Text);
					//cmd.ExecuteNonQuery();

					// Execute and get the inserted account's ID
					object result = cmd.ExecuteScalar();
					if (result != null)
					{
						int accountId = Convert.ToInt32(result);

						// Check if the account type is investment
						if (typeCB.SelectedIndex == 2)
						{
							// Insert into InvestmentAccounts
							SqlCommand investmentCmd = new SqlCommand("INSERT INTO InvestmentAccountsTbl(ACNum,IGold,IUSD,IEUR) VALUES(@ACNum,@Gold,@USD,@EUR)", sqlConnection);
							investmentCmd.Parameters.AddWithValue("@ACNum", accountId);
							investmentCmd.Parameters.AddWithValue("@Gold", 0.0);  // Initial gold balance
							investmentCmd.Parameters.AddWithValue("@USD", 0.0);   // Initial USD balance
							investmentCmd.Parameters.AddWithValue("@EUR", 0.0);   // Initial EUR balance

							investmentCmd.ExecuteNonQuery();
						}

						MessageBox.Show("Account Created Successfully");
					}
					else
					{
						MessageBox.Show("Failed to retrieve the account ID after insertion.");
					}

					sqlConnection.Close();
					Reset();
					DisplayAccounts();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			if (acNameTB.Text == "" || acPhoneTB.Text == "" || acAddressTB.Text == ""
				|| acIncomeTB.Text == "" || typeCB.SelectedIndex == -1 || countryCB.SelectedIndex == -1)
			{
				MessageBox.Show("Please select an account!");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					SqlCommand cmd = new SqlCommand("Update AccountTbl set ACName=@AN,ACPhone=@AP,ACAddress=@AA,ACType=@AT,ACCountry=@AC,ACIncome=@AI where ACNum=@ACKey", sqlConnection);
					cmd.Parameters.AddWithValue("@AN", acNameTB.Text);
					cmd.Parameters.AddWithValue("@AP", acPhoneTB.Text);
					cmd.Parameters.AddWithValue("@AA", acAddressTB.Text);
					cmd.Parameters.AddWithValue("@AT", typeCB.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("@AC", countryCB.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("ACKey", Key);
					cmd.Parameters.AddWithValue("@AI", acIncomeTB.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Account Updated Successfully");
					sqlConnection.Close();
					Reset();
					DisplayAccounts();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (Key == 0)
			{
				MessageBox.Show("Please select an account!");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					if (typeCB.SelectedIndex == 2)
					{
						SqlCommand investmentCmd = new SqlCommand("delete from InvestmentAccountsTbl where ACNum=@ACKey", sqlConnection);
						investmentCmd.Parameters.AddWithValue("@ACKey", Key);
						investmentCmd.ExecuteNonQuery();
					}
					SqlCommand cmd = new SqlCommand("delete from AccountTbl where ACNum=@ACKey", sqlConnection);
					cmd.Parameters.AddWithValue("@ACKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Account Deleted Successfully");
					sqlConnection.Close();
					Reset();
					DisplayAccounts();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		int Key = 0;
		private void AccountsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			acNameTB.Text = AccountsDGV.SelectedRows[0].Cells[1].Value.ToString();
			acPhoneTB.Text = AccountsDGV.SelectedRows[0].Cells[2].Value.ToString();
			acAddressTB.Text = AccountsDGV.SelectedRows[0].Cells[3].Value.ToString();
			typeCB.SelectedItem = AccountsDGV.SelectedRows[0].Cells[7].Value.ToString();
			countryCB.SelectedItem = AccountsDGV.SelectedRows[0].Cells[4].Value.ToString();
			acIncomeTB.Text = AccountsDGV.SelectedRows[0].Cells[6].Value.ToString();
			if (acNameTB.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(AccountsDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void investmentsBtn_Click(object sender, EventArgs e)
		{
			Investments investments = new Investments();
			investments.Show();
			this.Hide();
		}
	}
}
