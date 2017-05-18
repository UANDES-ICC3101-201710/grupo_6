using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Heroe: IHabilidad
    {
        void IHabilidad.HabilidadArmadura() {
        }
        void IHabilidad.HabilidadAtaque() {
        }
        void IHabilidad.HabilidadAtaqueDefensa() {
        }
        void IHabilidad.HabilidadCarta() {
        }
        void IHabilidad.HabilidadMinions() {
        }
        void IHabilidad.HabilidadTotem() {
        }
        void IHabilidad.HabilidadVida()
        {
        }
        public int salud;
        public int nivel;
        public int armadura;

        public Heroe(int salud, int nivel, int armadura)
        {
            this.salud = salud;
            this.nivel = nivel;
            this.armadura = armadura;
        }

        public void ModificarNivel(int nuevoNivel)
        {
            nivel = nuevoNivel;
        }
        public int VerSalud(Heroe heroe)
        {
            return salud;
        }
        public int VerArmadura(Heroe heroe)
        {
            return armadura;
        }

        internal abstract void IHabilidad();
    }
}
