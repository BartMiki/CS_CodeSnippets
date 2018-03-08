<Query Kind="Program" />

void Main()
{
	for(int i = 0; i<4; i++)
	{
		try
		{
			Console.WriteLine($"Iteration {i}");
			if(i == 3)
				throw new HalfLife3Exception();
				
			int error = 42 / i;
			Console.WriteLine("Everything went smoothly.");
		}
		catch(DivideByZeroException)
		{
			Console.WriteLine("In this universe you can't divide by zero. It's prohibited and you can go to math jail for it!");
		}
		catch(Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("I will execute no matter if exception was catched or no exception occured.");
			Console.WriteLine();
		}
	}
}

class HalfLife3Exception : Exception
{
	public HalfLife3Exception() : base("3? 3?! No, sadly \"Half Life 3\" is not confirmed.                               yet....") {}
}

// Define other methods and classes here
