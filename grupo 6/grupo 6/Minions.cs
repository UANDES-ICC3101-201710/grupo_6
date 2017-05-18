using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Minions:Carta, ISerAtacado, IAtacar
    {
        public Minions(string nombre, int ataque, int salud, int mana) : base(nombre, ataque, salud, mana)
        {
            
        }
        void RecibirAtaque(Carta contrincante, Heroe objetivo)
        {
            salud = objetivo.VerSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }
        void RecibirAtaque(Carta contrincante, Carta objetivo)
        {
            salud = objetivo.VerCantidadSalud(objetivo) - contrincante.VerPotenciaAtaque();//hacer metodo en carta
        }
        void ContraAtaque(Carta contrincante, Carta objetivo)
        {
            salud = objetivo.VerCantidadSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }
        void Ataque(Carta contrincante, Heroe objetivo)
        {
            salud = objetivo.VerSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }
        void Ataque(Carta contrincante, Carta objetivo)
        {
            salud = objetivo.VerCantidadSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }
        void RecibirDano(Carta contrincante, Carta objetivo)
        {
            salud = objetivo.VerCantidadSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }

    }
}
