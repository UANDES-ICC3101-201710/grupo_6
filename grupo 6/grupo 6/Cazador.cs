using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Cazador: Heroe, IHabilidad, ISerAtacado
    {
        void ISerAtacado.ContraAtacar()
        {
        }
        void ISerAtacado.RecibirAtaque()
        {
        }
        public Cazador(int salud, int nivel, int armadura, int habilidad) : base(salud, nivel, armadura)
        {
        }
        void HabilidadAtaque(Heroe objetivo)
        {
            salud = objetivo.VerSalud(objetivo) - 3;//revisar salud
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
