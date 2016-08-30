using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;
using System.Net;

namespace MasterDetailPageNavigation
{
	public class earthQManager
	{
		public static async Task<ServiceResult> GetAll()
		{
			var req = HttpWebRequest.Create("http://sondepremler20160728065405.azurewebsites.net/last");
			req.ContentType = "application/json";
			req.Method = "GET";

			var response = 

			//	var client = new HttpClient(new NativeMessageHandler());
			//string result = await client.GetAsync(new Uri("http://sondepremler20160728065405.azurewebsites.net/last"));
			//return JsonConvert.DeserializeObject<ServiceResult>(result);

		 	//var client = new HttpClient(new NativeMessageHandler());
			//var result = await client.GetAsync("http://sondepremler20160728065405.azurewebsites.net/last");
			//var resultString = await result.Content.ReadAsStringAsync();
			//return resultString;

    	}
	}
}