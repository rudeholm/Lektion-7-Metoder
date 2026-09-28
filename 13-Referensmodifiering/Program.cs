/* 13.Referensmodifiering (ref) [AVANCERAT EXTRASPARR]
Skapa en metod `UppdateraStatus(ref string nuvarandeStatus, bool operationLyckades)`. Om
operationen lyckades ska statusen ändras till 'Aktiv och verifierad'. Om den misslyckades ska den ändras
till 'Systemfel: Åtgärd krävs'. Visa hur värdet på originalvariabeln i Main faktiskt ändras efter
metodanropet på grund av nyckelordet `ref`. */

string status = "Inaktiv";
Console.WriteLine(status);
UppdateraStatus(ref status, true);
Console.WriteLine(status);


static void UppdateraStatus(ref string nuvarandeStatus, bool operationLyckades)
{
    if (operationLyckades)
        nuvarandeStatus = "Aktiv och verifierad";
}