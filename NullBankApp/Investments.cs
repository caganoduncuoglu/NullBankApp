using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System.Data.SqlClient;

namespace NullBankApp
{
	public partial class Investments : Form
	{
		private readonly GoldPriceService _goldPriceService;
		private readonly CurrencyService _currencyService;

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cagan\Documents\NullBankDB.mdf;Integrated Security=True;Connect Timeout=30");

		public Investments()
		{
			InitializeComponent();
			_goldPriceService = new GoldPriceService();
			_currencyService = new CurrencyService();
			LoadGoldPrices();
			LoadCurrencyRates();
			dateLbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
			buyPriceTB.TextChanged += BuyPriceTB_TextChanged;
			buyUnitTB.TextChanged += BuyUnitTB_TextChanged;
			sellPriceTB.TextChanged += SellPriceTB_TextChanged;
			sellUnitTB.TextChanged += SellUnitTB_TextChanged;
			buyCB.SelectedIndex = 0;
			sellCB.SelectedIndex = 0;
		}

		private void BuyUnitTB_TextChanged(object? sender, EventArgs e)
		{
			if (decimal.TryParse(buyUnitTB.Text, out decimal unit))
			{
				decimal price = 0;
				if (buyCB.SelectedIndex == 0) // Gold
				{
					price = unit * Decimal.Parse(buyGoldPrice.Text);
				}
				else if (buyCB.SelectedIndex == 1) // USD
				{
					price = unit * Decimal.Parse(usdBuy.Text);
				}
				else if (buyCB.SelectedIndex == 2) // Euro
				{
					price = unit * Decimal.Parse(euroBuy.Text);
				}
				buyPriceTB.TextChanged -= BuyPriceTB_TextChanged;
				buyPriceTB.Text = price.ToString();
				buyPriceTB.TextChanged += BuyPriceTB_TextChanged;
			}
		}

		private void SellUnitTB_TextChanged(object? sender, EventArgs e)
		{
			if (decimal.TryParse(sellUnitTB.Text, out decimal unit))
			{
				decimal price = 0;
				if (sellCB.SelectedIndex == 0) // Gold
				{
					price = unit * Decimal.Parse(sellGoldPrice.Text);
				}
				else if (sellCB.SelectedIndex == 1) // USD
				{
					price = unit * Decimal.Parse(usdSell.Text);
				}
				else if (sellCB.SelectedIndex == 2) // Euro
				{
					price = unit * Decimal.Parse(euroSell.Text);
				}
				sellPriceTB.TextChanged -= SellPriceTB_TextChanged;
				sellPriceTB.Text = price.ToString();
				sellPriceTB.TextChanged += SellPriceTB_TextChanged;
			}
		}

		private void BuyPriceTB_TextChanged(object? sender, EventArgs e)
		{
			if (decimal.TryParse(buyPriceTB.Text, out decimal price))
			{
				decimal unit = 0;
				if (buyCB.SelectedIndex == 0) // Gold
				{
					unit = price / Decimal.Parse(buyGoldPrice.Text);
				}
				else if (buyCB.SelectedIndex == 1) // USD
				{
					unit = price / Decimal.Parse(usdBuy.Text);
				}
				else if (buyCB.SelectedIndex == 2) // Euro
				{
					unit = price / Decimal.Parse(euroBuy.Text);
				}
				buyUnitTB.TextChanged -= BuyUnitTB_TextChanged;
				buyUnitTB.Text = unit.ToString();
				buyUnitTB.TextChanged += BuyUnitTB_TextChanged;
			}
		}

		private void SellPriceTB_TextChanged(object? sender, EventArgs e)
		{
			if (decimal.TryParse(sellPriceTB.Text, out decimal price))
			{
				decimal unit = 0;
				if (sellCB.SelectedIndex == 0) // Gold
				{
					unit = price / Decimal.Parse(sellGoldPrice.Text);
				}
				else if (sellCB.SelectedIndex == 1) // USD
				{
					unit = price / Decimal.Parse(usdSell.Text);
				}
				else if (sellCB.SelectedIndex == 2) // Euro
				{
					unit = price / Decimal.Parse(euroSell.Text);
				}
				sellUnitTB.TextChanged -= SellUnitTB_TextChanged;
				sellUnitTB.Text = unit.ToString();
				sellUnitTB.TextChanged += SellUnitTB_TextChanged;
			}
		}

		private async Task LoadGoldPrices()
		{
			var goldPrices = await _goldPriceService.GetGoldPricesAsync();
			var gramGold = goldPrices["result"]
						.FirstOrDefault(price => price["name"].ToString() == "Gram Altın");

			if (gramGold != null)
			{
				buyGoldPrice.Text = gramGold["buying"].ToString();
				sellGoldPrice.Text = gramGold["selling"].ToString();
			}
		}

		private async Task LoadCurrencyRates()
		{
			var currencyRates = await _currencyService.GetCurrencyPricesAsync();
			var usd = currencyRates["result"]
						.FirstOrDefault(price => price["code"].ToString() == "USD");
			var eur = currencyRates["result"]
						.FirstOrDefault(price => price["code"].ToString() == "EUR");

			if (usd != null)
			{
				usdBuy.Text = usd["buying"].ToString();
				usdSell.Text = usd["selling"].ToString();
			}
			if (eur != null)
			{
				euroBuy.Text = eur["buying"].ToString();
				euroSell.Text = eur["selling"].ToString();
			}
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			try
			{
				sqlConnection.Open();
				string query = @"SELECT a.ACBal, a.ACName, i.IGold, i.IUSD, i.IEUR 
                     FROM AccountTbl a 
                     JOIN InvestmentAccountsTbl i ON a.ACNum = i.ACNum 
                     WHERE a.ACNum = '" + enterIDTB.Text + "'";
				SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				// Prepare the pie chart series
				double acBal = 0, goldBalance = 0, usdBalance = 0, eurBalance = 0;

				foreach (DataRow dataRow in dataTable.Rows)
				{
					acBal = Convert.ToDouble(dataRow["ACBal"]);
					nameLbl.Text = dataRow["ACName"].ToString();
					goldBalance = Convert.ToDouble(dataRow["IGold"]);
					usdBalance = Convert.ToDouble(dataRow["IUSD"]);
					eurBalance = Convert.ToDouble(dataRow["IEUR"]);
				}

				// Add the values to the pie chart
				pieChart1.Series = new ISeries[]
				{
					new PieSeries<double> { Values = new double[] { acBal }, Name = "Account Balance (₺)" },
					new PieSeries<double> { Values = new double[] { goldBalance }, Name = "Gold Balance" },
					new PieSeries<double> { Values = new double[] { usdBalance }, Name = "USD Balance" },
					new PieSeries<double> { Values = new double[] { eurBalance }, Name = "EUR Balance" }
				};

				// Calculate the total balance
				double totalBalance = acBal + goldBalance + usdBalance + eurBalance;
				totalPrice.Text = Math.Round(totalBalance,2).ToString() + " ₺";

				sqlConnection.Close();

				buyID.Text = enterIDTB.Text;
				sellID.Text = enterIDTB.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void transactionsButton_Click(object sender, EventArgs e)
		{
			Transactions transactions = new Transactions();
			transactions.Show();
			this.Hide();
		}

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

		private void buyButton_Click(object sender, EventArgs e)
		{
			int accountId = Convert.ToInt32(enterIDTB.Text);

			double purchase = string.IsNullOrEmpty(buyPriceTB.Text) ? 0 : Convert.ToDouble(buyPriceTB.Text);

			bool isBuy = true;

			UpdateBalances(accountId, purchase, isBuy);
		}

		private void UpdateBalances(int accountId, double purchase, bool isBuy)
		{
			try
			{
				sqlConnection.Open();

				string accountQuery = "SELECT ACBal FROM AccountTbl WHERE ACNum = @ACNum";
				SqlCommand accountCommand = new SqlCommand(accountQuery, sqlConnection);
				accountCommand.Parameters.AddWithValue("@ACNum", accountId);

				object accountResult = accountCommand.ExecuteScalar();
				double currentAccountBalance = accountResult != null ? Convert.ToDouble(accountResult) : 0;

				if (isBuy)
				{

					double totalPurchaseAmount = purchase;

					if (currentAccountBalance >= totalPurchaseAmount)
					{
						string updateAccountQuery = "UPDATE AccountTbl SET ACBal = ACBal - @TotalPurchaseAmount WHERE ACNum = @ACNum";
						SqlCommand updateAccountCommand = new SqlCommand(updateAccountQuery, sqlConnection);
						updateAccountCommand.Parameters.AddWithValue("@TotalPurchaseAmount", totalPurchaseAmount);
						updateAccountCommand.Parameters.AddWithValue("@ACNum", accountId);
						updateAccountCommand.ExecuteNonQuery();

						if (buyCB.SelectedIndex == 0) // Gold
						{
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IGold = IGold + @Purchase WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Purchase", purchase);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}
						else if (buyCB.SelectedIndex == 1) // USD
						{
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IUSD = IUSD + @Purchase WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Purchase", purchase);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}
						else if (buyCB.SelectedIndex == 2) // Euro
						{
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IEUR = IEUR + @Purchase WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Purchase", purchase);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}


						MessageBox.Show("Balances Updated Successfully");
					}
					else
					{
						MessageBox.Show("Insufficient balance to make the purchase.");
					}
				}
				else
				{
					// Selling logic
					double totalSaleAmount = purchase;
					bool hasSufficientCurrency = false;

					// Check if there's enough currency to sell
					if (buyCB.SelectedIndex == 0) // Gold
					{
						string checkGoldQuery = "SELECT IGold FROM InvestmentAccountsTbl WHERE ACNum = @ACNum";
						SqlCommand checkGoldCommand = new SqlCommand(checkGoldQuery, sqlConnection);
						checkGoldCommand.Parameters.AddWithValue("@ACNum", accountId);
						double currentGoldBalance = Convert.ToDouble(checkGoldCommand.ExecuteScalar());

						if (currentGoldBalance >= totalSaleAmount)
						{
							hasSufficientCurrency = true;
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IGold = IGold - @Sale WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Sale", totalSaleAmount);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}
					}
					else if (buyCB.SelectedIndex == 1) // USD
					{
						string checkUSDQuery = "SELECT IUSD FROM InvestmentAccountsTbl WHERE ACNum = @ACNum";
						SqlCommand checkUSDCommand = new SqlCommand(checkUSDQuery, sqlConnection);
						checkUSDCommand.Parameters.AddWithValue("@ACNum", accountId);
						double currentUSDBalance = Convert.ToDouble(checkUSDCommand.ExecuteScalar());

						if (currentUSDBalance >= totalSaleAmount)
						{
							hasSufficientCurrency = true;
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IUSD = IUSD - @Sale WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Sale", totalSaleAmount);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}
					}
					else if (buyCB.SelectedIndex == 2) // Euro
					{
						string checkEURQuery = "SELECT IEUR FROM InvestmentAccountsTbl WHERE ACNum = @ACNum";
						SqlCommand checkEURCommand = new SqlCommand(checkEURQuery, sqlConnection);
						checkEURCommand.Parameters.AddWithValue("@ACNum", accountId);
						double currentEURBalance = Convert.ToDouble(checkEURCommand.ExecuteScalar());

						if (currentEURBalance >= totalSaleAmount)
						{
							hasSufficientCurrency = true;
							string updateInvestmentQuery = "UPDATE InvestmentAccountsTbl SET IEUR = IEUR - @Sale WHERE ACNum = @ACNum";
							SqlCommand updateInvestmentCommand = new SqlCommand(updateInvestmentQuery, sqlConnection);
							updateInvestmentCommand.Parameters.AddWithValue("@Sale", totalSaleAmount);
							updateInvestmentCommand.Parameters.AddWithValue("@ACNum", accountId);
							updateInvestmentCommand.ExecuteNonQuery();
						}
					}

					// Update account balance if there was sufficient currency to sell
					if (hasSufficientCurrency)
					{
						string updateAccountQuery = "UPDATE AccountTbl SET ACBal = ACBal + @TotalSaleAmount WHERE ACNum = @ACNum";
						SqlCommand updateAccountCommand = new SqlCommand(updateAccountQuery, sqlConnection);
						updateAccountCommand.Parameters.AddWithValue("@TotalSaleAmount", totalSaleAmount);
						updateAccountCommand.Parameters.AddWithValue("@ACNum", accountId);
						updateAccountCommand.ExecuteNonQuery();

						MessageBox.Show("Balances Updated Successfully");
					}
					else
					{
						MessageBox.Show("Insufficient currency to make the sale.");
					}
				}

				sqlConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void sellButton_Click(object sender, EventArgs e)
		{
			int accountId = Convert.ToInt32(enterIDTB.Text);

			double sell = string.IsNullOrEmpty(sellPriceTB.Text) ? 0 : Convert.ToDouble(sellPriceTB.Text);

			bool isBuy = false;

			UpdateBalances(accountId, sell, isBuy);
		}
	}
}
