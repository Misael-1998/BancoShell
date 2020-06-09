using System;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Controllers
{
    class ClientController
    {
        List<Cliente> Lista;

        public  ClientController()
        {
            Lista = new List<Cliente>();
        }

        public void CapturaDatos()
        {
            int cantidad;
            
            Console.WriteLine("Ingrese la candtidad de nombres que decea\n");
            cantidad=Convert.ToInt32(Console.ReadLine());
           
            
                for (int i = 0; i < cantidad; i++)
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
                Console.WriteLine(item.Nombre+"\n");
               
            }
            Console.WriteLine("\nPresione la letra s para regresar al menu\n");
            Console.WriteLine("\n \n");
            Console.ReadKey();
        }
    }
}

