using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    class Hero
    {
        //PRIVATE PROPERITIES ++++++++++++++++++++++++++++++++++++++
        private bool bravery = true;
        private int health;
        private int smarts;
        private string gender;
        
        //CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
        }

        // PUBLIC METHODS
        public void doesGoodThings() {
            Console.WriteLine("Doin' good things...YEAH!");
        }
    }
}
