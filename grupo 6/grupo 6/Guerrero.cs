using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Guerrero : Heroe, ISerAtacado, IHabilidad

    {
        void ISerAtacado.ContraAtacar() {
        }
        void ISerAtacado.RecibirAtaque() {
        }


        public Guerrero(int salud, int nivel, int armadura) : base(salud, nivel, armadura)
        {
        }
        void HabilidadArmadura(Heroe objetivo)
        {
            armadura = objetivo.VerArmadura(objetivo) + 3;//revisar armadura
        }
        void RecibirAtaque(Heroe contrincante, Heroe objetivo)
        {
            salud = objetivo.VerSalud(objetivo) - 3;
        }
        void RecibirAtaque(Carta contrincante, Heroe objetivo)
        {
            salud = objetivo.VerSalud(objetivo) - contrincante.VerPotenciaAtaque();
        }
    }
}
