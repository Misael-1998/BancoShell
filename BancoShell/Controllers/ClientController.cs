using System;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Controllers
{
    class ClientController
    {
        List<Cliente> Lista;

        public ClientController()
        {
            Lista = new List<Cliente>();
        }

        public void CapturaDatos()
        {
            string cantidad;
            int numerosClientes;
            Console.WriteLine("Ingrese la candtidad de nombres que decea\n");
            cantidad = Console.ReadLine();
            try
            {
                numerosClientes = int.Parse(cantidad);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor numerico");
                return;
            }

            for (int i = 0; i < numerosClientes; i++)
            {
                Console.WriteLine("Ingrese los nombres deseados");
                Lista.Add(new Cliente(Console.ReadLine()));
            }
        }

    



    public void ImprimirDatos()
    {
        Console.WriteLine("Estos son los nombres ingresados");
        foreach (Cliente item in Lista)
        {
            Console.WriteLine(item.Nombre + "\n");

        }
        Console.WriteLine("\nPresione la letra s para regresar al menu\n");
        Console.WriteLine("\n \n");
        Console.ReadKey();
    }
}
}

