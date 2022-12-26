using Belajar_Xamarin_Part1_.ViewModels;
using Belajar_Xamarin_Part1_.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Belajar_Xamarin_Part1_
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
