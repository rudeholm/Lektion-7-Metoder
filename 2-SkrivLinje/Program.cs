/* 2. SkrivLinje [Grön nivå]
Skapa en metod `SkrivAvskiljare()` som skriver ut en dekorativ linje av 30 stycken stjärnor
(******************************) på skärmen för att hjälpa till att strukturera text i konsolen.
Anropa den tre gånger i Main med lite text emellan. */

SkrivAvskiljare();
Console.WriteLine("Lite text...");
SkrivAvskiljare();
Console.WriteLine("Lite mer text...");
SkrivAvskiljare();


static void SkrivAvskiljare()
{
    for (int i = 0; i < 30; i++)
    {
        Console.Write("*");
    }

    Console.Write("\n");
}