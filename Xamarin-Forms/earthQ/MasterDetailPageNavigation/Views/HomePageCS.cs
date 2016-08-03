using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class HomePageCS : ContentPage
	{
		public HomePageCS ()
		{
			Title = "Contacts Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Contacts data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
