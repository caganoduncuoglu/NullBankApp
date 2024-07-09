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

namespace NullBankApp
{
	public partial class Investments : Form
	{
		private readonly GoldPriceService _goldPriceService;
		private readonly CurrencyService _currencyService;
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

			pieChart1.Series = new ISeries[]
{
	new PieSeries<double> { Values = new double[] { 2 } },
	new PieSeries<double> { Values = new double[] { 4 } },
	new PieSeries<double> { Values = new double[] { 1 } },
	new PieSeries<double> { Values = new double[] { 4 } },
	new PieSeries<double> { Values = new double[] { 3 } }
};
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
				else if (buyCB.SelectedIndex == 1) // Euro
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
				else if (sellCB.SelectedIndex == 1) // Euro
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
				else if (buyCB.SelectedIndex == 1) // Euro
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
				else if (sellCB.SelectedIndex == 1) // Euro
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

		
	}
}
