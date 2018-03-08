<Query Kind="Program">
  <Namespace>System.Threading</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


void Main()
{
	Console.WriteLine("Blocking operation:");
	BlockingOperation();
	Loop();
	Thread.Sleep(100);
	Console.WriteLine();
	Console.WriteLine("Async operation:");
	AsyncOperation();
	Loop();
}

void BlockingOperation()
{
	Console.WriteLine("Time consuming operation...");
	Thread.Sleep(3000);
	Console.WriteLine("... done");
}

async Task AsyncOperation()
{
	Console.WriteLine("Time consuming operation...");
	await Task.Delay(3000);
	Console.WriteLine("... done");
}

void Loop()
{
	Console.WriteLine("Some code execution");
	foreach (var i in Enumerable.Range(0,5))
    {
      	Console.WriteLine($"{i} ");
    }
}

// Define other methods and classes here
