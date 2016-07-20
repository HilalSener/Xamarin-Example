using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TabbedApplication.Droid
{
	[Activity(Label = "TabbedApplication.Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			AddTab("Tab 1", Resource.Drawable.home, new SampleTabFragment());
			AddTab("Tab 2", Resource.Drawable.settings, new SampleTabFragment2());

			if (savedInstanceState != null)
				this.ActionBar.SelectTab(this.ActionBar.GetTabAt(savedInstanceState.GetInt("tab")));

		}

		protected override void OnSaveInstanceState(Bundle outState)
		{
			outState.PutInt("tab", this.ActionBar.SelectedNavigationIndex);

			base.OnSaveInstanceState(outState);
		}

		void AddTab(string tabText, int iconResourceId, Fragment view)
		{
			var tab = this.ActionBar.NewTab();
			tab.SetText(tabText);
			tab.SetIcon(Resource.Drawable.settings);

			// must set event handler before adding tab
			tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e)
			{
				var fragment = this.FragmentManager.FindFragmentById(Resource.Id.fragmentContainer);
				if (fragment != null)
					e.FragmentTransaction.Remove(fragment);
				e.FragmentTransaction.Add(Resource.Id.fragmentContainer, view);
			};
			tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e)
			{
				e.FragmentTransaction.Remove(view);
			};

			this.ActionBar.AddTab(tab);
		}

		class SampleTabFragment : Fragment
		{
			public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
			{
				base.OnCreateView(inflater, container, savedInstanceState);

				var view = inflater.Inflate(Resource.Layout.Tab, container, false);
				var sampleTextView = view.FindViewById<TextView>(Resource.Id.sampleTextView);
				sampleTextView.Text = "sample fragment text";

				return view;
			}
		}

		class SampleTabFragment2 : Fragment
		{
			public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
			{
				base.OnCreateView(inflater, container, savedInstanceState);

				var view = inflater.Inflate(Resource.Layout.Tab, container, false);
				var sampleTextView = view.FindViewById<TextView>(Resource.Id.sampleTextView);
				sampleTextView.Text = "sample fragment text 2";

				return view;
			}
		}

	}
}



