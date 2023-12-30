using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Main_Quest_C
    {
        // niniejsza klasa Main_Quest_C zawiera ostatnie 3 instrukcje
        // [tj. The_Final_Encounter, Remember, SeventhFight],
        // które są już końcówką właściwej rozgrywki w grze

        public static void The_Final_Encounter()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("And fear not them which kill the body," +
                "\nbut are not able to kill the soul:;" +
                "\nbut rather fear him which is able" +
                "\nto destroy both soul and body in hell" +
                "\n=> Matthew 10:28");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");

            Console.WriteLine("\nThis is your final encounter.");
            Console.WriteLine("Defeat an ancient dragon that leads many to the pit of hell.");
            Console.WriteLine("You have to protect the innocent and slay evil!");

            Console.WriteLine("\nTake this holy water for protection [+ 25 HP].");
            Console.WriteLine("Now go and fight! May God bless you!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string MQ3_1;
            MQ3_1 = Convert.ToString(Console.ReadLine());
            switch (MQ3_1)
            {
                default:
                    Remember(); break;
            }
        }

        public static void Remember()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("Put on the whole armour of God," +
                "\nthat ye may be able to stand against" +
                "\nthe wiles of the devil. For we wrestle" +
                "\nnot against flesh and blood, but against" +
                "\nthe rulers of the darkness of this world," +
                "\nagainst spiritual wickedness in high [places]." +
                "\n=> Ephesians 6:11-13");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string MQ3_2;
            MQ3_2 = Convert.ToString(Console.ReadLine());
            switch (MQ3_2)
            {
                default:
                    SeventhFight(); break;
            }
        }

        public static void SeventhFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Seventh encounter...");
            Console.WriteLine("This is your seventh fight!");
            Player d_f = new Enemy();
            Console.WriteLine(d_f);

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50+25;
            int Enemy_HP = 100;

            int Player_Attack = 5 + 6;
            int Enemy_Attack = 7 + 7;
            int Heal_HP_Amount = 5 + 4;

            // *** do wykonana operacji losowejprzez przeciwnika
            Random random = new Random();

            while (Player_HP > 0 && Enemy_HP > 0)
            {
                // ruch gracza, może zaatakować przeciwnika, leczyć się lub nic nie robić
                Console.WriteLine("\n--- --- --- --- --- --- --- --- --- --- --- ---");
                Console.WriteLine("<--| <> | Player Turn | <> |-->");
                Console.WriteLine("Player HP - " + Player_HP + ". Enemy HP - " + Enemy_HP);
                Console.WriteLine("\nEnter 'A' to attack or 'H' to heal.");

                string choice = Console.ReadLine();

                if (choice == "A")
                {
                    Enemy_HP -= Player_Attack;
                    Console.WriteLine("\nPlayer attacks and deals " + Player_Attack + " damage!");
                    Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---\n");
                }
                else if (choice == "H")
                {
                    Console.WriteLine("\nPlayer restores " + Heal_HP_Amount + " health points!");
                    Player_HP += Heal_HP_Amount;
                    Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---\n");
                }
                else
                {
                    Console.WriteLine("\nWhat a shame... you did nothing! :<");
                    Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---\n");
                }

                // ruch przeciwnika, wroga - może atakować lub się leczyć
                if (Enemy_HP > 0)
                {
                    Console.WriteLine("<--| >< | Enemy Turn | >< |-->");
                    Console.WriteLine("Player HP - " + Player_HP + ". Enemy HP - " + Enemy_HP);
                    int enemyChoice = random.Next(0, 3);

                    if (enemyChoice == 0)
                    {
                        Enemy_HP += Heal_HP_Amount;
                        Console.WriteLine("\nEnemy restores " + Heal_HP_Amount + " health points!");
                    }
                    else if (enemyChoice == 1)
                        Console.WriteLine("\nThe enemy will attack soon...");
                    else
                    {
                        Player_HP -= Enemy_Attack;
                        Console.WriteLine("\nEnemy attacks and deals " + Enemy_Attack + " damage!");
                    }
                }
            }

            if (Player_HP > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
                // poniższa instrukcja prowadzi do ostatniej stworzonej klasy do gry
                Congratulations.Congratulations_You_Did_It(); // zawiera 2 instrukcje [ gratulacje ]
                                                              // [ odniesienie do klasy Congratulations ]
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                Main_Quest_A.TheEnd();
            }
        }
    }
}
