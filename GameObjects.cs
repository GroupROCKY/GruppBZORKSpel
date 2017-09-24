using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppBZorkSpel
{
    public class GameObjects
    {
        public void Inventory()
        {
            string[] inventory = new string[5];

            inventory[0] = "Datorsladd";
            inventory[1] = "Föremål";
            inventory[2] = "Föremål";
            inventory[3] = "Föremål";
            inventory[4] = "Föremål";

            for (int i = 0; i < inventory.Length; i++)
			{
            Console.WriteLine(inventory[i]);
			}
        }

      
        
        public static void Lampa()
        {
            Console.WriteLine("Börja med att hitta en lampa för att få tillbaka din syn..");
            Console.WriteLine();
            bool tändLampa = true;
            string lampKommandon = Console.ReadLine();

            if (lampKommandon == "GO SOUTH")
            {
                Console.WriteLine("Du känner något framför dig. Känns som massa brädor som spikats fast på väggen.");
                lampKommandon = Console.ReadLine();

                if (lampKommandon == "GO WEST")
                {
                    Console.WriteLine("Aajj!! Helveteee.. Du slog I din tå i något hårt.. Du ser inget, men det känns som ett skrivbord.");
                    lampKommandon = Console.ReadLine();

                }
            }

            

            if (lampKommandon == "GO NORTH")
            {
                Console.WriteLine("Du går in i något som börjar vobbla. Kan det vara en lampa tro?");
                lampKommandon = Console.ReadLine();
            }

            if (lampKommandon == "GO EAST")
            {
                Console.WriteLine("Dina fingrar rör vid en knapp..");
                lampKommandon = Console.ReadLine();
            }


            if (lampKommandon == "tänd lampa")
            {
                Console.WriteLine("Nu är Lampan tänd!");
                tändLampa = true;
            }
           

            
           
            Console.ReadLine();
        }
    }
}

   
     
