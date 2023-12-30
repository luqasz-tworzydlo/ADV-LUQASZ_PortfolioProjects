import java.sql.*;
import java.util.Scanner;

public class F_CaseTWO
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
    public static void F18_F19() // case no 3
    {
        System.out.println("\n=> Wybierz rok, aby zobaczyć początki publikacji" +
                "\n   poszczególnych rodzajów książek dla 2018 lub 2019 roku:\n");
        var option_year = 0;
        {
            System.out.println("0. Zrestartuj program");
            System.out.println("1. Wybierz rok 2018");
            System.out.println("2. Wybierz rok 2019");
            System.out.println();
            option_year = sc.nextInt();
            switch (option_year)
            {
                default: option_year = 0; break;
                case 1: F2018(); break;
                case 2: F2019(); break;
            }
        }
    }
    public static void F2018() // case no 3.1
    {
        System.out.println("\n=> Początki z roku 2018:");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c3 = con.createStatement();

            ResultSet lc_3F1 = stmt_c3.executeQuery("SELECT rodzaj_ksiazki FROM adv_books WHERE rok_rozpoczecia ='2018'");
            while(lc_3F1.next()) System.out.println("-> rodzaj: " + lc_3F1.getString(1)); // wyświetlenie wszystkich rodzajów książek z 2018 roku

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void F2019() // case no 3.2
    {
        System.out.println("\n=> Początki z roku 2019:");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c3 = con.createStatement();

            ResultSet lc_3F2 = stmt_c3.executeQuery("SELECT rodzaj_ksiazki FROM adv_books WHERE rok_rozpoczecia ='2019'");
            while(lc_3F2.next()) System.out.println("-> rodzaj: " + lc_3F2.getString(1)); // wyświetlenie wszystkich rodzajów książek z 2019 roku

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void DeleteARecord() // case no 2
    {
        System.out.println("\n=> Niestety ta funkcja jest obecnie niedostępna :<" +
                "\n   Kontynuuj, aby wrócić do menu oraz wybrać inną opcję");
        System.out.println("\n=> Znaczy się... już nieaktualne ;P" +
                "\n=> Niniejsza funkcja została już wprowadzona ^_^\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            // dodanie nowego, dowolnego rekordu do tabeli 'adv_books'
            PreparedStatement stmtD = con.prepareStatement("DELETE FROM adv_books WHERE rodzaj_ksiazki = ?");

            System.out.println("Wpisz kategorię ksiązek, którą chcesz usunąć [np. muzyczna]");
            String Parameter_Delete;
            Parameter_Delete = sc.next();

            ((PreparedStatement) stmtD).setString(1, Parameter_Delete); // dane do parametru 'rodzaj_ksiazki'
            stmtD.executeUpdate(); // usunięcie wybranego rekordu z tabeli 'adv_books' według parametru 'rodzaj_ksiazki'

            System.out.println("\nGratulacje! Usunąłeś/aś wybrany rekord ( " + Parameter_Delete + " ) z tabeli bazy danych! :>");

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void AddARecord() // case no 1
    {
        System.out.println("\n=> Dodaj nowy rekord do bazy danych, jeden wiersz (krotkę) do tabeli 'adv_books':\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            // dodanie nowego, dowolnego rekordu do tabeli 'adv_books'
            PreparedStatement stmt1 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");

            System.out.println("Wpisz kategorię ksiązek [np. muzyczna]");
            String Parameter1;
            Parameter1 = sc.next();

            System.out.println("Wpisz autora ksiązek [czyli imię + nazwisko]");
            String Parameter2;
            Parameter2 = sc.next();

            System.out.println("Wpisz rok rozpoczęcia niniejszej kategorii książek [np. 2012]");
            String Parameter3;
            Parameter3 = sc.next();

            ((PreparedStatement) stmt1).setString(1, Parameter1); // dane do parametru 'rodzaj_ksiazki'
            stmt1.setString(2, Parameter2); // dane do parametru 'autor'
            stmt1.setString(3, Parameter3); // dane do parametru 'rok_rozpoczecia'
            stmt1.executeUpdate(); // wpisanie nowego rekordu do tabeli

            System.out.println("\nGratulacje! Wprowadziłeś/aś nowy rekord do tabeli bazy danych! :>");

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}
