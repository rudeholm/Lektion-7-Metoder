/* 3. Personlig hälsning [Grön nivå]
Skapa en metod `HälsaAnvändare(string namn)` som tar emot ett namn som parameter och skriver ut
'Hej [namn], hoppas du har en fantastisk dag på distansutbildningen!'. */

HälsaAnvändare("Sigge");

static void HälsaAnvändare(string namn)
{
    Console.WriteLine($"Hej {namn}, hoppas du har en fantastisk dag på distansutbildningen!");
}