List<string> uppgifter = new List<string>();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Ange en uppgift:");
Console.ResetColor();
string beskrivning = Console.ReadLine();

uppgifter.Add(beskrivning);

Console.WriteLine($"Uppgiften '{beskrivning}' har lagts till!");