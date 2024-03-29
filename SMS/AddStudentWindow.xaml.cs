﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SMS
{
	/// <summary>
	/// Interaction logic for AddStudentWindow.xaml
	/// </summary>
	public partial class AddStudentWindow : Window
	{
		public AddStudentWindow()
		{
			DataContext = new AddStudentWindowVM();
			InitializeComponent();
		}


		private void buttonSelectImage_Click(object sender, RoutedEventArgs e)
		{
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
			}
		}

		private void buttonCreate_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void Border_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}

		public void ButtonCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		public void ButtonSave_Click(object sender, RoutedEventArgs e)
		{

			this.Close();
		}


		private void MyTextBox_Loaded()
		{

		}

	}

}
