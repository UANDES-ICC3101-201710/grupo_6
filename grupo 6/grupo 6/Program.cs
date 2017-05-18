using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("Trinidad Pardo");
            Usuario contrincante = new Usuario("Katherina Geiger");
            usuario.GenerarMazo();
            usuario.MezclarMazo();
            contrincante.GenerarMazo();
            contrincante.MezclarMazo();
            //leer archivo con todas las cartas X3
            usuario.Jugar(contrincante);
        }
    }
}
