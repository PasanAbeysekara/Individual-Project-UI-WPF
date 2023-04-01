using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SMS
{
	interface ICloseWindows
	{
		Action Close { get; set; }
	}
	public partial class AddStudentWindowVM:MainWindowVM, ICloseWindows
	{

		//string firstName, string lastName, char gender, string image, string dateOfBirth, double gPA, string email
		[ObservableProperty]
		public string? firstName;

		[ObservableProperty]
		public string? lastName;

		[ObservableProperty]
		public char gender;

		[ObservableProperty]
		public string? image;

		[ObservableProperty]
		public string? dateOfBirth;

		[ObservableProperty]
		public double gPA;

		[ObservableProperty]
		public string? email;

		public Action CloseAction { get; internal set; }

		public Student stud { get; set; }
		public bool? DialogResult { get; private set; }


		//[RelayCommand]
		//public void Create()
		//{
		//	//if(!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) && GPA <= 4 && GPA >= 0 && DateOfBirth != null && DateOfBirth != null && Image != null && Email != null)
		//	//{

		//	//	student = new Student(FirstName, LastName, Gender, Image, DateOfBirth, GPA, Email);
		//	//	DialogResult = true;
		//	//}
		//	student = new Student(firstName, lastName, gender, image, dateOfBirth, gPA, email);
		//	DialogResult = true;
		//}


		[RelayCommand]
		public void SelectImage()
		{
			//var window = new AddStudentWindow();
			//window.Show();
			// Create OpenFileDialog 
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".png";
			dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

			
			// Display OpenFileDialog by calling ShowDialog method 
			Nullable<bool> result = dlg.ShowDialog();


			// Get the selected file name and display in a TextBox 
			if (result == true)
			{
				// Open document 
				string filename = dlg.FileName;
				//textBox1.Text = filename;
				image = filename;
			}
		}

		private DelegateCommand _closeCommand;
		public DelegateCommand CloseCommand =>
			_closeCommand ?? (_closeCommand = new DelegateCommand(CloseWindow));

		void CloseWindow()
		{
			Close?.Invoke();
		}

		public Action Close { get; set; }
		

		private DelegateCommand _createCommand;
		public DelegateCommand CreateCommand =>
			_createCommand ?? (_createCommand = new DelegateCommand(CreateStudent));

		void CreateStudent()
		{
			stud = new Student(firstName, lastName, gender, image, dateOfBirth, gPA, email);
			students.Add(stud);
			DialogResult = true;

			Close?.Invoke();
		}

		private DelegateCommand _maleClickedCommand;
		public DelegateCommand MaleClickedommand =>
			_maleClickedCommand ?? (_maleClickedCommand = new DelegateCommand(MaleClicked));

		void MaleClicked()
		{
			gender = 'M';
		}

		private DelegateCommand _femaleClickedCommand;
		public DelegateCommand FemaleClickedommand =>
			_femaleClickedCommand ?? (_femaleClickedCommand = new DelegateCommand(FemaleClicked));

		void FemaleClicked()
		{
			gender = 'F';
		}


		public AddStudentWindowVM() 
		{
			CounterText = "69";

			Students.Add(new Student("BIMBI", "Perera", 'M', "4.png", "24/10/2000", 3.70, "bimbi@gmail.com"));
			Students.Add(new Student("HORA", "Cooray", 'F', "5.png", "12/01/2001", 3.51, "hora@gmail.com"));
		}

	}
}
