using Belajar_Xamarin_Part1_.Services;
using Belajar_Xamarin_Part1_.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Belajar_Xamarin_Part1_
{
	public partial class App : Application
	{

		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
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
