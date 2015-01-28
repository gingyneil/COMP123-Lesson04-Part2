using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Villain : Character
    {
        //PRIVATE PROPERTY ++++++++++++++++++++++++++++++++++++++++
        private bool greed = true;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++++
        public Villain(string name, int health, int smarts, string gender):
            base(name, health, smarts, gender)
        {
            this.showProfile();

        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++
        public void doesBadThings()
        {
            Console.WriteLine("Doin' bad things...YEAH!");
        }
    }
}
