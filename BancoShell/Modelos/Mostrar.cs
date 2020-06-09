using System;
using System.Collections.Generic;

namespace BancoShell.Modelos
{
    class Mostrar
    {
        List<Cliente> Lista;

        public Mostrar()
        {
            Lista = new List<Cliente>();
        }

        public void CapturaDatos()
        {
            int cantidad;
          
            Console.WriteLine("Ingrese la candtidad de clientes que desea registrar");
            cantidad = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Ingrese el nombre de los clientes");
            for (int i = 0; i < cantidad; i++)
            {
                Lista.Add(new Cliente(Console.ReadLine()));
            }
           
        }



        public void ImprimirDatos()
        {
            Console.WriteLine("Estos son los nombres ingresados");
            foreach (Cliente item in Lista)
            {
                Console.WriteLine(item.Nombre);
            }

            Console.ReadKey();
        }
    }
}