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
	<p>Znalazłeś w ścianie ukryty zamek do klucza!</br>
		You found a hidden keyhole in the wall!</p>
	<img src="IMG/ukrytyzamek_luq2-mystere.jpg" alt="ukrytyzamek_luq2-mystere" usemap='#first_key'/></br>

	<map name="first_key">
		<area shape="rect" coords="225,360,337,554" href="H_ZamknietePudelko.php" />
	</map>

	</div>
</body>

</html>
