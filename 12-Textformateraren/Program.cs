/* 12.Textformateraren (out) [Röd nivå]
Skapa en metod `DelaFullständigtNamn(string fulltNamn, out string förnamn, out string efternamn)`.
Metoden ska ta emot ett fullständigt namn (t.ex. 'Anna Andersson'), dela på strängen vid mellanslaget,
och skicka tillbaka förnamn och efternamn via `out`-parametrar. Om inget mellanslag finns ska
efternamnet sättas till 'Ej angivet'. */


DelaFullständigtNamn("Foo Bar", out string förnamn, out string efternamn);
Console.WriteLine($"Förnamn: {förnamn} | Efternamn: {efternamn}");


static void DelaFullständigtNamn(string fulltNamn, out string förnamn, out string efternamn)
{
    string[] namn = fulltNamn.Split(' ');
    förnamn = namn[0];
    efternamn = namn.Length > 1 ? namn[1] : "Ej angivet";
}