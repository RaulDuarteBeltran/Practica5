﻿using System;
using Practica5.Interfaces;

namespace Practica5.Modelos.ModelosDePrueba
{
    public class MenuPrueba : IMenu
    {
        public string Titulo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AgregarPlatillo(string nombrePlatillo, int precioPlatillo)
        {
            throw new NotImplementedException();
        }

        public void MostrarMenu()
        {
            throw new NotImplementedException();
        }

        public IPlatillo ObtenerPlatillo(int idPlatillo)
        {
            throw new NotImplementedException();
        }
    }
}

