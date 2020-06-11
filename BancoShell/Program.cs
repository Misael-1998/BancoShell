using BancoShell.Controllers;
using BancoShell.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace BancoShell
{
    public static class Program
    {
        private static ClientController ClientController = new ClientController();

        static void Main(string[] args)
        {
            
            char opcion;
            Console.WriteLine("**\nBienvenido a BancoShell es un gusto atendederle\n**");
            do
            {
             Console.WriteLine("\nSi usted desea salir del menu solo escriba la letra *s*\n");
             Console.WriteLine("** Menu BancoSehell **\n"+
                    "\n-Ingresar clientes-Opcion *1*\n"+
                    "\n-Abrir cuentas-Opcion *2*\n"+
                    "\n-Ingresar dinero-Opcion *3*\n"+
                    "\n-Mas opciones-Opcion *4*\n");
               
                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("\n**Ingresar clientes**\n");
                        ClientController.CapturaDatos();
                        ClientController.ImprimirDatos();
                        break;

                    case '2':
                        Console.WriteLine("\nAbrir cuentas\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");
                        Console.ReadKey();
                        break;

                    case '3':
                        Console.WriteLine("\nIngresar dinero\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");
                        Console.ReadKey();
                        break;
                    case '4':
                        Console.WriteLine("\nMas opciones\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");
                        char seleccion;

                        Console.WriteLine("**Sub menu BancoShell**");
                       
                        do {
                            Console.WriteLine("\n-Transferir cuentas-Opcion *1*" +
                           "\n-Calcular capital-Opcion *2*" +
                           "\nCambiar la tasa de intereses-Opcion *3*"+
                           "\n-Salir-Ingrese la letra n");
                            seleccion = Console.ReadKey().KeyChar;
                            switch (seleccion)
                            {
                                case '1':
                                    Console.WriteLine("\nTransferir cuentas");
                                    Console.WriteLine("\nPresione la letra *n* para regresar al menu\n");
                                    Console.ReadKey();
                                    break;

                                case '2':
                                    Console.WriteLine("\nCalcular capital");
                                    Console.WriteLine("\nPresione la letra *n* para regresar al menu\n");
                                    Console.ReadKey();
                                    break;

                                case '3':
                                    Console.WriteLine("\nCambiar la tasa de intereses");
                                    Console.WriteLine("\nSi usted desea salir del sub menu solo escriba la letra *n*\n");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine(
                                        "\nSeleccione una de las opciones del menu o si desea salir presione la letra n\n");
                                    break;
                            }
                        } while (seleccion != 'n');

                       break;
                    default:
                        Console.WriteLine(
                            "\nSeleccione una de las opciones del menu o si desea salir presione la letra S\n");
                        break;

                }

                
            } while (opcion != 's');

            Console.WriteLine("\nGracias por preferirnos que tenga un excelente dia \n");
        }
    }
}