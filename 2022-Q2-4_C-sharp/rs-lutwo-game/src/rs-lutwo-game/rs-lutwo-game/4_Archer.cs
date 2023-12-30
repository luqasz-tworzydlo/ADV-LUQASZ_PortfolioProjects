using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Archer : Player
    {
        // jest to klasa Archer z dziedziczeniem z klasy Player
        public string FirstName;

        public Archer(
            string firstName)
        {
            FirstName = firstName;
        }
        public override string ToString()
        {
            return $"Your hero it's: {FirstName} {SecondName}\n... and you are {YourTitle}!";
        }
    }
}
