using System;
using Microsoft.WindowsAzure.MobileServices;

namespace AppAnimalForms
{
	[DataTable("Pet")]
	public class Pet
	{
		[Version]
		public string AzureVersion { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Foto { get; set; }
		public string Id { get; set; }

		public Pet(string nome, string descricao, string foto)
		{
			this.Nome = nome;
			this.Descricao = descricao;
			this.Foto = foto;
		}

		public Pet()
		{
		}
	}
}
