using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
       class Usuario
    {
        string nombre;
        int oro;
        int nivel;
        int mana;
        Heroe heroe;
        public List<Carta> mazo;
        List<Carta> mano;
        List<Carta> cartasJuego;

        public Usuario(string nombre)
        {
            this.nombre = nombre;
            oro = 0;
            nivel = 1;
            cartasJuego = new List<Carta>();
            
        }

        public void Jugar(Usuario contrincante)
        {
            mano = new List<Carta>();
            AgregarCartaMano(mazo[0]);
            mazo.RemoveAt(0);
            int manaUsado = 0;
            mana++;
            while (true) 
              {
                Console.Write("¿Qué quiere hacer? (ingrese una opcion)");
                Console.Write("1. Usar Carta de la mano");
                Console.Write("2. Usar Habilidad");
                Console.Write("3. Usar Carta en juego");
                Console.Write("4. Terminar turno");
                Console.Write("5. Rendirse");
                int opcion = Console.Read();
                if (opcion == 1) //Elegir carta de la mano 
                {
                    Console.Write("Elije una carta a usar");
                    for (int i = 0; i < mano.Count; i++)
                    {
                        Console.WriteLine(i.ToString() + " " + mano[i]);
                    }
                    int opcion2 = Console.Read();
                    if (mana - manaUsado - mano[opcion2].VerCantidadMana() >= 0)
                    {
                        manaUsado = manaUsado + mano[opcion2].VerCantidadMana();
                        UsarCarta(mano[opcion2]);
                        mano.RemoveAt(opcion2);
                        
                    }
                    else
                    {
                        Console.Write("No hay suficiente mana");
                    }

                }
                else if (opcion == 2) //usar habilidad heroe
                {
                    if (mana - manaUsado - 2 >= 0) //tiene suficiente mana para usar la habilidad
                    {
                        manaUsado = manaUsado + 2;
                        heroe.IHabilidad();
                    }
                    else //no tiene mana suficiente para usar habilidad
                    {
                        Console.Write("No hay suficiente mana");
                    }
                }
                else if (opcion == 3) //usar carta que esta en el juego
                {
                    for (int i = 0; i < cartasJuego.Count; i++)
                    {
                        Console.WriteLine(i.ToString() + " " + cartasJuego[i]);
                    }
                    int opcion3 = Console.Read();
                    IAtacar atauqe = cartasJuego[opcion3];
                    atauqe.Ataque();
                }
                else if(opcion == 4) //terminar el turno
                {
                    Console.Write("Terminó turno");
                    break;
                }
                else //rendirse
                {

                }
            }
        }

        public void ModificarNivel(int nuevoNivel)
        {
            nivel = nuevoNivel;
        }

        public void ModificarOro(int nuevoOro)
        {
            oro = nuevoOro;
        }

        public void AgregarCartaMano(Carta carta)
        {
            mano.Add(carta);
        }

        public void EscogerHeroe(Heroe heroeElejido)
        {
            heroe = heroeElejido;
        }
        public void UsarCarta(Carta cartaEnJuego)
        {
            cartasJuego.Add(cartaEnJuego);
        }
        public void GenerarMazo()
        {
            mazo =new List<Carta>() ;
            Carta wisp = new Minions("Wisp", 1, 1, 0);
            Carta murloc = new Minions("Murloc Raider", 2, 1, 1);
            Carta bloodfen = new Minions("Bloodfen Raptor", 3, 2, 2);
            Carta river = new Minions("River Crocolisk", 2, 3, 2);
            Carta magma = new Minions("Magma Rager", 5, 1, 3);
            Carta yeti = new Minions("Chillwind Yeti", 4, 5, 4);
            Carta oasis = new Minions("Oasis Snapjaw", 2, 7, 4);
            Carta ogre = new Minions("Boulderfist Ogre", 6, 7, 6);
            Carta war = new Minions("War Golem", 7, 7, 7);
            Carta core = new Minions("Core Hound", 9, 5, 7);
            int count = 0;
            while (count < 3)
            {
                mazo.Add(wisp);
                mazo.Add(murloc);
                mazo.Add(bloodfen);
                mazo.Add(river);
                mazo.Add(magma);
                mazo.Add(yeti);
                mazo.Add(oasis);
                mazo.Add(ogre);
                mazo.Add(war);
                mazo.Add(core);

                count += 1;
            }
        }
        public void MezclarMazo()
        {
            int count = 0;
            while (count < 30)
            {
                int numero = 9; // tienen que ser un random entrre 0 y el largo del mazo
                mazo.Add(mazo[numero]);
                mazo.RemoveAt(numero);
            }
        }
    }
}
