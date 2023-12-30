using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Congratulations
    {
        // niniejsza klasa Main_Quest_C zawiera ostatnie 3 instrukcje
        // [tj. The_Final_Encounter, Remember, SeventhFight],
        // które są już końcówką właściwej rozgrywki w grze

        public static void Congratulations_You_Did_It()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Wow! You did it! You just did it! ^<^\n");

            Console.WriteLine("As you know, rewards come with carrying a cross...");
            Console.WriteLine("... and soon you will be generously rewarded. ^_^");

            Console.WriteLine("\nNow come with me, and I will show you" +
                "\nyour reward when we return home.\n");

            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("And be not conformed to this world:" +
                "\nbut be ye transformed by the renewing of your mind," +
                "\nthat ye may prove what is that good, and acceptable," +
                "\nand perfect, will of God" +
                "\n=> Romans 12:2");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string COA;
            COA = Convert.ToString(Console.ReadLine());
            switch (COA)
            {
                default:
                    The_Last_Question(); break;
            }
        }
        public static void The_Last_Question()
        {
            Console.WriteLine("\nDo you would like to restart a game?" +
                "\nWrite \"YES\" if you do... or \"NO\" ^*^\n");

            string YoN;
            YoN = Convert.ToString(Console.ReadLine());
            switch (YoN)
            {
                case "YES":
                    Beginning.Start_End_Game(); break;
                case "Y":
                    Beginning.Start_End_Game(); break;
                case "NO": Console.WriteLine("That's okay. See ya ;>"); break;
                case "N": Console.WriteLine("That's okay. See ya ;>"); break;
                default:
                    Console.WriteLine("You didn't write anything..." +
                        "\n... so I guess you won't play it again." +
                        "\n... but that's okay. See ya later ;>"); break;
            }
        }
    }
}
