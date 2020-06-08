using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Modelos
{
    class Mostrar
    {
        ArrayList Lista;

        public Mostrar()
        {
            Lista = new ArrayList();
        }

        public void CapturaDatos()
        {
            int cantidad;
            string nombre;
            int cantidadCuenta;
            double cuenta;
            Console.WriteLine("Ingrese la candtidad de nombres que decea");
            cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese los nombres deseados");
                nombre = Console.ReadLine();
                Lista.Add(nombre);

              
            }
           
        }



        public void ImprimirDatos()
        {
            foreach (var nombres in Lista)
            {
                Console.WriteLine("Estos son los nombres ingresados");
                Console.WriteLine(nombres);
               

            }
            Console.ReadKey();
        }
      
    }
}
