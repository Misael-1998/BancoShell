using System;
using System.Collections.Generic;
using System.Text;

namespace BancoShell.Controllers
{
    class Cliente
    {
        public string Nombre
        {
            get;
            set;
        }

        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
    }
}
