using System;
using System.Collections.Generic;
namespace AppAnimalForms
{
	public class PetWS
	{

		public List<Pet> Lista { get; set; }

		public PetWS()
		{
		}

		public List<Pet> GetPets()
		{
			Lista = new List<Pet>();
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			Lista.Add(new Pet("Toto", "Bom", "http://www.mytop.fm/wp-content/uploads/2016/09/un-gato-bebe-433.jpg"));
			return Lista;
		}
	}
}
