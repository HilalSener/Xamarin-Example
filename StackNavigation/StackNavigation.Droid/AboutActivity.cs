using Android.App;
using Android.OS;

namespace StackNavigation.Droid
{
    [Activity(Label = "About", Icon = "@drawable/icon")]
    public class AboutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.About);
        }
    }
}