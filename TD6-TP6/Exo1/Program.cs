using System;
using System.Collections.Generic;

namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> listeAnimal = new List<Animal>();

            Elephant pepito = new Elephant(SexeAnimal.MASCULIN, "Pepito", 1988, 200, 2.54, Continent.Afrique);
            Elephant quoicoubeh = new Elephant(SexeAnimal.FEMININ, "quoicoubeh", 2015, 150, 1.7, Continent.Asie);

            Girafe mateo = new Girafe(2019, "Mateo", 7000, SexeAnimal.MASCULIN, 15);
            Girafe thibaud = new Girafe(1998, "thibaud", 100, SexeAnimal.FEMININ, 3);

            listeAnimal.Add(pepito);
            listeAnimal.Add(quoicoubeh);

            listeAnimal.Add(mateo);
            listeAnimal.Add(thibaud);

            Console.WriteLine(pepito);
            Console.WriteLine(quoicoubeh);

            Console.WriteLine(mateo);
            Console.WriteLine(thibaud);
        }
    }
}
