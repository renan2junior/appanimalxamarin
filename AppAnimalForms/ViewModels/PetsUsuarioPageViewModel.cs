using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using System.Diagnostics;
using Prism.Navigation;

namespace AppAnimalForms.ViewModels
{
	public class PetsUsuarioPageViewModel : BindableBase, INavigationAware
	{

		private bool Buzy;
		private Pet item;
		readonly INavigationService _navigationService;

		public Pet Item
		{
			get { return item; }
			set {
				if (item != value)
				{
					item = value;
					DoPageDados();
				}
			}
		}

		public bool IsBusy
		{
			get
			{
				return Buzy;
			}
			set
			{
				SetProperty(ref Buzy, value);
			}
		}
		public ObservableCollection<Pet> Pets { get; set; }

		public PetsUsuarioPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			Pets = new ObservableCollection<Pet>();
			GetPets();

		}

		async void DoPageDados()
		{
			if (Item != null)
			{
				Debug.WriteLine(Item.Foto);
				var param = new NavigationParameters();
				param.Add("Item", Item);
				await _navigationService.NavigateAsync("DadosPetPage", param, true, false);
				return;
			}
		}

		async Task GetPets()
		{
			if (!IsBusy)
			{
				Exception Error = null;
				try
				{
					IsBusy = true;
					var petWS = new PetWS();
					var Items = await petWS.GetPets();
					Pets.Clear();
					foreach (var pet in Items)
					{
						Pets.Add(pet);
					}
				}
				catch (Exception ex)
				{
					Error = ex;
				}
				finally
				{
					IsBusy = false;
					if (Error != null)
					{
						await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(
						"Error!", Error.Message, "OK");
					}
				}
			}

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}

}
