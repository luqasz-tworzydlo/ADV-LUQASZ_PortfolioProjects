using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Main_Quest_B
    {
        // niniejsza klasa Main_Quest_B zawiera kolejne 4 instrukcje
        // [tj. Heal_Improved, FourthFight, FifthFight, SixthFight],
        // które są kontynuacją właściwej rozgrywki w grze
        public static void Heal_Improved()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");
            Console.WriteLine("Now you can heal 9 HP... but your new enemies" +
                "\ncan do it as well. Be careful...");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string MQ2;
            MQ2 = Convert.ToString(Console.ReadLine());
            switch (MQ2)
            {
                default:
                    FourthFight(); break;
            }
        }
        public static void FourthFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Fourth encounter...");
            Console.WriteLine("This is your fourth fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 45;
            int Player_Attack = 5 + 3;
            int Enemy_Attack = 7;
            int Heal_HP_Amount = 5+4;

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
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        Player_HP -= Enemy_Attack;
                        Console.WriteLine("\nEnemy attacks and deals " + Enemy_Attack + " damage!");
                    }
                    else
                    {
                        Enemy_HP += Heal_HP_Amount;
                        Console.WriteLine("\nEnemy restores " + Heal_HP_Amount + " health points!");
                    }
                }
            }

            if (Player_HP > 0)
            {
                Console.WriteLine("Congratulations, you defeated the fourth enemy!");
                FifthFight();
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                Main_Quest_A.TheEnd();
            }
        }
        public static void FifthFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Fifth encounter...");
            Console.WriteLine("This is your fifth fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 55;
            int Player_Attack = 5 + 4;
            int Enemy_Attack = 7;
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
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        Player_HP -= Enemy_Attack;
                        Console.WriteLine("\nEnemy attacks and deals " + Enemy_Attack + " damage!");
                    }
                    else
                    {
                        Enemy_HP += Heal_HP_Amount;
                        Console.WriteLine("\nEnemy restores " + Heal_HP_Amount + " health points!");
                    }
                }
            }

            if (Player_HP > 0)
            {
                Console.WriteLine("Congratulations, you defeated the fifth enemy!");
                SixthFight();
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                Main_Quest_A.TheEnd();
            }
        }
        public static void SixthFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Sixth encounter...");
            Console.WriteLine("This is your sixth fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 65;
            int Player_Attack = 5 + 5;
            int Enemy_Attack = 7;
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
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        Player_HP -= Enemy_Attack;
                        Console.WriteLine("\nEnemy attacks and deals " + Enemy_Attack + " damage!");
                    }
                    else
                    {
                        Enemy_HP += Heal_HP_Amount;
                        Console.WriteLine("\nEnemy restores " + Heal_HP_Amount + " health points!");
                    }
                }
            }

            if (Player_HP > 0)
            {
                Console.WriteLine("Congratulations, you defeated the sixth enemy!");
                // poniższa instrukcja prowadzi do ostatniej klasy Main_Quest
                Main_Quest_C.The_Final_Encounter(); // zawiera 3 instrukcje [ końcówka gry ]
                                                    // [ odniesienie do klasy Main_Quest_C ]
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                Main_Quest_A.TheEnd();
            }
        }
    }
}
