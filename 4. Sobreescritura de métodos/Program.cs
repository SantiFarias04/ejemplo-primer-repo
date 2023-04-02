using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sobreescritura_de_métodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Perro p1 = new Perro();

            Gato g1 = new Gato();
            g1.Nombre = "michifus";

            Animal a1 = g1;

            Gato g8 = (Gato)a1;

            List < Animal> animales= new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());

            List<Flyable> ListaVoladores = new List<Flyable>();
            ListaVoladores.Add(new Canario());
            ListaVoladores.Add(new Aguila());
            

            /*foreach (Animal item in animales)
            {
                Console.WriteLine(item.Comunicarse());*/
            List<NoFlyable> ListaNoVoladores = new List<NoFlyable>();
            ListaNoVoladores.Add(new Perro());




            Console.WriteLine(g8.Nombre);
            Console.WriteLine(p1.Comunicarse());
            Console.ReadKey();
        }
    
}
}
