using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Image { get; set; }
		public string ImageURL
		{
			get
			{
				return $"/Images/{Image}";
			}
		}

		public string DateOfBirth { get; set; }
		public double GPA { get; set; }
		public Student( string firstName, string lastName, string image, string dateOfBirth, double gPA)
		{
			FirstName = firstName;
			LastName = lastName;
			Image = image;
			DateOfBirth = dateOfBirth;
			GPA = gPA;
		}
	}
}
