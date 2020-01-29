using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Gustav_Jonsson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("Please write the name of your hero, then press enter");
            string heroName = Console.ReadLine();

            Console.WriteLine("Welcome to Superhero Academy, " + heroName + "!");
            Console.WriteLine("     ");

            Console.ReadLine();

            int herotype = generator.Next(1, 3);

            if (herotype == 1)
            {
                Console.WriteLine(heroName + " is a Paragon!");
                Paragon MainHero = new Paragon();
            }
            if (herotype == 2)
            {
                Console.WriteLine(heroName + " is a Mutant!");
                Mutant MainHero = new Mutant();
            }

            Console.ReadLine(); 
        }
    }
}