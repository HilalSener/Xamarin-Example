using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace StackNavigation.Droid
{
    [Activity(Label = "StackNavigation.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var menuListView = FindViewById<ListView>(Resource.Id.menuListView);

            menuListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, new[] { "Home", "About", "Contact" });

            menuListView.ItemClick += OnMenuClick;
        }

        private void OnMenuClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = null;

            switch (e.Position)
            {
                case 0: intent = new Intent(this, typeof(HomeActivity)); break;
                case 1: intent = new Intent(this, typeof(AboutActivity)); break;
                case 2: intent = new Intent(this, typeof(ContactActivity)); break;
            }

            StartActivity(intent);
        }
    }
}

