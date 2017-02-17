using System;
namespace AppAnimalForms
{
	public class Pet
	{

		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Foto { get; set; }

		public Pet(string nome, string descricao, string foto)
		{
			this.Nome = nome;
			this.Descricao = descricao;
			this.Foto = foto;
		}
	}
}
