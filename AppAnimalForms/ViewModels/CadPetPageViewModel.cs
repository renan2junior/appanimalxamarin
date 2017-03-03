using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace AppAnimalForms.ViewModels
{
	public class CadPetPageViewModel : BindableBase, INavigationAware
	{
		public CadPetPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			ws = new PetWS();
			_salvarPetCommand = new DelegateCommand(SalvarPet);
			Pet = new Pet();
			Pet.Foto = "http://www.blogdocachorro.com.br/wp-content/uploads/cachorro-feliz.jpg";
		}

		private ICommand _salvarPetCommand;
		private INavigationService _navigationService;
		private Pet _pet;
		private PetWS ws;

		public Pet Pet
		{
			get { return _pet; }
			set
			{
				SetProperty(ref _pet, value);
			}
		}

		public ICommand SalvarPetCommand
		{
			get { return _salvarPetCommand; }
		}

		void SalvarPet()
		{
			ws.InsertPet(_pet);
			_navigationService.GoBackAsync();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
