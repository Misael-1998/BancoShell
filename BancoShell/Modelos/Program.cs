using BancoShell.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BancoShell
{
    class Program
    {
        static void Main(string[] args)
        {


            Mostrar mostrar = new Mostrar();

            mostrar.CapturaDatos();
            mostrar.ImprimirDatos();

        }
    }
}
