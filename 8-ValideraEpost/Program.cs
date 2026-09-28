/* 8. Validera e-post [Gul nivå]

Skapa en metod `ÄrGiltigEpost(string epost)` som returnerar en `bool`. Metoden ska kontrollera att e-
postadressen innehåller ett '@'-tecken, innehåller minst en punkt ('.'), samt är minst 5 tecken lång.

Returnera true om alla krav är uppfyllda, annars false. */

Console.WriteLine(ÄrGiltigEpost("foo@bar.baz"));
Console.WriteLine(ÄrGiltigEpost("foobar.baz"));


static bool ÄrGiltigEpost(string epost)
{
    return epost.Contains('@') && epost.Contains('.') && epost.Length >= 5;
}