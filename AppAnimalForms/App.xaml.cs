using Prism.Unity;
using AppAnimalForms.Views;

namespace AppAnimalForms
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("MainPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<DadosPetPage>();
			Container.RegisterTypeForNavigation<DadosUsuarioPage>();
			Container.RegisterTypeForNavigation<PetsUsuarioPage>();
		}
	}
}

