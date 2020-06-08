using System;
using System.Net.Sockets;
using BancoShell.Modelos;

namespace BancoShell
{
    class Program
    {
        static void Main(string[] args)
        {
            /// value types
            // numericos
            int x = 7;
            int y = 3;
            decimal z = default;
            double a = 50.0;
            Add(ref x, y);
            Console.WriteLine(x);
            var pair = new Pair(1, 5);
            Add(pair);
            Console.WriteLine(pair.x);


            // texto
            char abc = 'a';
            string abcs = "xd";

            // booleanos
            bool d = false;
            ///

            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                // 50 -> 50*0
                // 50 + 32*1 -> 82
                // 50 + 32*2 -> 114
            }
            Console.WriteLine(numbers[0]);
            Sum(numbers);
            Console.WriteLine(numbers[0]);

            // Mostrar mostrar = new Mostrar();
            // mostrar.CapturaDatos();
            // mostrar.ImprimirDatos();
        }

        public static void Add(ref int x, int y)
        {
            Console.WriteLine(x);
            x += y;
        }

        public static void Add(Pair numbers)
        {
            numbers.x += numbers.y;
            Console.WriteLine(numbers.x);
        }

        public static void Sum(int[] suma)
        {
            int x = 0;
            for (int i = 0; i < suma.Length; i++)
            {
                x += suma[i];
            }
            suma[0] = x;
        }
    }

    public class Pair
    {
        public int x;
        public int y;

        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}