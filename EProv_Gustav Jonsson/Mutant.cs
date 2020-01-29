using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Gustav_Jonsson
{
    class Mutant : Superhero
    {
        public Mutant()
        {
            strength = generator.Next(10, 16);
            dexterity = generator.Next(10, 16);
            intelligence = generator.Next(5, 11);
        }
    }
}