using System;
using System.Collections.Generic;

namespace MobileApi
{
	public class Department
	{
		public string FirstCharacter
		{
			get
			{
				return DepartmanName.Substring(0, 1);
			}
		}
		public int DepartmentID { get; set; }
		public string DepartmanName { get; set; }
		public List<Student> Student { get; set; }
	}
}

