using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SMS
{
	
	public partial class MainWindowVM:ObservableObject
	{
		[ObservableProperty]
		public ObservableCollection<Student> students;

		[ObservableProperty]
		public Student selectedStudent;

		[ObservableProperty]
		public string counterText;
		
		[RelayCommand]
		public void RemovePerson()
		{
			if (Students.Count > 0) Students.RemoveAt(0);
		}
		[RelayCommand]
		public void AddPerson()
		{
			//Students.Add(new Student("Albert", "Newton", "2.png", "2002/01/12", 3.69));
			var window = new AddStudentWindow();
			window.Show();

		}

		public MainWindowVM()
		{
			students = new ObservableCollection<Student>();
			//students.Add(new Student { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });

			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));
			students.Add(new Student("Kamal", "Perera", "1.png", "2000/10/24", 3.99));

			CounterText = students.Count.ToString() + " College Students";


		}
	}
}
