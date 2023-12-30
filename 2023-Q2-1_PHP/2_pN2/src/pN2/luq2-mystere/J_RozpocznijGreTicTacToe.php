<!DOCTYPE HTML>

<!--
//////////////////////////////////////////////////
//
// => Imię i nazwisko: Łukasz Tworzydło
// => Numer albumu: gd29623
// => Nr. kierunku: INIS4_PR2.2
// => Przedmiot: Zaawansowane technologie internetowe
//
//////////////////////////////////////////////////
//
// niniejszy projekt zawiera w sobie dwie gry, z czego
// główną grą jest gra typu click and point, zaś
// na końcu w nagrodę jest gra kółko i krzyżyk
//
// cały projekt składa się z 10 plików [9 plików .php i 1 plik .css]
// (pliki to: A_RozpocznijGre.php, B_TloGry-styl.css, C_OknoNr1.php, D_OknoNr2.php,
// E_Dokumenty.php, F_GalazkaSwierku.php, G_UkrytyZamek.php, H_ZamknietePudelko.php,
// I_KolkoiKrzyzykTicTacToe.php, jak i również plik J_RozpocznijGreTicTacToe.php)
// oraz 12 wybranych oraz odpowiednio edytowanych zdjęć do gry click&point
//
//////////////////////////////////////////////////
//
// Łukasz Tworzydło - nr albumu: gd29623 [projekt zaliczeniowy]
//
//////////////////////////////////////////////////
-->

<html>

<head>
	<link href="B_TloGry-styl.css" rel="stylesheet" type="text/css">
</head>

<style>
table {
    border: 1px solid grey;
    color: blue;
    font-weight: bold;
    font-size: 250px;
}

td {
    border: 1px solid black;
    width: 50px;
    height: 50px;
    text-align: center;
}
</style>

<body>
	<div id="main">

	<?php
	session_start();

	$plansza = isset($_SESSION['plansza']) ? $_SESSION['plansza'] :
	    array(
	        '---', '---', '---',
	        '---', '---', '---',
	        '---', '---', '---'
	    );

	$gracz = isset($_SESSION['gracz']) ? $_SESSION['gracz'] : 'O';

	function printplansza($plansza)
	{
	    echo "<table>\n";
	    for ($i = 0; $i < 9; $i += 3)
	    {
	        echo "<tr>\n";
	        printf("<td><a href='?ruch=%d'>%s</a></td>\n", $i, $plansza[$i]);
	        printf("<td><a href='?ruch=%d'>%s</a></td>\n", $i + 1, $plansza[$i + 1]);
	        printf("<td><a href='?ruch=%d'>%s</a></td>\n", $i + 2, $plansza[$i + 2]);
	        echo "</tr>\n";
	    }
	    echo "</table>\n";
	}

	function wykonaj_ruch($plansza, $gracz, $ruch)
	{
	    if ($plansza[$ruch] == '---')
	    {
	        $plansza[$ruch] = $gracz;
	    }
	    return $plansza;
	}

	function sprawdz_wygrana($plansza, $gracz)
	{
	    for ($i = 0; $i < 9; $i += 3)
	    {
	        if ($plansza[$i] == $gracz && $plansza[$i + 1] == $gracz && $plansza[$i + 2] == $gracz)
	        {
	            return true;
	        }
	    }

	    for ($i = 0; $i < 3; $i++)
	    {
	        if ($plansza[$i] == $gracz && $plansza[$i + 3] == $gracz && $plansza[$i + 6] == $gracz)
	        {
	            return true;
	        }
	    }

	    if ($plansza[0] == $gracz && $plansza[4] == $gracz && $plansza[8] == $gracz)
	    {
	        return true;
	    }

	    if ($plansza[2] == $gracz && $plansza[4] == $gracz && $plansza[6] == $gracz)
	    {
	        return true;
	    }

	    return false;
	}

	if (isset($_GET['ruch']))
	{
	    $ruch = intval($_GET['ruch']);
	    if ($gracz == 'O') {
	        $plansza = wykonaj_ruch($plansza, $gracz, $ruch);
	        $_SESSION['plansza'] = $plansza;

	        if (sprawdz_wygrana($plansza, $gracz))
	        {
	            echo "Gratulacje! Pokonałeś komputer! Wygrałeś jako $gracz!";
							echo "<br/>";
							echo "Congratulations! You beat the computer! You won as $gracz!";
							echo "<br/></br>";

							echo '<a href="A_RozpocznijGre.php">[POWTÓRZ / RESTART]
							</br> Rozpocznij grę od nowa...</br> Restart the game...</a>';

	            session_destroy();
	            exit();
	        }

	        $gracz = 'X';
	    }

	    if (in_array('---', $plansza) === true && $gracz == 'X') {
	        $pustaKomorka = array_keys($plansza, '---');
	        if (count($pustaKomorka) > 0) {
	            $losowyIndeksKomorki = array_rand($pustaKomorka);
	            $losowaKomorka = $pustaKomorka[$losowyIndeksKomorki];
	            $plansza = wykonaj_ruch($plansza, $gracz, $losowaKomorka);
	            $_SESSION['plansza'] = $plansza;

	            if (sprawdz_wygrana($plansza, $gracz))
	            {
	                echo "Przegrałeś! Wygrał komputer jako $gracz!";
									echo "<br/>";
									echo "You lost! The computer player won as $gracz!";
									echo "<br/></br>";

									echo '<a href="A_RozpocznijGre.php">[POWTÓRZ / RESTART]
									</br> Rozpocznij grę od nowa...</br> Restart the game...</a>';

	                session_destroy();
	                exit();
	            }
	        }

	        $gracz = 'O';
	    }

	    $_SESSION['gracz'] = $gracz;
	}

	printplansza($plansza);

	if (in_array('---', $plansza) === false)
	{
	    echo "<br/>";
	    echo "Gratulacje! Masz remis! :P";

			echo "<br/></br>";

			echo '<a href="A_RozpocznijGre.php">[POWTÓRZ / RESTART]
			</br> Rozpocznij grę od nowa...</br> Restart the game...</a>';

	    session_destroy();
	    exit();
	}

	if (in_array('---', $plansza) === true && $gracz == 'O')
	{
	    echo "<br/>";
	    # echo "Kolejny ruch ma $gracz!";
			echo "Teraz Twój ruch!";
	}
	?>

</div>
</body>

</html>
