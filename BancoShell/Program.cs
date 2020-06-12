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
        private static ClientController ClientController = new ClientController();
        private static SubMenu OpcionesExtras = new SubMenu(4);

        static void Main(string[] args)
        {


            Console.WriteLine("**\nBienvenido a BancoShell es un gusto atendederle\n**");
            MainMenu.TryAddOption("Ingresar clientes", 0);
            MainMenu.TryAddOption("Abrir cuentas", 1);
            MainMenu.TryAddOption("Ingresar dinero", 2);
            MainMenu.TryAddOption("Mas opciones", 3);
            MainMenu.TryAddOption("Salir", 4);
            int opcion;
            OpcionesExtras.TryAddOption("Transferir cuentas", 0);
            OpcionesExtras.TryAddOption("Calcular capital", 1);
            OpcionesExtras.TryAddOption("Cambiar la tasa de intereses", 2);
            OpcionesExtras.TryAddOption("Salir", 3);

            do
            {

                opcion = MainMenu.CaptureOption() ?? -1;

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n**Ingresar clientes**\n");
                        ClientController.CapturaDatos();
                        ClientController.ImprimirDatos();
                        break;

                    case 1:
                        Console.WriteLine("\nAbrir cuentas\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("\nIngresar dinero\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nMas opciones\n");
                        Console.WriteLine("\nPresione la letra *s* para regresar al menu\n");

                        Console.WriteLine("**Sub menu BancoShell**");
                        int capturar = OpcionesExtras.CaptureOption() ?? -1;
                        do
                        {

                            switch (capturar)
                            {
                                case 0:
                                    Console.WriteLine("\nTransferir cuentas");
                                    Console.WriteLine("\nPresione la letra *n* para regresar al menu\n");
                                    Console.ReadKey();
                                    break;

                                case 1:
                                    Console.WriteLine("\nCalcular capital");
                                    Console.WriteLine("\nPresione la letra *n* para regresar al menu\n");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.WriteLine("\nCambiar la tasa de intereses");
                                    Console.WriteLine("\nSi usted desea salir del sub menu solo escriba la letra *n*\n");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine(
                                        "\nSeleccione una de las opciones del menu o si desea salir presione la letra n\n");
                                    break;
                            }
                        } while (capturar != 3);

                        break;
                    default:
                        Console.WriteLine(
                            "\n \n");
                        break;

                }

            } while (opcion != 4);
            Console.WriteLine("\nGracias por preferirnos que tenga un excelente dia \n");
        }

    }
}