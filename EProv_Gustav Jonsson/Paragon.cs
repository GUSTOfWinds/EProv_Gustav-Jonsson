using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Gustav_Jonsson
{
    class Paragon : Superhero
    {
        public Paragon()
        {
            strength = generator.Next(8, 14);
            dexterity = generator.Next(8, 14);
            intelligence = generator.Next(8, 14);
        }
    }
}