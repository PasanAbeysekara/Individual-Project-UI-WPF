using System;
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
    /// Interaction logic for AddStudWinow.xaml
    /// </summary>
    public partial class AddStudWinow : Window
    {
        public AddStudWinow()
        {
			DataContext = new AddStudWindowVM();
			InitializeComponent();
			Loaded += AddStudWindow_Loaded;
		}

		private void AddStudWindow_Loaded(object sender, RoutedEventArgs e)
		{
			if (DataContext is ICloseWindows vm)
			{
				vm.Close += () =>
				{
					this.Close();
				};
			}
		}


	}
}
