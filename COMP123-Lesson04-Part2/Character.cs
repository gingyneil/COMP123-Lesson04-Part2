using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson04_Part2
{
    // CHARACTER SUPER CLASS
    class Character
    {

        // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++
        protected int health;
        protected int smarts;
        protected string gender;
        protected string name;
        
        // CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Character(string name, int health, int smarts, string gender)
        {
            this.name = name;
            this.health = health;
            this.smarts = smarts;
            this.gender = gender; // Gender of the Character
        }

        // PROTECTED MEHODS +++++++++++++++++++++++++++++++++++++++++++++++++
        protected void showProfile()
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("Smarts: {0}", this.smarts);
            Console.WriteLine("Gender: {0}", this.gender);
            Console.WriteLine("++++++++++++++++++++++++++");
        }

    }
}
