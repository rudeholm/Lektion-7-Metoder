/* 14.Det flexibla prissystemet (params) [AVANCERAT EXTRASPARR]
Skapa en metod `BeräknaTotalPris(decimal rabattSats, params decimal[] produktPriser)` som tar en fast
rabattsats (t.ex. 0.10 för 10% rabatt) följt av ett flexibelt antal priser via nyckelordet `params`. Metoden
ska summera alla produktpriser, dra av rabatten och returnera slutsumman. Visa hur man kan anropa
denna metod med 2, 5 eller inga priser alls. */

decimal[] priser = [
    12.95M,
    12.49M,
    9.99M
    ];

Console.WriteLine($"{BeräknaTotalPris(0.10M, priser):C}");

decimal BeräknaTotalPris(decimal rabattSats, params decimal[] produktPriser)
{
    decimal summa = produktPriser.Sum();
    summa -= (rabattSats * summa);

    return summa;
}