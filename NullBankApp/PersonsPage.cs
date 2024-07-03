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
	public partial class PersonsPage : Form
	{
		public PersonsPage()
		{
			InitializeComponent();
			DisplayPersons();
		}

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cagan\Documents\NullBankDB.mdf;Integrated Security=True;Connect Timeout=30");

		private void DisplayPersons()
		{
			try
			{
				sqlConnection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("select * from PersonTbl", sqlConnection);
				SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
				var ds = new DataSet();
				adapter.Fill(ds);
				PersonsDGV.DataSource = ds.Tables[0];
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
			acPasswordTB.Text = "";
			acPhoneTB.Text = "";
			acAddressTB.Text = "";
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			if (acNameTB.Text == "" || acPassword.Text == "" || acPhoneTB.Text == "" || acAddressTB.Text == "")
			{
				MessageBox.Show("Please fill in all the information");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					SqlCommand cmd = new SqlCommand("insert into PersonTbl(AName,APassword,APhone,AAddress)values(@AN,@APA,@APh,@AA)", sqlConnection);
					cmd.Parameters.AddWithValue("@AN", acNameTB.Text);
					cmd.Parameters.AddWithValue("@APA", acPasswordTB.Text);
					cmd.Parameters.AddWithValue("@APh", acPhoneTB.Text);
					cmd.Parameters.AddWithValue("@AA", acAddressTB.Text);
					cmd.Parameters.AddWithValue("@AB", 0);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Person Created Successfully");
					sqlConnection.Close();
					Reset();
					DisplayPersons();
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
				MessageBox.Show("Please select an person!");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					SqlCommand cmd = new SqlCommand("delete from PersonTbl where AId=@AKey", sqlConnection);
					cmd.Parameters.AddWithValue("@AKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Person Deleted Successfully");
					sqlConnection.Close();
					Reset();
					DisplayPersons();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		int Key = 0;

		private void PersonsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			acNameTB.Text = PersonsDGV.SelectedRows[0].Cells[1].Value.ToString();
			acPasswordTB.Text = PersonsDGV.SelectedRows[0].Cells[2].Value.ToString();
			acPhoneTB.Text = PersonsDGV.SelectedRows[0].Cells[3].Value.ToString();
			acAddressTB.Text = PersonsDGV.SelectedRows[0].Cells[4].Value.ToString();
			if (acNameTB.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(PersonsDGV.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			if (acNameTB.Text == "" || acPhoneTB.Text == "" || acAddressTB.Text == "")
			{
				MessageBox.Show("Please select a person!");
			}
			else
			{
				try
				{
					sqlConnection.Open();
					SqlCommand cmd = new SqlCommand("Update PersonTbl set AName=@AN,APassword=@APA,APhone=@APh,AAddress=@AA where AId=@ACKey", sqlConnection);
					cmd.Parameters.AddWithValue("@AN", acNameTB.Text);
					cmd.Parameters.AddWithValue("@APA", acPasswordTB.Text);
					cmd.Parameters.AddWithValue("@APh", acPhoneTB.Text);
					cmd.Parameters.AddWithValue("@AA", acAddressTB.Text);
					cmd.Parameters.AddWithValue("@ACKey", Key);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Person Updated Successfully");
					sqlConnection.Close();
					Reset();
					DisplayPersons();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void closeButton_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void backButton_Click_1(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}
	}
}
