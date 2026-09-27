/* 1. Hälsningsroboten [Grön nivå]
Skapa en metod som heter `VisaHälsning()`. Metoden ska inte ta några parametrar och inte returnera
något värde. När den anropas ska den rensa konsolen, ändra textfärg till grön och skriva ut ett
välkomstmeddelande: 'Välkommen till systemet! Robotaktiverad.'. Anropa metoden från Main. */

VisaHälsning();

static void VisaHälsning()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Välkommen till systemet! Robot aktiverad.");
}