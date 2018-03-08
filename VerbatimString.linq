<Query Kind="Statements" />

string verbatimString = @"This is a verbatim string.
You can have multiple lines
in this string.

	Be aware of tab, because
		it
			is
				counted 
					to
						the
							string
								as
									well,
									
as you can see above.
				
And you can also make quotes like this: ""quote"".";
				
Console.WriteLine(verbatimString);