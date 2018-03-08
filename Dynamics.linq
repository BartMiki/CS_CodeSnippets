<Query Kind="Program" />

void Main()
{
	dynamic name = "Bart";
	Console.WriteLine($"Dynamic: {name}, Type: {name.GetType()}.");
	name = 3.14;
	Console.WriteLine($"Dynamic: {name}, Type: {name.GetType()}.");
	name = 0b100_000;
	Console.WriteLine($"Dynamic: {name}, Type: {name.GetType()}.");
	
	dynamic answerToEverything = 42;
	int meaningOfLive = answerToEverything;
	Console.WriteLine($"Answer to everything {meaningOfLive}.");
}

// Define other methods and classes here
