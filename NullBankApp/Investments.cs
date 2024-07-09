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
