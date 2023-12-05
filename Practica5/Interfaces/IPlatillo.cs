using System;
namespace Practica5.Interfaces
{
	public interface IPlatillo
	{
		string Nombre { get; set; }
		int Precio { get; set; }
		int Id { get; }
	}
}

