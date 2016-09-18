## Tömbök
A tömb értékek gyűjteménye, amelyek egymást követik a memóriában.
Fő használati területe több azonos típusú adat tárolása, egy változó segítségével.

Nézzük meg a [mellékelt példakódot](./Yellowroad.Array/Theory/ArrayUseCases.cs)! A két függvény ugyanazt a problémát oldja meg, de míg tömbök nélkül hat változót kell deklarálnunk és karbantartanunk, addig tömbök segítségével mindössze egyet.

#### [Tömbök példányosítása](./Yellowroad.Array/Theory/Instantiation.cs)
Tömböket többféle módon hozhatunk létre. Amire mindenképp szükségünk lesz a létrehozáshoz, az:
- A tömb típusa
- A hossza (hány elemet tervezünk benne tárolni)

Mint megszokhattuk már, a C# erősen típusos nyelv, így minden változónknak meg kell adjuk, milyen típust akarunk tárolni benne. A tömbök esetében ez a tömbben tárolt adatok típusát jelenti. Nem lehetséges többféle típust tárolni egy tömbben.
A tömb hossza szintén egy olyan paraméter, amit JavaScriptben nem kellett megadnunk, a C# fordítónak viszont szüksége van rá. Ez azt is jelenti, hogy ha több adatot szeretnénk tárolni, mint amennyi fér a tömbbe, akkor a keretrendszer hibát fog dobni.
 
#### [Elemek kezelése](./Yellowroad.Array/Theory/Elements.cs)
A tömbök egyes elemeihez ún. indexerrel férünk hozzá. Ennek szintaktikája megegyezik a JS-ben tanultakkal, a `[]` operátorral történik.
A C# tömbök 0-tól indexelődnek, és a tömb hossza - 1 elem lesz az utolsó bennük.
Minden tömbnek van hossza, amit a `Length` propertyvel érhetünk el.
Amennyiben túllépnénk a tömb határain (pl. a mínusz egyedik elemet akarjuk lekérni) a rendszer kivételt fog dobni.

#### Dokumentáció
https://msdn.microsoft.com/en-us/library/system.array(v=vs.110).aspx

#### Gyakorló feladatok
[Visual Studio Project](./Yellowroad.Array/Tasks) 