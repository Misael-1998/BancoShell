using System;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Views
{
    class SubMenu : Menu
    {
        public SubMenu(int numnerOpcion) : base(numnerOpcion)
        {
            
        }

        protected override void ShowMenu()
        {
            
            Console.WriteLine(Name);
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"\t{Options[i]}");
            }
        }
    }
}
