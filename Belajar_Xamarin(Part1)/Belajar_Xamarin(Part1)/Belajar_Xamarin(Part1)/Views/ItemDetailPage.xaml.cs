using Belajar_Xamarin_Part1_.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Belajar_Xamarin_Part1_.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}