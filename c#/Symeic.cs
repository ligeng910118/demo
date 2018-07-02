using System;
class Program
{
	static void Main()
	{
		var patent1 = 
			new 
			{
				Title = "bifocals"，
				YearOfPubliccation = "1784",
			};
		var patent2 = 
			new 
			{
				Title = "phonograph",
				YearOfPubliccation = "1999",
			};
		var patent3 = 
			new
			{
				patent1.Title,
				Year = patent1.YearOfPubliccation,
			};

		Console.WriteLine("{0} ({1})",patent1.Title,patent1.YearOfPubliccation);
		Console.WriteLine("{0} ({1})",patent2.Title,patent2.YearOfPubliccation);

		Console.WriteLine();
		Console.WriteLine(patent1);
		Console.WriteLine(patent2);

		Console.WriteLine();
		Console.WriteLine(patent3);
	}
}