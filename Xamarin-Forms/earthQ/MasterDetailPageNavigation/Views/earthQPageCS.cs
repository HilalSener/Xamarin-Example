using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class earthQPageCS : ContentPage
	{
		public earthQPageCS ()
		{
			Title = "Earthquake Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Earthquake data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
