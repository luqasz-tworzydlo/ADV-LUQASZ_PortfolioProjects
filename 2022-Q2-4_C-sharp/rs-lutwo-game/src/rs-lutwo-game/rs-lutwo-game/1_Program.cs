using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rs_lutwo_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            The_Beginning(); // zawiera 3 instrukcje
            // kolejna klasa zawiera 7 instrukcji ( ukryte w klasie The_Beggining )
            // jeszcze kolejna klasa zawiera 5 instrukcji ( dotyczy klasy Main_Quest_A )
            // w jeszcze innej klasie zawierają się 4 instrukcje ( dotyczy klasy Main_Quest_B )
            // ostatnia klasa Main_Quest zawieraja w sobie 3 instrukcje ( dotyczy klasy Main_Quest_C )
            // na końcu jest jeszcze klasa z gratulacjami, jak i z możliwością powtórki gry ( klasa Congratulations_You_Did_It )

            Console.ReadKey();
        }
        static void The_Beginning()
        {
            // poniżej jest kilka słów od autora gry ( Łukasz W. Tworzydło ) :>
            A_Little_Bit_About_Myself();
            // trzy instrukcje, pierwotnie zaimplementowane w klasie Program
            // zostały przeniesione do nowej klasy, nazwanej Beginning
            // [ zrobiono to w celu lepszej przejrzystości kodu ]
            Beginning.Start_End_Game();
        }
        static void A_Little_Bit_About_Myself()
        {
            Console.WriteLine("I warmly welcome you to my game (RS LUTWO GAME) ! ;>\n");

            Console.WriteLine("My name is Lukasz W. Tworzydlo ... I'm an IT student. ^;^\n");

            Console.WriteLine("This is the first game I programmed in Microsoft Visual Studio Community 2022." +
                "\n... and for this game, I used the C# programming language. :P\n");

            Console.WriteLine("Maybe it's nothing special, but I hope you will enjoy it. :>>>");

            Console.WriteLine("\n////////// ////////// ////////// ////////// //////////\n");

            Console.WriteLine("Press any key to continue...\n");
            string SNG;
            SNG = Convert.ToString(Console.ReadLine());
            switch (SNG)
            {
                default:
                    break;
            }
        }
    }
}
