using Android.App;
using Android.OS;

namespace StackNavigation.Droid
{
    [Activity(Label = "Contact", Icon = "@drawable/icon")]
    public class ContactActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Contact);
        }
    }
}