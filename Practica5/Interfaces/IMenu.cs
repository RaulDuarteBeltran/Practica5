using System;
namespace Practica5.Interfaces
{
	public interface IMenu
	{
		string Titulo { get; set; }
		void MostrarMenu();
		void AgregarPlatillo(string nombrePlatillo, int precioPlatillo);
		IPlatillo ObtenerPlatillo(int idPlatillo);

	}
}

