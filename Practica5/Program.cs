using Practica5.Interfaces;
using Practica5.Modelos;

namespace Practica5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        while(true)
        {
            MostrarMenuPrincipal();
            Console.WriteLine("Seleccione opción:");
            string opcionSeleccionada = Console.ReadLine();

            switch(opcionSeleccionada)
            {
                case "1":
                    ManejarOpcionAdministrarMenus();
                    break;
                    
            }
        }
    }

    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("1) Administrar Menús");
        Console.WriteLine("2) Administrar Cuentas");
        Console.WriteLine("3) Salir");
    }

    static void ManejarOpcionAdministrarMenus()
    {
        while (true)
        {
            MostrarMenuAdministracionMenus();
            Console.WriteLine("Seleccione opción:");
            string opcionSeleccionada = Console.ReadLine();

            switch (opcionSeleccionada)
            {
                case "1":
                    ManejarOpcionAgregarMenuNuevo();
                    break;
            }
        }
    }

    static void MostrarMenuAdministracionMenus()
    {
        Console.WriteLine("Agregar Menu nuevo");
    }

    static void ManejarOpcionAgregarMenuNuevo()
    {
        Console.WriteLine("Dime el titulo del nuevo menu:");
        string titulo = Console.ReadLine();
        IRestaurante restaurante = new RestaurantePrueba();
        restaurante.CrearMenu(titulo);
    }
}

