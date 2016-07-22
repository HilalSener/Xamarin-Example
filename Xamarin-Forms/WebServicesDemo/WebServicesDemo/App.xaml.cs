using System;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Xamarin.Forms;

namespace WebServicesDemo
{
	public partial class App : Application
	{
		public App()
		{
			//MainPage = new NoNetworkPage();
			MainPage = CrossConnectivity.Current.IsConnected
				? (Page)new NetworkViewPage()
				: new NoNetworkPage();
		}

		protected override void OnStart()
		{
			CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
		}

		void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
			Type currentPage = this.MainPage.GetType();
			if (e.IsConnected && currentPage != typeof(NetworkViewPage))
				this.MainPage = new NetworkViewPage();
			else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
				this.MainPage = new NoNetworkPage();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

