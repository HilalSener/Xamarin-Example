using Android.App;
using Android.Widget;
using Android.OS;

namespace ListViewDemo
{
	[Activity(Label = "Instructors", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			var instructorListView = FindViewById<ListView>(Resource.Id.instructorListView);

			instructorListView.ItemClick += OnItemClick;

			var adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,
			                              InstructorData.Instructors);
			instructorListView.Adapter = adapter;
		}

		void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			var instructor = InstructorData.Instructors[e.Position];

			var dialog = new AlertDialog.Builder(this);
			dialog.SetMessage(instructor.Name);
			dialog.SetNeutralButton("Ok", delegate 
			{
			});
			dialog.Show();
		}
	}
}


