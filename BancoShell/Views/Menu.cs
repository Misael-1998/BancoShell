using System;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Views
{
    class Menu
    {

        public string Name { get; set; } = "Menu";
        protected string[] Options { get; } = { "salir" };
        public int NumberOfOptions
        {
            get => Options.Length;
        }

        public Menu(int numeroOpciones)
        {
            if (numeroOpciones < 1) return;
            Options = new string[numeroOpciones];
        }

        public bool TryAddOption(string optionName, int posicition)
        {
            if (posicition < 0 || posicition >= Options.Length) return false;
            Options[posicition] = $"{posicition + 1}-{optionName}";
            return true;
        }

        protected virtual void ShowMenu()
        {
            Console.WriteLine(Name);
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine(Options[i]);
            }

        }

        public int? CaptureOption()
        {
            ShowMenu();
            string option;
            int optionNumber;
            Console.WriteLine("Ingrese una opcion valida");
            option = Console.ReadLine();
            if (int.TryParse(option, out optionNumber))
            {
                return optionNumber - 1;
            }
            else
            {
                return null;
            }
        }

    }
}
