using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Beginning
    {
        // niniejsza klasa zawiera trzy instrukcje
        // [tj. Start_End_Game, LittleHistory, NewPlayer],
        // które są wprowadzeniem do późniejszej, właściwej rozgrywki

        // ponadto na końcu jest odniesienie do klasy Three_Questions
        public static void Start_End_Game()
        {
            // wprowadzenie do gry, cytat z Biblii z Księgi Jeremiasza 33:3
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
            Console.WriteLine("Call unto me, and I will answer thee,\n" +
                "and shew thee great and mighty things,\n" +
                "which thou knowest not.\n" +
                "=> Jeremiah 33:3");
            Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");

            // krótkie dalsze wprowadzenie
            Console.WriteLine("\n^^^^^^^^^^^ ^^^^^^^^^^^ ^^^^^^^^^^^");
            Console.WriteLine("This is... RS LUTWO GAME! :>");
            Console.WriteLine("^^^^^^^^^^^ ^^^^^^^^^^^ ^^^^^^^^^^^");
            Console.WriteLine("\nDo you wanna start a new game?" +
                "\nWrite YES if you do... or NO ;p\n");

            // krótka instrukcja warunkowa z użyciem switch'y
            // rozpoczęcie lub zakończenie gry na samym początku
            // [rozpoczęcie gry: YES bądź Y, zakończenie: NO bądź N]
            // w przypadku braku wpisania odpowiedniej komendy ustawiono
            // domyślną opcję na zakończenie instrukcji, a więc jakby było
            // wpisane NO bądź N [ czyli zakończenie programu na początku ]
            string Y_N;
            Y_N = Convert.ToString(Console.ReadLine());
            switch (Y_N)
            {
                case "YES":
                    LittleHistory(); break;
                case "Y":
                    LittleHistory(); break;
                case "NO": Console.WriteLine("I understand... maybe next time :<<"); break;
                case "N": Console.WriteLine("I understand... maybe next time :<<"); break;
                default:
                    Console.WriteLine("You didn't write anything... so I guess you won't play it :'("); break;
            }
        }
        public static void LittleHistory()
        {
            // dalsza kontynuacja wprowadzająca do gry
            // [ krótka, wymyślona na szybko historyjka ]
            // użyto tutaj pętli do-while, która będzie
            // powtarzać instrukcję do momentu,
            // gdy wpisze się komendę YES
            // ( w przeciwnym wypadku
            // będzie powtarzana historyjka )
            // + cytat z Biblii z Księgi Mateusza 18:7
            string YES = "YES";
            do
            {
                Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

                Console.WriteLine("\nYou are the one... and only one.");
                Console.WriteLine("Thanks to divine protection, you are alive.");

                Console.WriteLine("\nHowever, you are the only one who can restore" +
                    "\nwhat has been taken from your people!");
                Console.WriteLine("\nYou have to defeat unleashed evil!");

                Console.WriteLine("\nTake your bow and arrows and go!" +
                    "\n... and don't forget about your medkits!");

                Console.WriteLine("\nDefeat a dragon and its followers to bring peace" +
                    "\nto your kingdom once and for all! May God protect you!\n");

                Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");
                Console.WriteLine("Woe unto the world because of offences!" +
                    "\nfor it must needs be that offences come;" +
                    "\nbut woe to that man by whom the offence cometh!" +
                    "\n=> Matthew 18:7");
                Console.WriteLine("--- --- --- --- --- --- --- --- --- --- --- ---");

                Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

                Console.WriteLine(
                    "\nContinue?" +
                    "\n=> if no, type \"NO\" or anything else;" +
                    "\n=> if yes, type \"YES\" (you will start a game).\n");
            } while (!(Console.ReadLine() == YES));
            NewPlayer();
        }
        public static void NewPlayer()
        {
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");
            Console.WriteLine("\nName your character:");
            Player f_n = new Archer(firstName: Console.ReadLine());

            Console.WriteLine("\nYou are an archer... and...\n" + f_n);
            // Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            // poniższa instrukcja powoduje rozpoczęcie wykonywania instrukcji z innej klasy
            Three_Questions.NewGame(); // zawiera 7 instrukcji [ w ramach kontynuacji ]
                                       // [ odniesienie do klasy Three_Questions]
        }
    }
}
