using System;
using Xamarin.Forms;

namespace Navigation
{
	public partial class NavigationPage1 : ContentPage
	{
		public NavigationPage1()
		{
			InitializeComponent();
			Title = "Main Page";
			//Children.Add(new NavigationPage2());

			Button btn = new Button()
			{
				Text = "Next Page",
				TextColor = Color.Black,
				FontSize = 20,
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			btn.Clicked += btn_OnClicked;

			Content = btn;
		}

		private async void btn_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NavigationPage2());
		}
	}
}

