using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
	public partial class NavigationPage2 : ContentPage
	{
		public NavigationPage2()
		{
			InitializeComponent();

			Label lbl = new Label();
			lbl.Text = "Welcome to SeconPage";
			lbl.FontSize = 20;
			lbl.HorizontalOptions = LayoutOptions.CenterAndExpand;
			lbl.VerticalOptions = LayoutOptions.CenterAndExpand;

			Content = lbl;
		}
	}
}

