using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero(7, 8, "female");
            myHero.doesGoodThings();


            Villain myVillain = new Villain("SpiderGirl", 9, 9, "female");
            myVillain.doesBadThings();


            // Wait for Input before closing console
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
