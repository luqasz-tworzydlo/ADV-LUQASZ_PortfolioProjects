import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

public class B_Records
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    // Łukasz Tworzydło - nr albumu: gd29623 [projekt zaliczeniowy]
    // Informatyka, grupa laboratoryjna: INiS3_PR2.2
    // [Programowanie w języku JAVA & Bazy danych]
    // <<< niniejszy program składa się z 6 obiektów >>>
    //
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public static void AddNewRecords_17() throws Exception
    {

        // odniesienie do lokalnej bazy danych [XAMPP]
        // oraz wywołanie bazy danych '5_adv_activity'
        Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection(
                "jdbc:mysql://localhost:3306/5_adv_activity", "root", "");

        // dodanie nowego rekordu do tabeli 'adv_books' [1.1]
        PreparedStatement stmt1 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");
        ((PreparedStatement)stmt1).setString(1, "muzyczna"); stmt1.setString(2, "Łukasz Wojciech M. Tworzydło");
        stmt1.setString(3, "2018"); stmt1.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_books' [1.2]
        PreparedStatement stmt2 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");
        ((PreparedStatement)stmt2).setString(1, "edukacyjna"); stmt2.setString(2, "Łukasz Wojciech M. Tworzydło");
        stmt2.setString(3, "2019"); stmt2.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_books' [1.3]
        PreparedStatement stmt3 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");
        ((PreparedStatement)stmt3).setString(1, "naukowa"); stmt3.setString(2, "Łukasz Wojciech M. Tworzydło");
        stmt3.setString(3, "2019"); stmt3.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_books' [1.4]
        PreparedStatement stmt4 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");
        ((PreparedStatement)stmt4).setString(1, "religijna"); stmt4.setString(2, "Łukasz Wojciech M. Tworzydło");
        stmt4.setString(3, "2019"); stmt4.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_books' [1.5]
        PreparedStatement stmt5 = con.prepareStatement("INSERT INTO adv_books (rodzaj_ksiazki, autor, rok_rozpoczecia) VALUES (?, ?, ?)");
        ((PreparedStatement)stmt5).setString(1, "projektowa"); stmt5.setString(2, "Łukasz Wojciech M. Tworzydło");
        stmt5.setString(3, "2019"); stmt5.executeUpdate();

        // dodanie nowego rekordu do tabeli 'adv_websites' [2.1]
        PreparedStatement stmt6 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt6).setString(1, "ADV Publishing"); stmt6.setString(2, "wydawnicza");
        stmt6.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt6.setString(4,"https://advpublishing.wordpress.com/"); stmt6.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.2]
        PreparedStatement stmt7 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt7).setString(1, "Just Travel Today"); stmt7.setString(2, "podróżnicza");
        stmt7.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt7.setString(4,"https://just-travel-today.com/"); stmt7.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.3]
        PreparedStatement stmt8 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt8).setString(1, "AVANT DE VENIR"); stmt8.setString(2, "muzyczna");
        stmt8.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt8.setString(4,"https://avantdevenir.wordpress.com/"); stmt8.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.4]
        PreparedStatement stmt9= con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt9).setString(1, "Edukacja Kreacja"); stmt9.setString(2, "edukacyjna");
        stmt9.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt9.setString(4,"https://edukacjakreacja.wordpress.com/"); stmt9.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.5]
        PreparedStatement stmt10 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt10).setString(1, "Wiedza Przyszłości"); stmt10.setString(2, "naukowa");
        stmt10.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt10.setString(4,"https://wiedzaprzyszlosci.wordpress.com/"); stmt10.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.6]
        PreparedStatement stmt11 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt11).setString(1, "Projekty AD"); stmt11.setString(2, "projektowa");
        stmt11.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt11.setString(4,"https://projektyad.wordpress.com/"); stmt11.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_websites' [2.7]
        PreparedStatement stmt12 = con.prepareStatement("INSERT INTO adv_websites (nazwa_strony, rodzaj_strony, tworca_strony, strona_www) VALUES (?, ?, ?, ?)");
        ((PreparedStatement)stmt12).setString(1, "Sacris Coelum"); stmt12.setString(2, "religijna");
        stmt12.setString(3, "Łukasz Wojciech M. Tworzydło"); stmt12.setString(4,"https://sacriscoelum.wordpress.com/"); stmt12.executeUpdate();

        // dodanie nowego rekordu do tabeli 'adv_travel' [3.1]
        PreparedStatement stmtA = con.prepareStatement("INSERT INTO adv_travel (kraj, nazwa_filmu, tworca, nazwa_kanalu, www_youtube) VALUES (?, ?, ?, ?, ?)");
        ((PreparedStatement)stmtA).setString(1, "Israel & Jordan"); stmtA.setString(2, "Let's start our journey!");
        stmtA.setString(3, "JustTravelToday & luqastro :>"); stmtA.setString(4,"Just Travel Today");
        stmtA.setString(5,"https://youtu.be/g6kZjtrKQtw"); stmtA.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_travel' [3.2]
        PreparedStatement stmtB = con.prepareStatement("INSERT INTO adv_travel (kraj, nazwa_filmu, tworca, nazwa_kanalu, www_youtube) VALUES (?, ?, ?, ?, ?)");
        ((PreparedStatement)stmtB).setString(1, "Israel & Jordan"); stmtB.setString(2, "The Holy Land, and even more!");
        stmtB.setString(3, "JustTravelToday & luqastro :>"); stmtB.setString(4,"Just Travel Today");
        stmtB.setString(5,"https://youtu.be/-yAXYJTpksU"); stmtB.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_travel' [3.3]
        PreparedStatement stmtC = con.prepareStatement("INSERT INTO adv_travel (kraj, nazwa_filmu, tworca, nazwa_kanalu, www_youtube) VALUES (?, ?, ?, ?, ?)");
        ((PreparedStatement)stmtC).setString(1, "Israel"); stmtC.setString(2, "Let’s drive together!");
        stmtC.setString(3, "JustTravelToday & luqastro :>"); stmtC.setString(4,"Just Travel Today");
        stmtC.setString(5,"https://youtu.be/5DdLthH5ivg"); stmtC.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_travel' [3.4]
        PreparedStatement stmtD = con.prepareStatement("INSERT INTO adv_travel (kraj, nazwa_filmu, tworca, nazwa_kanalu, www_youtube) VALUES (?, ?, ?, ?, ?)");
        ((PreparedStatement)stmtD).setString(1, "Israel"); stmtD.setString(2, "Driving through Israel… breathtaking views!");
        stmtD.setString(3, "JustTravelToday & luqastro :>"); stmtD.setString(4,"Just Travel Today");
        stmtD.setString(5,"https://youtu.be/bwnLhjKIdcc"); stmtD.executeUpdate();
        // dodanie nowego rekordu do tabeli 'adv_travel' [3.5]
        PreparedStatement stmtE = con.prepareStatement("INSERT INTO adv_travel (kraj, nazwa_filmu, tworca, nazwa_kanalu, www_youtube) VALUES (?, ?, ?, ?, ?)");
        ((PreparedStatement)stmtE).setString(1, "Israel & Jordan"); stmtE.setString(2, "The Last Expedition!");
        stmtE.setString(3, "JustTravelToday & luqastro :>"); stmtE.setString(4,"Just Travel Today");
        stmtE.setString(5,"https://youtu.be/BhQvj6F6Wk4"); stmtE.executeUpdate();
    }
}
