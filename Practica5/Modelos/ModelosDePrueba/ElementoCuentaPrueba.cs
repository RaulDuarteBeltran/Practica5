using System;
using Practica5.Interfaces;

namespace Practica5.Modelos.ModelosDePrueba
{
	public class ElementoCuentaPrueba: IElementoCuenta
	{
		public ElementoCuentaPrueba()
		{
		}

        public IPlatillo Platillo => throw new NotImplementedException();

        public int Cantidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CostoTotal => throw new NotImplementedException();
    }
}

