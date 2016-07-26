using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MobileApi
{
	public class StudentProvider
	{
		public string url { get; set; } = "http:/localhost:50882/api/Student";

		public async Task<List<Student>> Get()
		{
			using (HttpClient client = new HttpClient())
			{
				client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
				string content = null;
				HttpResponseMessage response = await client.GetAsync(new Uri(url + "GetAll"));
				response.EnsureSuccessStatusCode();

				String responseBody = await response.Content.ReadAsStringAsync();

				content = responseBody;

				MobileResult mobileResultType = JsonConvert.DeserializeObject<MobileResult>(content);
				var result = JsonConvert.DeserializeObject<List<Student>>(mobileResultType.Data.ToString());
				return result;
			}
		}
	}
}

