using System;
using System.Collections.Generic;

namespace MasterDetailPageNavigation
{
	public class Earthquake
	{
		public DateTime Date { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public double Deepth { get; set; }
		public double MD { get; set; }
		public double ML { get; set; }
		public double MW { get; set; }
		public string Location { get; set; }
		public string Result { get; set; }
	}

	public class ServiceResult
	{
		public IList<Earthquake> earthquakes { get; set; }
	}

}

