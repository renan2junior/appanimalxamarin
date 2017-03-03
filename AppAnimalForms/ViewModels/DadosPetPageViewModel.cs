using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace AppAnimalForms.ViewModels
{
	public class DadosPetPageViewModel : BindableBase, INavigationAware
	{
		public DadosPetPageViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;
			Teste = "Ola mundo";
			ws = new PetWS();
			_deletePetCommand = new DelegateCommand(DeletePet);

		}

		private ICommand _deletePetCommand;
		private string _teste;
		private Pet _petSelecionado;
		private PetWS ws;
		readonly INavigationService _navigationService;

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

		void DeletePet()
		{
			ws.DeletePet(PetSelecionado);
			_navigationService.GoBackAsync();

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			PetSelecionado = (Pet)parameters["Item"];
		}
	}
}
