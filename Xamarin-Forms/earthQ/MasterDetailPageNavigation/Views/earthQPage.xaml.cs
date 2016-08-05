using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class earthquake
	{
		public string place { get; set; }
		public DateTime time { get; set; }
		public double intensity { get; set; }
	}

	public partial class earthQPage : ContentPage
	{
		public earthQPage()
		{ 
			InitializeComponent();

			List<earthquake> earthQ = new List<earthquake>();
			earthQ.Add(new earthquake { place = "İstanbul", time = DateTime.Now, intensity = 2.1 });
			earthQ.Add(new earthquake { place = "Ankara", time = DateTime.Today, intensity = 3.2 });
			earthQ.Add(new earthquake { place = "İzmir", time = DateTime.Now, intensity = 1.2 });

			lstView.ItemsSource = earthQ;
		}

	}
}

