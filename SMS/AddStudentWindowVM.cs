using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
	
	public partial class AddStudentWindowVM:ObservableObject
	{
		//[RelayCommand]
		//public void SelectImage()
		//{
		//	// Create OpenFileDialog 
		//	Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



		//	// Set filter for file extension and default file extension 
		//	dlg.DefaultExt = ".png";
		//	dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


		//	// Display OpenFileDialog by calling ShowDialog method 
		//	Nullable<bool> result = dlg.ShowDialog();


		//	// Get the selected file name and display in a TextBox 
		//	if (result == true)
		//	{
		//		// Open document 
		//		string filename = dlg.FileName;
		//		//textBox1.Text = filename;
		//	}
		//}

		public AddStudentWindowVM() 
		{ 
			
		}

	}
}
