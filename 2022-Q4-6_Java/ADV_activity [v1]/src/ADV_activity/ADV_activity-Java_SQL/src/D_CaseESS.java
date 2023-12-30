import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class D_CaseESS
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    // Łukasz Tworzydło - nr albumu: gd29623 [projekt zaliczeniowy]
    // Informatyka, grupa laboratoryjna: INiS3_PR2.2
    // [Programowanie w języku JAVA & Bazy danych]
    // <<< niniejszy program składa się z 6 obiektów >>>
    //
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public static void ADVPublishing_JustTravelToday()  // case no 8
    {
        System.out.println("\n=> ADV Publishing & Just Travel Today:\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c8 = con.createStatement();

            ResultSet lc_8a = stmt_c8.executeQuery("SELECT adv_websites.nazwa_strony, adv_websites.strona_www FROM adv_websites\n" +
                    "WHERE (adv_websites.nazwa_strony = 'ADV Publishing' OR adv_websites.nazwa_strony = 'Just Travel Today')");
            while(lc_8a.next()) System.out.println(lc_8a.getString(1)); // wyświetlenie nazw stron internetowych

            ResultSet lc_8b= stmt_c8.executeQuery("SELECT adv_websites.nazwa_strony, adv_websites.strona_www FROM adv_websites\n" +
                    "WHERE (adv_websites.nazwa_strony = 'ADV Publishing' OR adv_websites.nazwa_strony = 'Just Travel Today')");
            while(lc_8b.next()) System.out.println(lc_8b.getString(2)); // wyświetlenie odnośników do stron www

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
    public static void Type_NameOfAWebsite() // case no 7
    {
        System.out.println("\n=> Rodzaje i nazwy stron internetowych:\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c7 = con.createStatement();

            ResultSet lc_7a = stmt_c7.executeQuery("SELECT adv_websites.rodzaj_strony, adv_websites.nazwa_strony FROM adv_websites");
            while(lc_7a.next()) System.out.println("* " + lc_7a.getString(1)); // wyświetlenie nazw stron internetowych
            System.out.println();
            ResultSet lc_7b = stmt_c7.executeQuery("SELECT adv_websites.rodzaj_strony, adv_websites.nazwa_strony FROM adv_websites");
            while(lc_7b.next()) System.out.println("* " + lc_7b.getString(2)); // wyświetlenie odnośników do stron www

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }

    public static void Website_TravelVideos() // case no 6
    {
        System.out.println("\n=> Strona i filmiki podróżnicze [Just Travel Today]:\n");

        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

            Statement stmt_c6 = con.createStatement();

            ResultSet lc_6a = stmt_c6.executeQuery("SELECT adv_websites.nazwa_strony, adv_travel.nazwa_filmu, adv_travel.www_youtube FROM\n" +
                    "adv_websites JOIN adv_travel ON adv_websites.nazwa_strony = adv_travel.nazwa_kanalu");
            while(lc_6a.next()) System.out.println("a) " + lc_6a.getString(1)); // wyświetlenie nazwy strony podróżniczej
            System.out.println();
            ResultSet lc_6b = stmt_c6.executeQuery("SELECT adv_websites.nazwa_strony, adv_travel.nazwa_filmu, adv_travel.www_youtube FROM\n" +
                    "adv_websites JOIN adv_travel ON adv_websites.nazwa_strony = adv_travel.nazwa_kanalu");
            while(lc_6b.next()) System.out.println("b) " + lc_6b.getString(2)); // wyświetlenie nazwy filmu podróżniczego
            System.out.println();
            ResultSet lc_6c = stmt_c6.executeQuery("SELECT adv_websites.nazwa_strony, adv_travel.nazwa_filmu, adv_travel.www_youtube FROM\n" +
                    "adv_websites JOIN adv_travel ON adv_websites.nazwa_strony = adv_travel.nazwa_kanalu");
            while(lc_6c.next()) System.out.println("c) " + lc_6c.getString(3)); // wyświetlenie odnośniku do filmu podróżniczego

        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}
