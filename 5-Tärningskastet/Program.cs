/* 5. Tärningskastet [Grön nivå]
Skapa en metod `KastaTärning()` som inte tar några parametrar men returnerar ett heltal mellan 1 och
6. Använd klassen `Random` inuti metoden för att generera talet. Skriv ut det returnerade värdet i Main. */


Console.WriteLine(KastaTärning());


static int KastaTärning()
{
    var random = new Random();

    return (int)random.NextInt64(1, 7);
}