using Xamarin.Forms;

namespace AppAnimalForms.Views
{
	public partial class PetsUsuarioPage : ContentPage
	{
		public PetsUsuarioPage()
		{
			InitializeComponent();

			PetWS petws = new PetWS();

			listView.ItemsSource = petws.GetPets();

		}
	}
}

