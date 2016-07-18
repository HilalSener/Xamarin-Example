using System;

using Xamarin.Forms;

namespace TabNavigation.iOS
{
	public class TabController : ContentPage
	{
		public TabController()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


