using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_Amanda_TE17A
{
    public class Plantmancer : Hero
    {

        int greenThumb = 2;

        int manipulative = 4;


        public void Stats()
        {
            speed = 3;
            strength = 1;
            charisma = 5;
            heroism = 3;
        }

        public override void Get_Stats()
        {
            base.Get_Stats();

            Console.WriteLine("Green Thumb: " + greenThumb + "/5");
            Console.WriteLine("Manipulation: " + manipulative + "/5");
        }

    }
}
