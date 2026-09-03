List<string> uppgifter = new List<string>();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Ange en uppgift:");
Console.ResetColor();
string beskrivning = Console.ReadLine();

uppgifter.Add(beskrivning);

Console.WriteLine($"Uppgiften '{beskrivning}' har lagts till!");

//---------------------

Console.WriteLine("\nAlla uppgifter:");

for (int i = 0; i < uppgifter.Count; i++)
{
    Console.WriteLine($"{i + 1}. {uppgifter[i]}");
}