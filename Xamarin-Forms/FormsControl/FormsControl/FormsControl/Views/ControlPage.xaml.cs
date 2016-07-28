using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsControl
{
	public partial class ControlPage : ContentPage
	{
		public ControlPage()
		{
			InitializeComponent();

			myDatePicker.MinimumDate = DateTime.Now.AddYears(-1);
			myDatePicker.MaximumDate = DateTime.Now.AddYears(1);
			myDatePicker.Date = DateTime.Now;
			myDatePicker.Format = "yyyy-MM-dd";
		}


		private void onClicked(object sender, EventArgs e)
		{
			activity.IsRunning =! activity.IsRunning;
		}
	}
}

