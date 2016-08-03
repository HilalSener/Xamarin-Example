using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class SettingPageCS : ContentPage
	{
		public SettingPageCS ()
		{
			Title = "Setting Page";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Setting data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
