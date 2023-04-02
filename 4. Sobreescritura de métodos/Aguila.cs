using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sobreescritura_de_métodos
{
    class Aguila: AnimalSalvaje,Flyable
    {
        public string Volar()
        {
            return "vuela como un aguila xD";
        }
      
    }
}
