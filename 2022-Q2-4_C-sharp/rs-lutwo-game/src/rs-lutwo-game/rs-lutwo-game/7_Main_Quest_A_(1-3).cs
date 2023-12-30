using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Main_Quest_A
    {
        // niniejsza klasa Main_Quest_A zawiera pięć instrukcji
        // [tj. Before_A_Fight, TheEnd, FirstFight, SecondFight,
        // ThirdFight], które rozpoczynają właściwy etap gry

        public static void Before_A_Fight()
        {
            // po wykonaniu pierwszych trzech zadań teraz jest pora na ostateczne wyzwanie
            // gracz będzie musiał wykonać 7 walk z wrogiem, gdzie 7 będzie najtrudniejsza
            // [ jako ułatwienie to po każdej udanej bitwie gracz otrzymuje premię w ataku ]

            // podczas każdych z walk gracz będzie mieć dwie opcje [ atak lub leczenie ]
            // jeśli wygra pierwszą bitwę to jest przejście automatycznie do kolejnej
            // [ wyjątkiem jest ostatnia bitwa [ 7 ], gdzie będzie krótkie wprowadzenie

            // gracz rozpoczyna każdy pojedynek z określonymi punktami życia [ jako ułatwienie
            // zastosowano opcję leczenia, dodawania punktów życia bez górnego limitu ]

            // jeśli gracz straci wszystkie punkty życia to przegrywa i kończy się gra

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("You have proven you are ready." +
                "\nNow go and prove yourself once again!\n");

            Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string MQ1;
            MQ1 = Convert.ToString(Console.ReadLine());
            switch (MQ1)
            {
                default:
                    FirstFight(); break;
            }
        }
        public static void TheEnd() { Console.WriteLine("This is the end... we are doomed :<"); } // funkcja kończąca grę na skutek śmierci gracza
        public static void FirstFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> First encounter...");
            Console.WriteLine("This is your first fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 25;
            int Player_Attack = 5;
            int Enemy_Attack = 7;
            int Heal_HP_Amount = 5;

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
                    int enemyChoice = random.Next(0, 1);

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
                Console.WriteLine("Congratulations, you defeated the first enemy!");
                SecondFight();
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                TheEnd();
            }
        }
        public static void SecondFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Second encounter...");
            Console.WriteLine("This is your second fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 30;
            int Player_Attack = 5 + 1;
            int Enemy_Attack = 7;
            int Heal_HP_Amount = 5;

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
                    int enemyChoice = random.Next(0, 1);

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
                Console.WriteLine("Congratulations, you defeated the second enemy!");
                ThirdFight();
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                TheEnd();
            }
        }
        public static void ThirdFight()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("=> Third encounter...");
            Console.WriteLine("This is your third fight!");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

            // poniżej jest implementacja zdrowia, siły ataku oraz leczenia
            int Player_HP = 50;
            int Enemy_HP = 35;
            int Player_Attack = 5 + 2;
            int Enemy_Attack = 7;
            int Heal_HP_Amount = 5;

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
                    int enemyChoice = random.Next(0, 1);

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
                Console.WriteLine("Congratulations, you defeated the third enemy!");
                // poniższa instrukcja do innej klasy jest kontynuacją niniejszej
                Main_Quest_B.Heal_Improved(); // zawiera 4 instrukcji [ w ramach kontynuacji ]
                                              // [ odniesienie do klasy Main_Quest_B ]
            }
            else
            {
                Console.WriteLine("\nYou lose! ;<\n");
                TheEnd();
            }
        }
    }
}
