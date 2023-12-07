using System;
using Practica5.Interfaces;

namespace Practica5.Modelos.ModelosDePrueba
{
	public class CuentaPrueba: ICuenta
	{
		public CuentaPrueba()
		{
		}

        public int CostoTotal => throw new NotImplementedException();

        public void AgregarElemento(IPlatillo platillo, int cantidad)
        {
            throw new NotImplementedException();
        }

        public void MostrarCuenta()
        {
            throw new NotImplementedException();
        }
    }
}

