using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NullBankApp
{
	public partial class Transactions : Form
	{
		public Transactions()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cagan\Documents\NullBankDB.mdf;Integrated Security=True;Connect Timeout=30");


		private void accountsButton_Click(object sender, EventArgs e)
		{
			AccountsPage accounts = new AccountsPage();
			accounts.Show();
			this.Hide();
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

		int balance;
		private void CheckBalance()
		{
			try
			{
				sqlConnection.Open();
				string query = "select * from AccountTbl where ACNum = '" + checkBalanceTB.Text + "'";
				SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				foreach (DataRow dataRow in dataTable.Rows)
				{
					balanceLabel.Text = dataRow["ACBal"].ToString() + " TL";
					balance = Convert.ToInt32(dataRow["ACBal"]);
				}
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void GetNewBalance(string account)
		{
			sqlConnection.Open();
			string query = "select * from AccountTbl where ACNum = '" + account + "'";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			foreach (DataRow dataRow in dataTable.Rows)
			{
				balance = Convert.ToInt32(dataRow["ACBal"]);
			}
			sqlConnection.Close();
		}
		private void balanceButton_Click(object sender, EventArgs e)
		{
			if (checkBalanceTB.Text == "")
			{
				MessageBox.Show("Please enter an account number");
			}
			else
			{
				CheckBalance();
				if (balanceLabel.Text == "Your Balance")
				{
					MessageBox.Show("Account number not found");
					checkBalanceTB.Text = "";
				}
			}
		}

		private void SubstractBal()
		{
			GetNewBalance(fromTB.Text);
			int newBalance = balance - Convert.ToInt32(transferAmountTB.Text);
			try
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("Update AccountTbl set ACBal=@AB where ACNum=@ACKey", sqlConnection);
				cmd.Parameters.AddWithValue("@AB", newBalance);
				cmd.Parameters.AddWithValue("ACKey", fromTB.Text);
				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void AddBal()
		{
			GetNewBalance(toTB.Text);
			int newBalance = balance + Convert.ToInt32(transferAmountTB.Text);
			try
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("Update AccountTbl set ACBal=@AB where ACNum=@ACKey", sqlConnection);
				cmd.Parameters.AddWithValue("@AB", newBalance);
				cmd.Parameters.AddWithValue("ACKey", toTB.Text);
				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void Deposit()
		{
			try
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmount,TACNum)values(@TN,@TD,@TA,@TAC)", sqlConnection);
				cmd.Parameters.AddWithValue("@TN", "Deposit");
				cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
				cmd.Parameters.AddWithValue("@TA", depositAmountTB.Text);
				cmd.Parameters.AddWithValue("@TAC", accNumDepTB.Text);

				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				sqlConnection.Close();
			}
		}
		private void Withdraw()
		{
			try
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmount,TACNum)values(@TN,@TD,@TA,@TAC)", sqlConnection);
				cmd.Parameters.AddWithValue("@TN", "Withdraw");
				cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
				cmd.Parameters.AddWithValue("@TA", withdrawAmountTB.Text);
				cmd.Parameters.AddWithValue("@TAC", accNumWitTB.Text);

				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				sqlConnection.Close();
			}
		}
		private void depositButton_Click(object sender, EventArgs e)
		{
			if (accNumDepTB.Text == "" || depositAmountTB.Text == "")
			{
				MessageBox.Show("Please fill in all the information");
			}
			else
			{
				Deposit();
				GetNewBalance(accNumDepTB.Text);
				int newBalance = balance + Convert.ToInt32(depositAmountTB.Text);
				try
				{
					sqlConnection.Open();
					SqlCommand cmd = new SqlCommand("Update AccountTbl set ACBal=@AB where ACNum=@ACKey", sqlConnection);
					cmd.Parameters.AddWithValue("@AB", newBalance);
					cmd.Parameters.AddWithValue("ACKey", accNumDepTB.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Deposit Successful");
					sqlConnection.Close();
					depositAmountTB.Text = "";
					accNumDepTB.Text = "";
					balanceLabel.Text = "Your Balance";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void withdrawButton_Click(object sender, EventArgs e)
		{
			if (accNumWitTB.Text == "" || withdrawAmountTB.Text == "")
			{
				MessageBox.Show("Please fill in all the information");
			}
			else
			{
				GetNewBalance(accNumWitTB.Text);
				if (balance < Convert.ToInt32(withdrawAmountTB.Text))
				{
					MessageBox.Show("Insufficient Balance");
					return;
				}
				else
				{
					Withdraw();
					int newBalance = balance - Convert.ToInt32(withdrawAmountTB.Text);
					try
					{
						sqlConnection.Open();
						SqlCommand cmd = new SqlCommand("Update AccountTbl set ACBal=@AB where ACNum=@ACKey", sqlConnection);
						cmd.Parameters.AddWithValue("@AB", newBalance);
						cmd.Parameters.AddWithValue("ACKey", accNumWitTB.Text);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Withdraw Successful");
						sqlConnection.Close();
						withdrawAmountTB.Text = "";
						accNumWitTB.Text = "";
						balanceLabel.Text = "Your Balance";
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}
		private void Transfer()
		{
			try
			{
				sqlConnection.Open();
				SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSrc,TrDest,TrAmt,TrDate)values(@TS,@TD,@TA,@TDa)", sqlConnection);
				cmd.Parameters.AddWithValue("@TS", fromTB.Text);
				cmd.Parameters.AddWithValue("@TD", toTB.Text);
				cmd.Parameters.AddWithValue("@TA", transferAmountTB.Text);
				cmd.Parameters.AddWithValue("@TDa", DateTime.Now.Date);

				cmd.ExecuteNonQuery();
				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				sqlConnection.Close();
			}
		}
		private bool CheckAccounts()
		{
			sqlConnection.Open();
			string query = "select count(*) from AccountTbl where ACNum = '" + fromTB.Text + "'";
			SqlDataAdapter sdaFrom = new SqlDataAdapter(query, sqlConnection);
			DataTable dtFrom = new DataTable();
			sdaFrom.Fill(dtFrom);
			if (dtFrom.Rows[0][0].ToString() == "0")
			{
				MessageBox.Show("Source account not found");
				fromTB.Text = "";
				sqlConnection.Close();
				return false;
			}
			sqlConnection.Close();
			sqlConnection.Open();
			query = "select count(*) from AccountTbl where ACNum = '" + toTB.Text + "'";
			SqlDataAdapter sdaTo = new SqlDataAdapter(query, sqlConnection);
			DataTable dtTo = new DataTable();
			sdaTo.Fill(dtTo);
			if (dtTo.Rows[0][0].ToString() == "0")
			{
				MessageBox.Show("Destination account not found");
				toTB.Text = "";
				sqlConnection.Close();
				return false;
			}
			sqlConnection.Close();
			return true;
		}
		private void transferButton_Click(object sender, EventArgs e)
		{
			GetNewBalance(fromTB.Text);
			if (fromTB.Text == "" || toTB.Text == "" || transferAmountTB.Text == "")
			{
				MessageBox.Show("Please fill in all the information");
			}
			else if (fromTB.Text == toTB.Text)
			{
				MessageBox.Show("Source and Destination account are same");
			}
			else if (Convert.ToInt16(transferAmountTB.Text) > balance)
			{
				MessageBox.Show("Insufficient Balance");
			}
			else if (!CheckAccounts())
			{
				return;
			}
			else
			{
				Transfer();
				SubstractBal();
				AddBal();
				MessageBox.Show("Transfer Successful");
				fromTB.Text = "";
				toTB.Text = "";
				transferAmountTB.Text = "";
			}
		}
	}
}
