import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Scanner;

public class E_CaseFF
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
    public static void Type_Since_Name_URL() // case no 5 [main]
    {
        System.out.println("\n=> Wybierz numer od 1 do 5 w celu wybrania rodzaju ksiązki, aby wyświetlić" +
                "\n   jej nazwę, początki, nazwę strony i odnośnik do strony www:\n");
        var option_case = 0;
        {
            System.out.println("0. Wybierz 0, aby zresetować program");
            System.out.println("1. Wybierz i wyświetl rodzaj 'muzyczna'");
            System.out.println("2. Wybierz i wyświetl rodzaj 'edukacyjna'");
            System.out.println("3. Wybierz i wyświetl rodzaj 'naukowa'");
            System.out.println("4. Wybierz i wyświetl rodzaj 'religijna'");
            System.out.println("5. Wybierz i wyświetl rodzaj 'projektowa'");
            System.out.println();
            option_case = sc.nextInt();
            switch (option_case)
            {
                default: option_case = 0; C_Menu.StartAgain(); break;
                case 1: muzyczna(); C_Menu.StartAgain(); break;
                case 2: edukacyjna(); C_Menu.StartAgain(); break;
                case 3: naukowa(); C_Menu.StartAgain(); break;
                case 4: religijna(); C_Menu.StartAgain(); break;
                case 5: projektowa(); C_Menu.StartAgain(); break;
            }
        }
    }
    public static  void muzyczna() // case no 5.1
    {
        System.out.println();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c5c1 = con.createStatement();

            ResultSet lc_5c1a = stmt_c5c1.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'muzyczna' AND adv_websites.rodzaj_strony = 'muzyczna'");
            while(lc_5c1a.next()) System.out.println("-> rodzaj: " + lc_5c1a.getString(1)); // wyświetlenie rodzaju ksiązki

            ResultSet lc_5c1b = stmt_c5c1.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'muzyczna' AND adv_websites.rodzaj_strony = 'muzyczna'");
            while(lc_5c1b.next()) System.out.println("-> początki: " + lc_5c1b.getString(2)); // wyświetlenie roku rozpoczęcia

            ResultSet lc_5c1c = stmt_c5c1.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'muzyczna' AND adv_websites.rodzaj_strony = 'muzyczna'");
            while(lc_5c1c.next()) System.out.println("-> nazwa strony: " + lc_5c1c.getString(3)); // wyświetlenie nazwy strony internetowej

            ResultSet lc_5c1d = stmt_c5c1.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'muzyczna' AND adv_websites.rodzaj_strony = 'muzyczna'");
            while(lc_5c1d.next()) System.out.println("-> odnośnik do strony: " + lc_5c1d.getString(4)); // wyświetlenie odnośnika do strony internetowej
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void edukacyjna() // case no 5.2
    {
        System.out.println();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c5c2 = con.createStatement();

            ResultSet lc_5c2a = stmt_c5c2.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'edukacyjna' AND adv_websites.rodzaj_strony = 'edukacyjna'");
            while(lc_5c2a.next()) System.out.println("-> rodzaj: " + lc_5c2a.getString(1)); // wyświetlenie rodzaju ksiązki

            ResultSet lc_5c2b = stmt_c5c2.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'edukacyjna' AND adv_websites.rodzaj_strony = 'edukacyjna'");
            while(lc_5c2b.next()) System.out.println("-> początki: " + lc_5c2b.getString(2)); // wyświetlenie roku rozpoczęcia

            ResultSet lc_5c2c = stmt_c5c2.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'edukacyjna' AND adv_websites.rodzaj_strony = 'edukacyjna'");
            while(lc_5c2c.next()) System.out.println("-> nazwa strony: " + lc_5c2c.getString(3)); // wyświetlenie nazwy strony internetowej

            ResultSet lc_5c2d = stmt_c5c2.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'edukacyjna' AND adv_websites.rodzaj_strony = 'edukacyjna'");
            while(lc_5c2d.next()) System.out.println("-> odnośnik do strony: " + lc_5c2d.getString(4)); // wyświetlenie odnośnika do strony internetowej
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void naukowa() // case no 5.3
    {
        System.out.println();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c5c3 = con.createStatement();

            ResultSet lc_5c3a = stmt_c5c3.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'naukowa' AND adv_websites.rodzaj_strony = 'naukowa'");
            while(lc_5c3a.next()) System.out.println("-> rodzaj: " + lc_5c3a.getString(1)); // wyświetlenie rodzaju ksiązki

            ResultSet lc_5c3b = stmt_c5c3.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'naukowa' AND adv_websites.rodzaj_strony = 'naukowa'");
            while(lc_5c3b.next()) System.out.println("-> początki: " + lc_5c3b.getString(2)); // wyświetlenie roku rozpoczęcia

            ResultSet lc_5c3c = stmt_c5c3.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'naukowa' AND adv_websites.rodzaj_strony = 'naukowa'");
            while(lc_5c3c.next()) System.out.println("-> nazwa strony: " + lc_5c3c.getString(3)); // wyświetlenie nazwy strony internetowej

            ResultSet lc_5c3d = stmt_c5c3.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'naukowa' AND adv_websites.rodzaj_strony = 'naukowa'");
            while(lc_5c3d.next()) System.out.println("-> odnośnik do strony: " + lc_5c3d.getString(4)); // wyświetlenie odnośnika do strony internetowej
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void religijna() // case no 5.4
    {
        System.out.println();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c5c4 = con.createStatement();

            ResultSet lc_5c4a = stmt_c5c4.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'religijna' AND adv_websites.rodzaj_strony = 'religijna'");
            while(lc_5c4a.next()) System.out.println("-> rodzaj: " + lc_5c4a.getString(1)); // wyświetlenie rodzaju ksiązki

            ResultSet lc_5c4b = stmt_c5c4.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'religijna' AND adv_websites.rodzaj_strony = 'religijna'");
            while(lc_5c4b.next()) System.out.println("-> początki: " + lc_5c4b.getString(2)); // wyświetlenie roku rozpoczęcia

            ResultSet lc_5c4c = stmt_c5c4.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'religijna' AND adv_websites.rodzaj_strony = 'religijna'");
            while(lc_5c4c.next()) System.out.println("-> nazwa strony: " + lc_5c4c.getString(3)); // wyświetlenie nazwy strony internetowej

            ResultSet lc_5c4d = stmt_c5c4.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'religijna' AND adv_websites.rodzaj_strony = 'religijna'");
            while(lc_5c4d.next()) System.out.println("-> odnośnik do strony: " + lc_5c4d.getString(4)); // wyświetlenie odnośnika do strony internetowej
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void projektowa() // case no 5.5
    {
        System.out.println();
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c5c5 = con.createStatement();

            ResultSet lc_5c5a = stmt_c5c5.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'projektowa' AND adv_websites.rodzaj_strony = 'projektowa'");
            while(lc_5c5a.next()) System.out.println("-> rodzaj: " + lc_5c5a.getString(1)); // wyświetlenie rodzaju ksiązki

            ResultSet lc_5c5b = stmt_c5c5.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'projektowa' AND adv_websites.rodzaj_strony = 'projektowa'");
            while(lc_5c5b.next()) System.out.println("-> początki: " + lc_5c5b.getString(2)); // wyświetlenie roku rozpoczęcia

            ResultSet lc_5c5c = stmt_c5c5.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'projektowa' AND adv_websites.rodzaj_strony = 'projektowa'");
            while(lc_5c5c.next()) System.out.println("-> nazwa strony: " + lc_5c5c.getString(3)); // wyświetlenie nazwy strony internetowej

            ResultSet lc_5c5d = stmt_c5c5.executeQuery("SELECT adv_books.rodzaj_ksiazki, adv_books.rok_rozpoczecia, adv_websites.nazwa_strony,\n" +
                    "adv_websites.strona_www FROM adv_books JOIN adv_websites ON adv_books.autor = adv_websites.tworca_strony\n" +
                    "WHERE adv_books.rodzaj_ksiazki = 'projektowa' AND adv_websites.rodzaj_strony = 'projektowa'");
            while(lc_5c5d.next()) System.out.println("-> odnośnik do strony: " + lc_5c5d.getString(4)); // wyświetlenie odnośnika do strony internetowej
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void TheBeginning() // case no 4
    {
        System.out.println("\n=> Początki publikacji wszystkich rodzajów książek z roku 2018 i 2019:\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c4 = con.createStatement();

            ResultSet lc_4a = stmt_c4.executeQuery("SELECT rodzaj_ksiazki, rok_rozpoczecia FROM adv_books");
            while(lc_4a.next()) System.out.println("-> rodzaj: " + lc_4a.getString(1)); // wyświetlenie wszystkich rodzajów książek
            System.out.println();
            ResultSet lc_4b = stmt_c4.executeQuery("SELECT rodzaj_ksiazki, rok_rozpoczecia FROM adv_books");
            while(lc_4b.next()) System.out.println("-> początki: " + lc_4b.getString(2)); // wyświetlenie początków danych rodzajów

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}
