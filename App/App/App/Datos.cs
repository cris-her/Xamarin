using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App
{
    public class Datos : NotificationObject
    {
		private ObservableCollection<Disco> discos;

		public ObservableCollection<Disco> Discos
		{
			get { return discos; }
			set 
			{ 
				discos = value;
				OnPropertyChanged();
			}
		}

		private Disco discoSeleccionado;
		public Disco DiscoSeleccionado
		{
			get { return discoSeleccionado; }
			set
			{
				discoSeleccionado = value;
				OnPropertyChanged();
			}

		}

		public MyCommand AgregarDiscoCommand { get; set; }

		public Datos()
		{
			Discos = new ObservableCollection<Disco>();
			Discos.Add(new Disco() 
			{ 
				Banda = "The Beatles", 
				Titulo = "Help", 
				Genero ="Rock and roll", 
				FechaLanzamiento = new DateTime(1965,8,6), 
				Portada="Help.jpg" ,
				Precio = (decimal)4.5
			});
			Discos.Add(new Disco() { Banda = "The Beatles", Titulo = "Revolver", Genero = "Rock and roll", FechaLanzamiento = new DateTime(1966, 8, 6), Portada = "Revolver.jpg", Precio = (decimal)5 });
			Discos.Add(new Disco() { Banda = "The Beatles", Titulo = "Let it be", Genero = "Rock and roll", FechaLanzamiento = new DateTime(1970, 5, 6), Portada = "LetItBe.jpg", Precio = 5 });

			AgregarDiscoCommand = new MyCommand(AgregarDiscoCommandExecute, AgregarDiscoCommandCanExecute);

		}

		private bool AgregarDiscoCommandCanExecute()
		{
			return Discos.Count < 10;
		}

		private void AgregarDiscoCommandExecute()
		{
			Discos.Add(new Disco() { Banda = "Nirvana", Titulo = "Nevermind", Precio =  1, FechaLanzamiento = new DateTime(1991, 4, 4)});
			AgregarDiscoCommandCanExecute();
		}
	}
}
