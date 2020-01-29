using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero_Academy_Amanda_TE17A
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Superhero Academy! You are a new student who just enrolled, ready to become a professional hero!");
            Console.WriteLine("But first you need to fill out your personal information and tell us what powers you have.");
            Console.WriteLine("Ready? Let's begin!");
            AnyKey();

            Console.WriteLine("Firstly, write down your name!");

            Hero MC = new Hero();

            MC.name = Console.ReadLine();

            Console.WriteLine("Is " + MC.name + " correct?");
            Console.WriteLine("Write Yes or No.");

            string answer = YesNo();

            while (answer == "no")
            {
                MC.name = Console.ReadLine();

                Console.WriteLine("Is " + MC.name + " correct?");
                Console.WriteLine("Write Yes or No.");

                answer = YesNo();
            }

            if (answer == "yes")
            {
                Console.WriteLine("Great! Let's continue.");
            }

            AnyKey();

            Console.WriteLine("Next fill in what your superpower is:");
            Console.WriteLine("Plantmancer: You have the power to control plants, like Poison Ivy.");
            Console.WriteLine("Speedster: You have the power of superspeed, like the Flash or Quicksilver.");

            Console.ReadLine();
        }

        static string YesNo()
        {
            string yesno = Console.ReadLine().ToLower(); //simpelt. En metod som skickar ut Yes eller No som en string till metoden som kallade på YesNo.

            while ((yesno != "no") && (yesno != "yes"))//Gjorde en while-loop så att spelaren inte kan skriva något annat än yes eller no
            {
                Console.WriteLine("Please write only Yes or No.");

                yesno = Console.ReadLine().ToLower();//gör en toLower för att göra så att spelarens typografi(caps tex) inte spelar någon roll.
            }

            return (yesno);//skickar tillbaka stringen yesno till metoden som kallade på YesNo.
        } //Gjorde en string för Yes eller No eftersom detta används mycket i spelet.

        static void AnyKey() //simpel metod för att rensa konsollen
        {
            Console.WriteLine("-->Press Any Key<--");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
