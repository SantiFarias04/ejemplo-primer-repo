using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sobreescritura_de_métodos
{
    class Perro: AnimalDomestico, NoFlyable
    {
        public override string Comunicarse()
        {
            return "guau guauu";
        }

        public string NoVolar()
        {
            return "camina como un perro xd";
        }
    }
}
