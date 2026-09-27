/* 4. Temperaturtips [Grön nivå]
Skapa en metod `GeKlädråd(double temperatur)` som tar emot en temperatur i grader Celsius. Om
temperaturen är under 10 ska den skriva ut 'Ta på dig en tjock jacka!'. Annars ska den skriva ut 'En tröja
räcker gott!'. */

GeKlädråd(13.9);

static void GeKlädråd(double temperatur)
{
    if (temperatur < 10.0)
        Console.WriteLine("Ta på dig en tjock jacka!");
    else
        Console.WriteLine("En tröja räcker gott!");
}