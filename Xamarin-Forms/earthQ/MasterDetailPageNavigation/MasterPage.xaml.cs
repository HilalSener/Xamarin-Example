using System.Collections.Generic;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Home",
				IconSource = "contacts.png",
				TargetType = typeof(HomePage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Earthquake",
				IconSource = "todo.png",
				TargetType = typeof(earthQPage)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Setting",
				IconSource = "reminders.png",
				TargetType = typeof(SettingPage)
			});

			listView.ItemsSource = masterPageItems;
		}
	}
}
