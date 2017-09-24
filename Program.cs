using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppBZorkSpel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Rum Mysteriet!");
            Console.WriteLine();

            Console.Write("Ange ditt namn för att starta: ");
            string player = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Hej {player}, du befinner dig just nu i ett mörkt rum. Du ser ingenting, inte ens dina egna händer...");
            Console.WriteLine($"Hur har du hamnat här och hur ska du ta dig ut? Bara du kan rädda dig själv {player}.");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Här får du en lista med kommoandon som finns i spelet. Lycka till!");
            Console.WriteLine();
            Directions.Direction();

           
            GameObjects.Lampa();

            

            Console.ReadLine();
            
        }
    }
}
