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

<body>
	<div id="main">
	<p>W pudełku znalazłeś planszę do gry w kółko i krzyżyk!</br>
		Wyjątkową planszę, bo gdy wykonasz ruch</br> to następny wykonuje ona sama!</br></br>
		In the box, you found a tic-tac-toe game board! A unique board!<br>
		When you make a move, it makes the next one by itself!</p>
	<img src="IMG/grakolkoikrzyzyk_luq2-mystere.jpg" alt="grakolkoikrzyzyk_luq2-mystere" usemap='#tictactoe'/></br>

	<map name="tictactoe">
		<area shape="poly" coords="82,777,779,781,778,88,93,90" href="J_RozpocznijGreTicTacToe" />
	</map>

	<p>Kliknij na planszę, aby rozpocząć grę Kółko i Krzyżyk!</br>
		Click on the board to start the Tic Tac Toe game!</p>

	</div>
</body>

</html>
