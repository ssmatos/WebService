using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServices.Models;

namespace WebServices.Services
{
	public class ApiServices : IApiServices
	{
		public async Task<Genre> GetGenre(string id)
		{
			const string host = "https://api.deezer.com/genre/";
			const string key = "/?key=d9a03c42c8mshe32fb37d80f3666p1e8245jsndf33491f4f4f";
			HttpClient httpClient = new HttpClient();
			var result = await httpClient.GetStringAsync($"{host}{id}{key}");
			return JsonConvert.DeserializeObject<Genre>(result);
		}
	}
}
