using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAnimalForms
{
	public class PetWS
	{

		public List<Pet> Lista { get; set; }

		AzureService<Pet> Service;

		public PetWS()
		{
			Service = new AzureService<Pet>();
		}

		public async Task<List<Pet>> GetPets()
		{
			var items = await Service.GetTable();
			return items.ToList();
		}

		public void InsertPet(Pet p)
		{
			Service.InsertItem(p);
		}

		public void DeletePet(Pet p)
		{
			Service.DeleteItem(p);
		}

		public void UpdatePet(Pet p) 
		{
			Service.UpdateItem(p);
		}
	}
}
