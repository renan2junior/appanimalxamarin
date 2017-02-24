using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
namespace AppAnimalForms
{
	public class AzureService<T>
	{

		IMobileServiceClient Client;
		IMobileServiceTable<T> Table;

		public AzureService()
		{
			string ServiceURL = "http://animalapp.azurewebsites.net/";
			Client = new MobileServiceClient(ServiceURL);
			Table = Client.GetTable<T>();
		}

		public Task<IEnumerable<T>> GetTable()
		{
			return Table.ToEnumerableAsync();
			
		}
	}
}
