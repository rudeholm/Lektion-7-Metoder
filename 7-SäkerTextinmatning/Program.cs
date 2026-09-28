/* 7. Säker textinmatning [Gul nivå]
Skapa en metod `LäsSäkerText(string ledtext)` som skriver ut den medskickade ledtexten, läser in en
sträng från användaren via `Console.ReadLine()`, kontrollerar att inmatningen inte är tom eller enbart
mellanslag, och returnerar den giltiga strängen. Om den är tom ska ett felmeddelande visas och
användaren tvingas försöka igen. */

string input = LäsSäkerText("Skriv något!");

Console.WriteLine("\n\nDu skrev:");
Console.WriteLine(input);


static string LäsSäkerText(string ledtext)
{
    string? input;
    bool ogiltigInput = false;
    do
    {
        if (ogiltigInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ogiltig input. Försök igen!");
            Console.ResetColor();
            Console.WriteLine();
            ogiltigInput = false;
        }

        Console.WriteLine(ledtext);

        Console.Write("> ");
        input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            ogiltigInput = true;
    }
    while (ogiltigInput);

    return input;
}