﻿using System;
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
            string nombre;
            Console.WriteLine("Ingrese la candtidad de nombres que decea");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los nombres deseados");
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
