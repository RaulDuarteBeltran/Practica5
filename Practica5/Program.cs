using Practica5.Interfaces;
using Practica5.Modelos.ModelosDePrueba;

namespace Practica5;
class Program
{
    private static IRestaurante restaurante = new RestaurantePrueba();

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
                case "2":
                    ManejarOpcionAgregarElementosAMenu();
                    break;
            }
        }
    }

    static void MostrarMenuAdministracionMenus()
    {
        Console.WriteLine("1) Agregar Menu nuevo");
        Console.WriteLine("2) Agregar Elementos a menú");
    }

    static void ManejarOpcionAgregarMenuNuevo()
    {
        Console.WriteLine("Dime el titulo del nuevo menu:");
        string titulo = Console.ReadLine();
        
        restaurante.CrearMenu(titulo);
    }

    static void ManejarOpcionAgregarElementosAMenu()
    {

    }
}

