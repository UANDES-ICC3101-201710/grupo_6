using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Cementerio
    {
        List<Carta> cartasMuertas;

        public void AgregarMuerto(Carta cartaMuerta)
        {    
             cartasMuertas.Add(cartaMuerta);
        }
    }
}
