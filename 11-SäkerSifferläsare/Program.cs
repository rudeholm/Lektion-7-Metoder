/* 11.Säker sifferläsare [Röd nivå]
Skapa en metod `LäsHeltal(string ledtext, int min, int max)` som returnerar ett giltigt heltal. Metoden ska
visa ledtexten, läsa inmatning, använda `int.TryParse` för att förhindra krascher, samt kontrollera att
talet ligger inom det tillåtna intervallet (min till max). Om något slår fel ska en loop tvinga användaren
att göra om inmatningen tills ett korrekt värde anges. */

Console.WriteLine(LäsHeltal("Ange ett heltal: ", 10, 100));

static int LäsHeltal(string ledtext, int min, int max)
{
    string? input;
    int heltal;

    do
    {
        Console.WriteLine($"{ledtext} (min: {min}, max: {max})");
        Console.Write("> ");
        input = Console.ReadLine();

        if (int.TryParse(input, out heltal) == false)
            continue;

        if (heltal < min || heltal > max)
            continue;

        break;

    } while (true);

    return heltal;
}



