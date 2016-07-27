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
		public DetailPage()
		{
			InitializeComponent();


			List<Student> studList = new List<Student>()
			{
				new Student() {Name = "Hilal", Surname = "ŞENER", About= "Jr. Xamarin Developer", RegistrationDate=DateTime.Now},
				new Student() {Name = "Victor", Surname = "Tomaili", About= "Sr. Software Developer", RegistrationDate=DateTime.Now}
			};

			lvStudents.ItemsSource = studList;
		}
	}
}

