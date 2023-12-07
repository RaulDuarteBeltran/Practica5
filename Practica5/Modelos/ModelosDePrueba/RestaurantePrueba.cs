using System;
using Practica5.Interfaces;

namespace Practica5.Modelos.ModelosDePrueba
{
	public class RestaurantePrueba : IRestaurante
	{
		public RestaurantePrueba()
		{
		}

        public void AgregarElementosAMenu(IMenu menu)
        {
            throw new NotImplementedException();
        }

        public IMenu CrearMenu(string tituloMenu)
        {
            throw new NotImplementedException();
        }

        public void MostrarMenus()
        {
            throw new NotImplementedException();
        }

        public IMenu ObtenerMenu(int indiceMenu)
        {
            throw new NotImplementedException();
        }
    }
}

