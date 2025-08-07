Ez a DIA hivatalos tesztelési útmutatója.

A teszt alatt minden funkciót kipróbálhatunk a dia-ban és ellenőrízhetjük azok
helyes működését.

--------------/ Követelmények /--------------

Az adatbázist a helyi hálózaton kell futtatni jelszó nélkül!
A számítógépen lennie kell .NET 5-ös vagy újabb keretrendszernek!


--------------/ Fiókok /--------------

A programban már létre vannak hozva felhasználók:
Diák fiókok: antald, bagom, baloghm, becst, czapkoa, domnanob, giglerk, kocsism, mudrab, nemethd, nemethg, simonp, szakacsg, takacsg
Tanár fiókok: BalicsG, NagyE, VargaG

Mindegyik felhasználó jelszava az "Asd123"!

Az admin fiokba az "admin" - "admin" felhasználónév és jelszó párossal léphetünk be!

A programban már vannak létrehozva dolgozatok is a többrétű tesztelés érdekében. Ehez a BalicsG tanári fiókba kell belépnünk.
A már létrehozott dolgozatokat pedig a domnanob fiokban nézhetjük/írhatjuk meg.

--------------/ Tesztelés /--------------

!!! A teljeskörű tesztelésért és élményért ajánlom az opcionális pontokat is végrehajtani !!!

(i) - fontos, (o) - opcionális, (p) - személyre szabható

1. Lépjünk be az admin fiókba! (i)
	1.1 Gépeljük el a jelszavát (o)
	1.2 Gépeljük el a felhasználónevet (o)
	1.2 A szem ikonra kattintva jelenítsük meg a jelszavat (o)
2. A Tanárok menüpontban lévő "új" gombra kattintva hozzunk létre egy tanár fiókot! (i)
	2.1 A felhasználóneve legyen TT jelszava direkt elgépelve legyen "Asd1234" (i)(p)
3. Az új tanárra duplán kattintva vagy a szerkesztés gombra menve lépjünk be a szerketsztés felületre! (i)
	3.1 Változtassuk meg a jelszavát "Asd123"-ra (o)(p)
	3.2 Változtassuk meg a teljes nevét és email címét (o)
	3.2 Adjunk hozzá egy osztályt és tantárgyat ahol taníthat a tanár (akár többet is lehet) (i)
4. Az osztályok menüben hozzunk létre egy új osztályt! (p)
	4.1 Szerkesszük az osztály nevét (o)
5. Hozzunk létre egy új tantárgyat! (p)
	5.1 Szerkesszük a tantárgy nevét (o)
6. Adjuk hozzá az újonnan létrehozott osztályt és tantárgyat a tanárunk munkaköréhez! (o)
7. A diákok fül alatt hozzunk létre egy új diákot! (i)
	7.1 Felhasználóneve legyen TD jelszava legyen elgépelve (o)(p)
	7.2 Az osztálya legyen az amit beállítottunk a tanárnak (i)
8. Szerkesszük az újonnan létrehozott diák adatait!
	7.1 Változtassuk meg a jelszavát (o)(p)
	7.2 Változtassuk meg a teljes nevét és email címét (o)(p)
9. Állítsunk be egy feljhasználót deaktivált állapotúra! (i)
10. Jelentkezzünk ki, majd próbáljunk belépni a deaktivált fiókba! (i)
11. Lépjünk be a tanárunk fiókjába! (i)
	11.1 Ellenőrizzük, akár módosítjuk az adatokat a Profil menüben (o)
	11.2 Ellenőrizzük a diákokat a Diákok fülben (itt csak azok a diákok jelenhetnek meg akik abban az osztályban tanulnak ahol tanítunk) (o)
	11.3 Hozzunk létre egy dolgozatot a Dolgozatok menüpont új gombjával (i)(p)
		11.3.1 Legyen legalább 3 kérdés, az első sima 1 helyes válasszal, a következő 2 helyes válasszal az utolsó pedig legalább 4 válaszlehetőséggel (i)(p)
		11.3.2 válasszuk ki azt az osztályt ahol a teszt diák tanul és válasszuk hozzá a tantárgyat is (i)
		11.3.3 Próbáljuk ki mi történik ha egy kérdés, válasz, pontszám, osztály vagy tantárgy mező üres (o)
		11.3.4 !Ha az internet engedélyezését nem pipáljuk be a dolgozat írása alatt nem futhat böngésző! (i)(o)
		11.3.5 Mentsük el a dolgozatot (i)
12. Jelentkezzünk be a teszt diák fiókjába! (i)
	12.1 Ellenőrizzük, módosítjuk a profiladatokat (o)
	12.2 A dologzatok menüben nyissuk meg az általunk kiadott dolgozatokat (i)
		12.2.1 Figyeljük meg hogy a kérdések és a válaszok véletlenszerű sorrendben vannak-e (o)
		12.2.2 Hibázzunk direkt, ahol két megoldás is van ott jelöljünk be csak egy et (i)
		12.2.3 Ha nem engedélyeztünk böngészőt akkor nyissunk meg egyet, ezzel leadjuk a dolgozatot az abbani állapotában (i)
13. Lépjünk vissza a teszt tanár fiókba! (i)
	13.1 Válasszuk ki a dolgozatokban a kiadott tesztet (i)
	13.2 Válasszuk ki a teszt diák dolgozatát (i)
	13.3 "Korrigáljuk ki" az egyik autómatikus javítást (o)
	13.4 Javítsuk ki a feladatsort (a pipákra kötelező rámenni ezzel jelezzük hogy helyes a javítás) (i)
14. Jelentkezzünk vissza a diákba! (i)
	14.1 Nézzük meg a javítást (i)
	14.2 A boltban vásároljunk egy elemet (ha nincs elég pont az admin fiókkal adhatunk neki) (i)
	14.3 Nézzük meg az infó menü tartalmát (o)
15. Térjünk vissza a tanár fiók diákok menüjéhez! (i)
	15.1 Próbáljuk ki a szükítést és a keresést (o)
	15.2 Válasszuk ki és nyissuk meg a teszt diákot (i)
	15.3 módosítsuk a vásárlását (ezzel elhasználta azt) (i)
16. Lépjünk be már meglévő fiókokba és próbálgassuk a program működését! (o)

--------------/ Tesztelés Vége! /--------------

A programot és a hozzátartozó fájlokat Domnánovich Bálint készítette 2022. 04. 01!