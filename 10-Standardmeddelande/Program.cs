/* 10.Standardmeddelande [Gul nivå]
Skapa en metod `LoggaMeddelande(string meddelande, string loggTyp = "INFO")`. Den andra
parametern ska ha ett standardvärde (optional parameter). Metoden ska skriva ut meddelandet
formaterat som `[LOGGTYP] - meddelande`. Testa att anropa metoden både med en och två parametrar
i Main. */


LoggaMeddelande("Schemalagt underhåll nästa vecka");
LoggaMeddelande("404 Not Found", "error");


static void LoggaMeddelande(string meddelande, string loggTyp = "INFO")
{
    Console.WriteLine($"[{loggTyp.ToUpper()}] - {meddelande}");
}