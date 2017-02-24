using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace AppAnimalForms.ViewModels
{
	public class DadosPetPageViewModel : BindableBase, INavigationAware
	{
		public DadosPetPageViewModel()
		{
			Teste = "Ola mundo";
		}

		private string _teste;
		public string Teste
		{
			get { return _teste; }
			set {
				SetProperty(ref _teste, value);
			}
		}

		private Pet _petSelecionado;
		public Pet PetSelecionado
		{
			get { return _petSelecionado; }
			set
			{
				SetProperty(ref _petSelecionado, value);
			}
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
