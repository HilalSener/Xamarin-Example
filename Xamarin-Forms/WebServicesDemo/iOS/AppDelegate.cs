﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace WebServicesDemo.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(uiApplication, launchOptions);
		}
	}
}

