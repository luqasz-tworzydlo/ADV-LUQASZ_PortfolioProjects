import java.sql.Connection;
import java.sql.DriverManager;
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

public class Main {
    public static void main(String[] args) {
        Menu.ConnectToPostgreSQL();
    }
}
