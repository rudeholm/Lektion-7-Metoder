/* 9. Betygskalkylatorn [Gul nivå]
Skapa en metod `FastställBetyg(int poäng)` som returnerar en sträng ('IG', 'G', eller 'VG'). Om poäng är
under 50 blir det 'IG', mellan 50 och 79 blir det 'G', och 80 eller högre blir det 'VG'. Använd tidiga
`return`-satser (guard clauses) istället för en lång nästlad if-else-struktur för att hålla koden ren. */

Console.WriteLine(FastställBetyg(35));
Console.WriteLine(FastställBetyg(55));
Console.WriteLine(FastställBetyg(85));


static string FastställBetyg(int poäng)
{
    if (poäng >= 80)
        return "VG";

    if (poäng >= 50)
        return "G";

    return "IG";


}