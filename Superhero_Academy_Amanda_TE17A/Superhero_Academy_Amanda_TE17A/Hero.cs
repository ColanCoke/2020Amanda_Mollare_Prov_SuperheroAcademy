using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_Amanda_TE17A
{
    public class Hero //Arvklass som innehåller diverse attribut som alla hjältetyper ska ha.
    {
        public string name;

        public string gender;

        public int speed;
        
        protected int strength;

        protected int heroism;

        protected int charisma;

        public void Get_Stats()
        {
            Console.WriteLine("Speed: " + speed + "/5");
            Console.WriteLine("Strength: " + strength + "/5");
            Console.WriteLine("Charisma: " + charisma + "/5");
            Console.WriteLine("Heroism: " + heroism + "/5");
        }
    }
}
