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
		<p>Witaj w grze click&point 'luq2 mystere'</br>Welcome to 'luq2 mystere' click&point game!</p>
		<p>Musisz znaleźć 2 klucze, a następnie ukrytą skrytkę!</br>
			You have to find 2 keys, and then hidden stash!</p>

		<?php
			if (isset($_GET['x']))
				$x = $_GET['x'];
			else
				$x = 0;
			if ($x==2)
				echo "<img src='IMG/pokoj_luq2-mystere.jpg' alt='   ' usemap='#click&point_2' />";
			elseif ($x==1)
				echo "<img src='IMG/pokoj_luq2-mystere.jpg' alt='   ' usemap='#click&point_1' />";
			else
				echo "<img src='IMG/pokoj_luq2-mystere.jpg' alt='   ' usemap='#click&point' />";
		?>

		<map name="click&point">
			<area shape="rect" coords="506,262,391,58" href="C_OknoNr1.php" />
			<area shape="rect" coords="896,292,701,34" href="D_OknoNr2.php" />
			<area shape="circle" coords="876,521,30" href="E_Dokumenty.php" />
		</map>

		<map name="click&point_1">
			<area shape="rect" coords="506,262,391,58" href="C_OknoNr1.php" />
			<area shape="rect" coords="896,292,701,34" href="D_OknoNr2.php" />
			<area shape="circle" coords="177,513,14" href="F_GalazkaSwierku.php" />
		</map>

		<map name="click&point_2">
			<area shape="rect" coords="506,262,391,58" href="C_OknoNr1.php" />
			<area shape="rect" coords="896,292,701,34" href="D_OknoNr2.php" />
			<area shape="poly" coords="83,253,106,262,108,283,100,283,93,283,90,278,83,267" href="G_UkrytyZamek.php" />
		</map>

		<table cellspacing="0">
			<tr><td>
			<?php
				if ($x==1 || $x==2) echo "<img class='thumb' src='IMG/dokumenty_luq2-mystere' alt='dokumenty_luq2-mystere' />";
			?>
			</td><td>
			<?php
				if ($x==1 || $x==2) echo "<img class='thumb' src='IMG/klucz1_luq2-mystere.jpg' alt='klucz1_luq2-mystere' />";
			?>
			</td><td>
			<?php
			if ($x==2) echo "<img class='thumb' src='IMG/swierkgalazka_luq2-mystere.jpg' alt='swierkgalazka_luq2-mystere' />";
			?>
			</td><td>
			<?php
			if ($x==2) echo "<img class='thumb' src='IMG/klucz2_luq2-mystere.jpg' alt='klucz2_luq2-mystere' />";
			?>
			</td><td></td><td></td></tr>
		</table>

		<a href="A_RozpocznijGre.php">[POWTÓRZ / RESTART]</br> Rozpocznij grę od nowa...</br>
		Restart the game...</a>

	</div>

</body>

</html>
