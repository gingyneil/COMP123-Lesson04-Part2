using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    // HERO SUBCLASS OR CHARACTER SUPER CLASS
    class Hero : Character
    {
        //PRIVATE PROPERITIES ++++++++++++++++++++++++++++++++++++++
        private bool courage = true;
        
        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name, int health, int smarts, string gender):
            base(name, health, smarts, gender)
        {
            this.showProfile();
        }

        // PUBLIC METHODS
        public void doesGoodThings() {
            Console.WriteLine("Doin' good things...YEAH!");
        }
    }
}
