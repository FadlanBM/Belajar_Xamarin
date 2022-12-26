using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Belajar_Table
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Labels : ContentPage
	{
		public ICommand TapCommand => new Command<string>(OpenBrowser);
		public Labels()
		{
			InitializeComponent();
			BindingContext=this;
		}

		void OpenBrowser(string url) {
			Launcher.OpenAsync(url);
		}
	}
}