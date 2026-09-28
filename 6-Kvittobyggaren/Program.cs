/* 6. Kvittobyggaren [Gul nivå]
Skapa en metod `SkrivUtKvittoLine(string produkt, decimal pris)`. Den ska formatera utskriften så att
produkten skrivs ut och priset visas snyggt som valuta till höger. Exempel: 'Kaffe..........35,00 kr'. Använd
string-interpolation med utfyllnad (alignment), t.ex. `{produkt,-15}{pris,10:C}`. */


SKrivUtKvittoRad("Flärp", 29.90M);


static void SKrivUtKvittoRad(string produkt, decimal pris)
{
    Console.WriteLine($"{produkt, -15}{pris, 10:C}");
}