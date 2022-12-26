using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Belajar_Table
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage();
			MainPage = new Labels();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
