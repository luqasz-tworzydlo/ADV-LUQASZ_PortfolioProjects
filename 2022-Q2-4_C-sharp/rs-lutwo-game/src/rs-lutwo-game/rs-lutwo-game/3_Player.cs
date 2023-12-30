using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    abstract internal class Player
    {
        // niniejsza klasa składa się na elementy klasy Archer oraz klasy Enemy
        public string SecondName = "Protector";
        public string YourTitle = "God's Warrior";

        public string ENM = "Dragon";

        public string Properties_PA_E
        {
            get;
        }
    }
}
