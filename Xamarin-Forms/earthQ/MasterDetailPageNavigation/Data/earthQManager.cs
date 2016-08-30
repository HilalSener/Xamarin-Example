using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;


namespace MasterDetailPageNavigation
{
	public class earthQManager
	{
		const string Url = "http://sondepremler20160728065405.azurewebsites.net/last";

		public async Task<ServiceResult> GetAll()
		{
			string result = await GetStringAsync(Url);
			return JsonConvert.DeserializeObject<ServiceResult>(result);
		}

		Task<string> GetStringAsync(string url)
		{
			
		}
}
}

