using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Prism.Services;
using System.Threading.Tasks;
using Prism.Common;

namespace AppAnimalForms.ViewModels
{
	public class CadPetPageViewModel : BindableBase, INavigationAware, IPageDialogService
	{
		public CadPetPageViewModel(INavigationService navigationService, IApplicationProvider applicationProvider)
		{
			_navigationService = navigationService;
			_applicationProvider = applicationProvider;
			ws = new PetWS();
			_salvarPetCommand = new DelegateCommand(SalvarPet);
			Pet = new Pet();
			Pet.Foto = "http://www.blogdocachorro.com.br/wp-content/uploads/cachorro-feliz.jpg";
		}

		private ICommand _salvarPetCommand;
		private INavigationService _navigationService;
		private IApplicationProvider _applicationProvider;
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
			if (Pet.Descricao != null && Pet.Nome != null)
			{
				ws.InsertPet(_pet);
				Pet = new Pet();
				Pet.Foto = "http://www.blogdocachorro.com.br/wp-content/uploads/cachorro-feliz.jpg";
				_applicationProvider.MainPage.DisplayAlert("Suceeso!", "Seu pet foi registrado.", "OK");
			}
			else { 
				_applicationProvider.MainPage.DisplayAlert("Erro!", "Dados incompletos.", "OK");
			}

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}

		public Task<bool> DisplayAlertAsync(string title, string message, string acceptButton, string cancelButton)
		{
			throw new NotImplementedException();
		}

		public Task DisplayAlertAsync(string title, string message, string cancelButton)
		{
			throw new NotImplementedException();
		}

		public Task<string> DisplayActionSheetAsync(string title, string cancelButton, string destroyButton, params string[] otherButtons)
		{
			throw new NotImplementedException();
		}

		public Task DisplayActionSheetAsync(string title, params IActionSheetButton[] buttons)
		{
			throw new NotImplementedException();
		}
	}
}
