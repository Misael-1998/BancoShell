using BancoShell.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoShell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente> { 
            
                new Cliente("Juan"),
                new Cliente("Miguelito"),
                new Cliente("Flor")
            };

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].Nombre);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
