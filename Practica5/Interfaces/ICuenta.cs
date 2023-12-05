using System;
namespace Practica5.Interfaces
{
	public interface ICuenta
	{
		int CostoTotal { get; }
		void AgregarElemento(IPlatillo platillo, int cantidad);
		void MostrarCuenta();
	}
}

