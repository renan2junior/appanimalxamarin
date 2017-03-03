using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Common;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace AppAnimalForms.ViewModels
{
	public class DadosPetPageViewModel : BindableBase, INavigationAware, IPageDialogService
	{
		public DadosPetPageViewModel(INavigationService navigationService, IApplicationProvider applicationProvider)
		{
			_navigationService = navigationService;
			_applicationProvider = applicationProvider;
			Teste = "Ola mundo";
			ws = new PetWS();
			_deletePetCommand = new DelegateCommand(DeletePet);
			_salvarPetCommand = new DelegateCommand(SalvarPet);

		}

		private ICommand _deletePetCommand;
		private ICommand _salvarPetCommand;
		private string _teste;
		private Pet _petSelecionado;
		private PetWS ws;
		readonly INavigationService _navigationService;
		private IApplicationProvider _applicationProvider;



		public string Teste
		{
			get { return _teste; }
			set {
				SetProperty(ref _teste, value);
			}
		}

		public Pet PetSelecionado
		{
			get { return _petSelecionado; }
			set
			{
				SetProperty(ref _petSelecionado, value);
			}
		}

		public ICommand DeletePetCommand
		{
			get { return _deletePetCommand; }
		}

		public ICommand SalvarPetCommand
		{
			get { return _salvarPetCommand; }
		}

		void DeletePet()
		{
			ws.DeletePet(PetSelecionado);
			_navigationService.GoBackAsync();
			_applicationProvider.MainPage.DisplayAlert("Suceeso!", "Seu pet foi removido.", "OK");

		}

		void SalvarPet()
		{
			ws.UpdatePet(PetSelecionado);
			_applicationProvider.MainPage.DisplayAlert("Suceeso!", "Seu pet foi alterado.", "OK");
			_navigationService.GoBackAsync();
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			PetSelecionado = (Pet)parameters["Item"];
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
