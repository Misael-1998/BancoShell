using BancoShell.Controllers;
using BancoShell.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BancoShell
{
    public static class Program
    {

        private static ClientController ClientController = new ClientController();
        
        static void Main(string[] args)
        {


           
            char opcion;
            Console.WriteLine("**/nBienvenido a BancoShell es un gusto atendederle/n**");
            Console.WriteLine("Si usted desea salir del menu solo escriba la letra s");
            do
            {
                Console.WriteLine("** Menu BancoSehell **\n"+
                    "\n-Ingresar clientes-Opcion 1"+
                    "\n-Abrir cuentas-Opcion 2"+
                    "\nIngresar dinero-Opcion3"+
                    "\n-Mas opciones-Opcion4");
               
                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                   
                    case '1':
                        Console.WriteLine("Ingresar clientes");
                        ClientController.CapturaDatos();
                        ClientController.ImprimirDatos();
                        break;

                    case '2':
                        Console.WriteLine("Abrir cuentas");
                        break;

                    case '3':
                        Console.WriteLine("Ingresar dinero");
                        break;
                    case '4':
                        Console.WriteLine("Mas opciones");
                        char seleccion;
                     
                        Console.WriteLine("**Sub menu BancoShell**");
                       
                        do {
                            Console.WriteLine("\n-Transferir cuentas-Opcion1" +
                           "\n-Calcular capital-Opcion2" +
                           "\nCambiar la tasa de intereses-Opcion3"+
                           "\n-Salir-Ingrese la letra n");
                            seleccion = Console.ReadKey().KeyChar;
                            switch (seleccion)
                            {
                                case '1':
                                    Console.WriteLine("\nTransferir cuentas");
                                    Console.ReadKey();
                                    break;

                                case '2':
                                    Console.WriteLine("\nCalcular capital");
                                    Console.ReadKey();
                                    break;

                                case '3':
                                    Console.WriteLine("\nCambiar la tasa de intereses");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Seleccione una de las opciones del menu o si desea salir presione la letra n");
                                    break;
                            }
                            
                        }
                        while (seleccion !='n');

                       break;

                    default:
                        Console.WriteLine("Seleccione una de las opciones del menu o si desea salir presione la letra S");
                        break;
                }
            }
            while (opcion != 's');
            Console.WriteLine("Gracias por preferirnos que tenga un excelente dia ");




        }
    }
}
