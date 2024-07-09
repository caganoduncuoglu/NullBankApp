using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace NullBankApp
{
	public class CurrencyService
	{
		private readonly HttpClient _httpClient;
		private readonly string _apiUrl = "https://api.collectapi.com/economy/allCurrency"; // CollectAPI URL'si
		private readonly string _apiKey = "2mhThZlKrwxhSqVUQT40eM:5Jrb8DjwisyZTRXrwCYSee";

		public CurrencyService()
		{
			_httpClient = new HttpClient();
			_httpClient.DefaultRequestHeaders.Add("authorization", "apikey " + _apiKey);
		}

		public async Task<JObject> GetCurrencyPricesAsync()
		{
			var response = await _httpClient.GetStringAsync(_apiUrl);
			return JObject.Parse(response);
		}
	}
}
