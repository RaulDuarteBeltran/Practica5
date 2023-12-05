using System;
namespace Practica5.Interfaces
{
	public interface IElementoCuenta
	{
		IPlatillo Platillo { get; }
		int Cantidad { get; set; }
		int CostoTotal { get; }
	}
}

