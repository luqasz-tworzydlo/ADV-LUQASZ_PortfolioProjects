using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Enemy : Player
    {
        // jest to klasa Enemy z dziedziczeniem z klasy Player
        public string FirstName = "LVT";

        public override string ToString()
        {
            return $"This is: {FirstName} {ENM}!";
        }
    }
}
