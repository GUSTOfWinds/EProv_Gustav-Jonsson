using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv_Gustav_Jonsson
{
    class Superhero
    {
        protected static Random generator = new Random();

        protected int strength = 0;
        protected int dexterity = 0;
        protected int intelligence = 0;

        public int CombatCheck()
        {
            int result = generator.Next(0, 21) + strength;
            return result;
        }

        public int SpeedCheck()
        {
            int result = generator.Next(0, 11) + dexterity;
            return result;
        }

        public int AcademicCheck()
        {
            int result = generator.Next(0, 5) + intelligence;
            return result;
        }
    }
}
