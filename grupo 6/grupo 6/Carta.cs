using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ 
    public abstract class Carta: IAtacar, ISerAtacado
    {
        void IAtacar.Ataque() { 
        }
        void IAtacar.RecibirDano() {
        }
        void ISerAtacado.ContraAtacar() {
        }
        void ISerAtacado.RecibirAtaque() {
        }


        public string nombreCarta;
        public int ataque;
        public int salud;
        public int cantidadMana;

        public Carta(string nombre, int ataque, int salud, int mana)
        {
            nombreCarta = nombre;
            this.ataque = ataque;
            this.salud = salud;
            cantidadMana = mana;
        }
        public int VerCantidadMana()
        {
            return cantidadMana;
        }
        public int VerCantidadSalud(Carta carta)
        {
            return salud;
        }
        public int VerPotenciaAtaque()
        {
            return ataque;
        }
    }
}
