﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace AppAnimalForms.ViewModels
{
	public class DadosUsuarioPageViewModel : BindableBase, INavigationAware
	{
		public DadosUsuarioPageViewModel()
		{

		}

		private Pet _petSelecionado;
		public Pet PetSelecionado
		{
			get { return _petSelecionado; }
			set { SetProperty(ref _petSelecionado, value); }
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
