using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Armas:Carta //no hay cartas de este tipo en esta entrega
    {
        public Armas(string nombre, int ataque, int salud, int mana) : base(nombre, ataque, salud, mana)
        {

        }
    }
}
