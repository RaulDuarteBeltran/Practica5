using System;
namespace Practica5.Interfaces
{
	public interface IRestaurante
	{
		IMenu CrearMenu(string tituloMenu);
		void AgregarElementosAMenu(IMenu menu);
		void MostrarMenus();
		IMenu ObtenerMenu(int indiceMenu);
	}
}

