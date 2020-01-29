using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_Amanda_TE17A
{
    public class Hero //Arvklass som innehåller diverse attribut som alla hjältetyper ska ha.
    {
        //integers och strings för olika stats som hjälten ska ha.
        public string name;

        public string gender;

        public int speed;
        
        protected int strength; //protected betyder att andra arvklasser kan få tag på dessa data, men är privata i andra sammanhang.

        protected int heroism;

        protected int charisma;

        public virtual void Get_Stats() //en metod för att printa stats. den är virtual då alla olika typer lägger till egna stats.
        {
            Console.WriteLine("Speed: " + speed + "/5");
            Console.WriteLine("Strength: " + strength + "/5");
            Console.WriteLine("Charisma: " + charisma + "/5");
            Console.WriteLine("Heroism: " + heroism + "/5");
        }
    }
}
