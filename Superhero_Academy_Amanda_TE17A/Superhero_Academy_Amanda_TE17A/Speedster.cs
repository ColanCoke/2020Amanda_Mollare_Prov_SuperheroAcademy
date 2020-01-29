using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_Amanda_TE17A
{
    public class Speedster : Hero
    {
        int humour = 3;

        int annoyance = 5;

        public void Stats() //en metod för att ändra statsen så de passar för hjältetypen
        {
            speed = 5;
            strength = 2;
            charisma = 3;
            heroism = 2;
        }

        public override void Get_Stats() //en override-metod för att lägga till extra-klasserna som Speedster har.
        {
            base.Get_Stats();

            Console.WriteLine("Humour: " + humour + "/5");
            Console.WriteLine("Annoyance: " + annoyance + "/5");

        }
    }
}
