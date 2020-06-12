using BancoShell.Views;
using BancoShell.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace BancoShell
{
    public static class Program
    {
        private static Menu MainMenu = new Menu(5);

        static void Main(string[] args)
        {
            Console.WriteLine("**\nBienvenido a BancoShell es un gusto atendederle\n**");
            MainMenu.TryAddOption("Ingresar clientes",0);
            MainMenu.TryAddOption("Abrir cuentas",1);
            MainMenu.TryAddOption("Ingresar dinero",2);
            MainMenu.TryAddOption("Mas opciones",3);
            MainMenu.TryAddOption("Salir",4);
            int opcion;
            do
            {
                MainMenu.CaptureOption();
                opcion = MainMenu.CaptureOption() ?? -1;

                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("\n**Ingresar clientes**\n");
                        
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

                        do
                        {
                            Console.WriteLine("\n-Transferir cuentas-Opcion *1*" +
                           "\n-Calcular capital-Opcion *2*" +
                           "\nCambiar la tasa de intereses-Opcion *3*" +
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


            } while (opcion !=5 );
              Console.WriteLine("\nGracias por preferirnos que tenga un excelente dia \n");
        }

    }
}