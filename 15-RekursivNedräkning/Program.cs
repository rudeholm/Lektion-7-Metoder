/* 15.Rekursiv nedräkning [AVANCERAT EXTRASPARR]
Skapa en rekursiv metod som heter `RekursivNedräkning(int startVärde)`. Metoden ska skriva ut det
aktuella talet på skärmen, vänta 200 millisekunder (`Thread.Sleep(200);`), och sedan anropa sig själv
igen med `startVärde - 1`. Loopen (rekursionen) ska avbrytas när talet når 0, varpå den ska skriva ut
'BOOM!'. Förklara basfallets betydelse för att undvika StackOverflowException. */


RekursivNedräkning(10);


void RekursivNedräkning(int startVärde)
{
    if (startVärde < 0)
    {
        Console.WriteLine("BOOM!");
        return;
    }

    Console.WriteLine(startVärde);
    Thread.Sleep(200);

    RekursivNedräkning(startVärde - 1);
}