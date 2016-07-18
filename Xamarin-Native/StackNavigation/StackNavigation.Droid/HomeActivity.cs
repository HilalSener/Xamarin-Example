using Android.App;
using Android.OS;

namespace StackNavigation.Droid
{
    [Activity(Label = "Home", Icon = "@drawable/icon")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Home);
        }
    }
}