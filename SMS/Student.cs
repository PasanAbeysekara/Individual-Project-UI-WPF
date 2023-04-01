using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SMS
{
	public class Student
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public char Gender { get; set; }
		public string Image { get; set; }
		public string ImageURL
		{
			get
			{
				return $"/Images/{Image}";
			}
		}

		public string DateOfBirth { get; set; }
		public string Email { get; set; }
		public double GPA { get; set; }
		
		public Student(string firstName, string lastName, char gender, string image, string dateOfBirth, double gPA, string email)
		{
			Random r = new Random();
			Id = r.Next(0, 10000); ;
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			Image = image;
			DateOfBirth = dateOfBirth;
			GPA = gPA;
			Email = email;
		}
	}
}
