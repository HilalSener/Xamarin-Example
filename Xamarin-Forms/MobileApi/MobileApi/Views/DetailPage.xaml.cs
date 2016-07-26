using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApi
{
	public partial class DetailPage : ContentPage
	{
		StudentProvider provider = new StudentProvider();
		List<Task> tasklist = new List<Task>();

		public DetailPage()
		{
			InitializeComponent();

			Task<List<Student>> studTask = Task<List<Student>>.Run(() => provider.Get().Result);
			tasklist.Add(studTask);
			Task.WaitAll(tasklist.ToArray());
			if (studTask.Status == TaskStatus.RanToCompletion) {
				var result = studTask.Result;
				lvStudents.ItemsSource = result;
			}

			//List<Student> studList = new List<Student>()
			//{
			//	new Student() {Name = "Hilal", Surname = "ŞENER", About= "Jr. Xamarin Developer", RegistrationDate=DateTime.Now},
			//	new Student() {Name = "Victor", Surname = "Tomaili", About= "Sr. Software Developer", RegistrationDate=DateTime.Now}
			//};

			//lvStudents.ItemsSource = studList;
		}
	}
}

