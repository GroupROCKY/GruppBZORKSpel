using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppBZorkSpel
{
    public class Directions
    {
        // Kommandon i spelet
        public static void Direction()
        {
            List<string> kommandon = new List<string>();
            kommandon.Add("> GO NORTH, SOUTH, EAST, WEST: tex. GO EAST, spelaren går ett steg till öst.");
            kommandon.Add("> USE OBJECT / ITEM: tex. USE COMPUTER, använd datorn");
            kommandon.Add("> SHOW HINT: tex. SEARCH DESK, undersöker skrivbord");
            kommandon.Add("> PICK UP ITEM: Lägger ITEM i inventory");
            kommandon.Add("> DROP ITEM: Tar bort ITEM från inventory och lägger det där du står");
            kommandon.Add("> SHOW INVENTORY: Visar ditt inventory");

            foreach (var item in kommandon)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

       
       
    }
}
