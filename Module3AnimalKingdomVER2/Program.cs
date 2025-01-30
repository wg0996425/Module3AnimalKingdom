using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3AnimalKingdomVER2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bird macaw = new Bird("Macaw", 6);
            Fish tuna = new Fish("Tuna", 1);

            macaw.MakeSound();
            tuna.MakeSound();

            Console.WriteLine(macaw.Name);
            Console.WriteLine(tuna.Age);
        }
    }
}
