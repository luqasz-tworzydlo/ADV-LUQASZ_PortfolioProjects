import java.util.Scanner;

//////////////////////////////////////////////////
//
// => Imię i nazwisko: Łukasz Tworzydło
// => Numer albumu: gd29623
// => Nr. kierunku: INIS5_PR2
// => Przedmiot: Zaawansowane technologie bazodanowe
//
//////////////////////////////////////////////////
// [prosta aplikacja do łączenia się z lokalną
// bądź zewnętrzną bazą danych PostgreSQL]
//////////////////////////////////////////////////

public class Menu {
    static Scanner sc = new Scanner(System.in);
    public static void ConnectToPostgreSQL()
    {
        System.out.println();

        var option_number = -1;
        System.out.println("1. Opcja nr 1 / Option no 1:\n" +
                "=> [PL] Wybierz lokalny serwer PostgreSQL i ogranicz ilość danych do uzupełnienia.\n" +
                "=> [ENG] Select a local PostgreSQL server and limit the amount of data to be filled.\n");
        System.out.println("2. Opcja nr 2 / Option no 2:\n" +
                "=> [PL] Wybierz zewnętrzny serwer PostgreSQL i uzupełnił o prawidłowe dane.\n" +
                "=> [ENG] Select an external PostgreSQL and enter the correct data for it.\n");

        option_number = sc.nextInt();
        switch (option_number) {
            default:
                option_number = 3;
            case 3:
                RestartJavaClient();
                break;
            case 2:
                Server.ExternalPostgreSQL();
                break;
            case 1:
                Server.LocalPostgreSQL();
                break;
        }
    }
    public static void RestartJavaClient()
    {
        System.out.println("\n=> Rozpocząć ponownie działanie programu? / Restart the program?");
        String YoN = "no";
        {
            System.out.println("yes\n" + "no\n");
            YoN = sc.next();
            switch (YoN)
            {
                case "no": break;
                case "yes": ConnectToPostgreSQL(); break;
            }
        }
    }
}
