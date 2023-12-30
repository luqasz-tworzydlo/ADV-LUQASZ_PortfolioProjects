import java.util.Scanner;

public class C_Menu
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    // Łukasz Tworzydło - nr albumu: gd29623 [projekt zaliczeniowy]
    // Informatyka, grupa laboratoryjna: INiS3_PR2.2
    // [Programowanie w języku JAVA & Bazy danych]
    // <<< niniejszy program składa się z 6 obiektów >>>
    //
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    static Scanner sc = new Scanner(System.in);
    public static void adv_activity_menu() // menu of the software
    {
        System.out.println();

        var option_number =-1;
        System.out.println("1. Dodaj nowy rekord do bazy danych do tabeli 'adv_books'");
        System.out.println("2. Usuń wybrany rekord z tabeli 'adv_books' z bazy danych [niedostępne]");
        System.out.println("3. Wybierz i wyświetl początki publikacji z książek dla 2018 lub 2019 roku");
        System.out.println("4. Wyświetl początki publikacji wszystkich rodzajów książek z roku 2018 i 2019");
        System.out.println("5. Wyświetl rodzaj ksiązki, jej początki, nazwę strony i odnośnik do strony www");
        System.out.println("6. Wyświetl stronę i filmiki podróżnicze [Just Travel Today]");
        System.out.println("7. Wyświetl wszystkie rodzaje oraz nazwy stron internetowych");
        System.out.println("8. Wyświetl stronę wydawnictwa ADV Publishing oraz blog podróżniczy Just Travel Today");
        System.out.println("9. Wpisz wartość 9, aby zakończyć program");
        System.out.println();
        option_number = sc.nextInt();
        switch (option_number) {
            default:
                option_number = 9;
                break;
            case 8:
                D_CaseESS.ADVPublishing_JustTravelToday();
                StartAgain();
                break;
            case 7:
                D_CaseESS.Type_NameOfAWebsite();
                StartAgain();
                break;
            case 6:
                D_CaseESS.Website_TravelVideos();
                StartAgain();
                break;
            case 5:
                E_CaseFF.Type_Since_Name_URL();
                break;
            case 4:
                E_CaseFF.TheBeginning();
                StartAgain();
                break;
            case 3:
                F_CaseTWO.F18_F19();
                StartAgain();
                break;
            case 2:
                F_CaseTWO.DeleteARecord();
                StartAgain();
                break;
            case 1:
                F_CaseTWO.AddARecord();
                StartAgain();
                break;
        }
    }
    public static void StartAgain() // restart a software
    {
        System.out.println("\n=> Rozpocząć ponownie działanie programu?");
        String YoN = "nie";
        {
            System.out.println("tak");
            System.out.println("nie");
            System.out.println();
            YoN = sc.next();
            switch (YoN)
            {
                case "nie": break;
                case "tak": adv_activity_menu(); break;
            }
        }
    }
}
