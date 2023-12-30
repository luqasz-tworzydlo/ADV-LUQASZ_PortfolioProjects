using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Three_Questions
    {
        // niniejsza klasa wykonuje pokolei zaimplementowane instrukcje
        // [ wyświetlanie pokolei każdego z pytań, najpierw pierwszego,
        // potem drugiego, a potem trzeciego ] - w przypadku błędnej odpowiedzi
        // należy zacząć odpowiadanie na pytania od nowa bądź można skończyć grę

        // ponadto niniejsza klasa zawiera siedem instrukcji
        // [tj. NewGame, AreYouReady, Introduction_To_Questions,
        // Exit, Question_1, Question_2, Question_3],
        // które rozpoczynają grę od trzech pytań

        public static void NewGame()
        {
            AreYouReady();
            Introduction_To_Questions();
        }
        public static void AreYouReady()
        {
            // krótka instrukcja do-while
            // zadaje pytanie, czy jest się gotowym
            // jeśli tak to należy wpisać YES
            // [ w przeciwnym razie będzie
            // pytanie stale powtarzane ]
            string YES = "YES";
            do
            {
                Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

                Console.WriteLine("Are you ready?");

                Console.WriteLine("\n////////// ////////// ////////// ////////// //////////");

                Console.WriteLine(
                    "\n=> if yes, type \"YES\" (continue a game)" +
                    "\n=> if no, type \"NO\" or anything else.\n");
            } while (!(Console.ReadLine() == YES));
        }
        public static void Introduction_To_Questions()
        {
            // jest to swoiste wprowadzenie do gry, gdzie aby rozpocząć prawidłową grę
            // należy odpowiedzieć prawidłowo na trzy pytania, które zostaną wyświetlone
            // [ jedna błędna odpowiedź powoduje, iż gracz przegrywa i musi rozpocząć nową grę ]
            // jako ułatwienie zastosowano opcję powtórzenia tego etapu, pomijając wprowadzenie
            // < w celu przejścia do pytań należy wcisnąć jakikolwiek przycisk na klawiaturze >
            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("I'm glad you are ready... but before you go," +
                "\nyou will need to answer three questions correctly." +
                "\nIf you don't, you won't start your journey....\n");

            Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string TQ;
            TQ = Convert.ToString(Console.ReadLine());
            switch (TQ)
            {
                default:
                    Question_1(); break;
            }
        }
        public static void Exit() { } // niniejsza operacja ma za zadanie zakończenie gry
        public static void Question_1()
        {
            // niniejsza funkcja zadaje pierwsze pytanie [ spośród trzech ]
            // przy prawidłowej odpowiedzi jest przejście do kolejnego pytania
            // w przeciwnym wypadku należy rozpocząć grę od początku, a więc
            // należy zacząć odpowiadać znowu od pierwszego pytania
            Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");
            Console.WriteLine("(Q1) What is the first book in the Bible?");
            Console.WriteLine("< type correct answer [write \"A\", \"B\" or \"C\"] >");
            Console.WriteLine("\n" +
                "=> ( A ) Ruth" +
                "\n=> ( B ) Genesis" +
                "\n=> ( C ) Deuteronomy\n");
            string Y_N;
            Y_N = Convert.ToString(Console.ReadLine());
            switch (Y_N)
            {
                case "A":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A1;
                    RQ_A1 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A1)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                case "B":
                    Console.WriteLine("\nCongratulations! That's the correct answer! ^.^\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to continue...\n");
                    string CA;
                    CA = Convert.ToString(Console.ReadLine());
                    switch (CA)
                    {
                        default:
                            Question_2(); break;
                    }
                    break;
                case "C":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A2;
                    RQ_A2 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A2)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                default:
                    Console.WriteLine("\nNo answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A3;
                    RQ_A3 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A3)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
            }
        }
        public static void Question_2()
        {
            // niniejsza funkcja zadaje dugie pytanie [ spośród trzech ]
            // przy prawidłowej odpowiedzi jest przejście do kolejnego pytania
            // w przeciwnym wypadku należy rozpocząć grę od początku, a więc
            // należy zacząć odpowiadać znowu od pierwszego pytania
            Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");
            Console.WriteLine("(Q2) How many days did God take to create the world?");
            Console.WriteLine("< type correct answer [write \"A\", \"B\" or \"C\"] >");
            Console.WriteLine("\n" +
                "=> ( A ) 5" +
                "\n=> ( B ) 6" +
                "\n=> ( C ) 7\n");
            string Y_N;
            Y_N = Convert.ToString(Console.ReadLine());
            switch (Y_N)
            {
                case "A":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A1;
                    RQ_A1 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A1)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                case "B":
                    Console.WriteLine("\nCongratulations! That's the correct answer! ^.^\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to continue...\n");
                    string CA;
                    CA = Convert.ToString(Console.ReadLine());
                    switch (CA)
                    {
                        default:
                            Question_3(); break;
                    }
                    break;
                case "C":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A2;
                    RQ_A2 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A2)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                default:
                    Console.WriteLine("\nNo answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A3;
                    RQ_A3 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A3)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
            }
        }
        public static void Question_3()
        {
            // niniejsza funkcja zadaje trzecie pytanie [ spośród trzech ]
            // przy prawidłowej odpowiedzi jest przejście do kolejnego pytania
            // w przeciwnym wypadku należy rozpocząć grę od początku, a więc
            // należy zacząć odpowiadać znowu od pierwszego pytania
            Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");
            Console.WriteLine("(Q3) How many disciples did Jesus choose?");
            Console.WriteLine("< type correct answer [write \"A\", \"B\" or \"C\"] >");
            Console.WriteLine("\n" +
                "=> ( A ) 12" +
                "\n=> ( B ) 15" +
                "\n=> ( C ) 18\n");
            string Y_N;
            Y_N = Convert.ToString(Console.ReadLine());
            switch (Y_N)
            {

                case "A":
                    Console.WriteLine("\nCongratulations! That's the correct answer! ^.^\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to continue...\n");
                    string CA;
                    CA = Convert.ToString(Console.ReadLine());
                    switch (CA)
                    {
                        default:
                            // poniższa instrukcja powoduje rozpoczęcie wykonywania instrukcji z innej klasy
                            Main_Quest_A.Before_A_Fight(); // zawiera 5 instrukcji [ w ramach kontynuacji ]
                                                           // [ odniesienie do klasy Main_Quest_A ]
                            break;
                    }
                    break;
                case "B":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A1;
                    RQ_A1 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A1)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                case "C":
                    Console.WriteLine("\nWrong answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A2;
                    RQ_A2 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A2)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
                default:
                    Console.WriteLine("\nNo answer :<\n");

                    Console.WriteLine("////////// ////////// ////////// ////////// //////////\n");

                    Console.WriteLine("Press any key to repeat or type \"Q\" to exit...\n");
                    string RQ_A3;
                    RQ_A3 = Convert.ToString(Console.ReadLine());
                    switch (RQ_A3)
                    {
                        case "Q":
                            Exit(); break;
                        default:
                            Question_1(); break;
                    }
                    break;
            }
        }
    }
}
