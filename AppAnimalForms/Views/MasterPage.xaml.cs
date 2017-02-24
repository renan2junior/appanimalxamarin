using Xamarin.Forms;
using AppAnimalForms.Models;
using System.Collections.Generic;

namespace AppAnimalForms.Views
{
	public partial class MasterPage : ContentPage
	{

		public ListView ListView { get { return listView;}}


		public MasterPage()
		{
			InitializeComponent();


			var masterPageItens = new List<MasterPageItem>();

			/*
			masterPageItens.Add(new MasterPageItem
			{
				Title = "Login",
				IconSource = "ic_person_outline_white_24dp.png",
				TargetType = typeof(PetsUsuarioPage)
			});

			masterPageItens.Add(new MasterPageItem
			{
				Title = "Meus Dados",
				IconSource = "ic_work_white_24dp.png",
				TargetType = typeof(DadosUsuarioPage)
			});
			*/

			masterPageItens.Add(new MasterPageItem
			{
				Title = "Meus Pets",
				IconSource = "ic_pets_white_24dp.png",
				TargetType = typeof(PetsUsuarioPage)
			});

			/*
			masterPageItens.Add(new MasterPageItem
			{
				Title = "Busca por qrcode",
				IconSource = "ic_crop_free_white_24dp.png",
				TargetType = typeof(PetsUsuarioPage)
			});

			masterPageItens.Add(new MasterPageItem
			{
				Title = "Adotar Pet",
				IconSource = "ic_mood_white_24dp.png",
				TargetType = typeof(PetsUsuarioPage)
			});

			masterPageItens.Add(new MasterPageItem
			{
				Title = "Cadastrar Pet",
				IconSource = "ic_add_circle_outline_white_24dp.png",
				TargetType = typeof(PetsUsuarioPage)
			});
			*/





			listView.ItemsSource = masterPageItens;

		}
	}
}

