using System;
using System.ComponentModel;

namespace AppAnimalForms
{
	public class ObservableBaseObject:INotifyPropertyChanged
	{
		public ObservableBaseObject()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropretyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

	}
}
