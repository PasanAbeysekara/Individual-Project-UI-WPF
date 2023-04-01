﻿using Prism.Commands;
using SMS.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SMS
{

	class EditStudentWindowVM : INotifyPropertyChanged, ICloseWindows
	{
		// #begin INotifyPropertyChanged Interface 
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		// #end

		private string _firstName;

		public string FirstName { get { return _firstName; } set { _firstName = value; } }


		private string _lastName;

		public string LastName { get { return _lastName; } set { _lastName = value; } }

		private string _imagei;

		public string Imagei { get { return _imagei; } set { _imagei = value; } }


		private string _gender;

		public string Gender { get { return _gender; } set { _gender = value; } }

		public List<string> _genders;
		public List<string> Genders { get { return _genders; } set { _genders = value; OnPropertyChanged(nameof(Genders)); } }

		private DateTime _dateOfBirth;

		public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

		private string _email;

		public string Email { get { return _email; } set { _email = value; } }


		private string _gPA;

		public string GPA { get { return _gPA; } set { _gPA = value; } }

		private Student _selectedStudent;

		public Student SelectedStudent { get { return _selectedStudent; } set { _selectedStudent = value; OnPropertyChanged(nameof(SelectedStudent)); } }

		private string _browseImageText;

		public string BrowseImageText { get { return _browseImageText; } set { _browseImageText = value; OnPropertyChanged(nameof(BrowseImageText)); } }



		// for ICloseWindows
		public Action CloseAction { get; internal set; }
		public Action Close { get; set; }

		// Close Button Command
		private DelegateCommand<Student> _closeCommand;
		public DelegateCommand<Student> CloseCommand =>
			_closeCommand ?? (_closeCommand = new DelegateCommand<Student>(ExecuteCloseCommand));

		void ExecuteCloseCommand(Student parameter)
		{
			Close?.Invoke();
		}

		// Create Button Command
		private DelegateCommand<Student> _createCommand;
		public DelegateCommand<Student> CreateCommand =>
			_createCommand ?? (_createCommand = new DelegateCommand<Student>(ExecuteCreateCommand));


		void ExecuteCreateCommand(Student parameter)
		{
			using (DataContext context = new DataContext())
			{
				SelectedStudent.FirstName = _firstName;
				SelectedStudent.LastName = _lastName;
				SelectedStudent.Email = _email;
				SelectedStudent.DateOfBirth = _dateOfBirth.ToShortDateString();
				SelectedStudent.Image = _imagei;
				SelectedStudent.Gender = _gender[0];
				SelectedStudent.GPA = Convert.ToDouble(_gPA);

				context.Students.Remove(context.Students.Single(x => x.Id == SelectedStudent.Id));
				context.Students.Add(SelectedStudent);
				context.SaveChanges();
			}
			MessageBox.Show("Refresh the student records to see the changes 😊");
			Close?.Invoke();
		}

		// Image Browse Button Command
		private DelegateCommand _imageBrowseCommand;
		public DelegateCommand ImageBrowseCommand =>
			_imageBrowseCommand ?? (_imageBrowseCommand = new DelegateCommand(ExecuteImageBrowseCommand));


		void ExecuteImageBrowseCommand()
		{
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
				_imagei = filename;
				_browseImageText = Path.GetFileName(_imagei);
			}
			MessageBox.Show(Path.GetFileName(_imagei) + " has been selected 😊");

		}


		public EditStudentWindowVM()
		{

			Genders = new List<string> { "Male", "Female" };
			_browseImageText = "Browse Image";
			string dateString = "2000-01-01";
			DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			_dateOfBirth = date;
		}

	}
}
