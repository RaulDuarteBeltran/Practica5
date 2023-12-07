using System;
using Practica5.Interfaces;

namespace Practica5.Modelos.ModelosDePrueba
{
	public class PlatilloPrueba : IPlatillo
	{
		public PlatilloPrueba()
		{
		}

        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Id => throw new NotImplementedException();
    }
}

