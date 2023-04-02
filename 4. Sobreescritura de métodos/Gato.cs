using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sobreescritura_de_métodos
{
    class Gato: AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "miau, miau";
        }

    }
}
