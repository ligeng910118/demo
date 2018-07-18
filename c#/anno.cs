using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<string> seven = new List<string>()
		{
			"wealth without work",
			"pleasure without conscience",
			"knowledge without character",
		};
		Print(seven);
	}

	private static void Print<T>(IEnumerable<T> items)
	{
		foreach(T item in items)
		{
			Console.WriteLine(item);
		}
	}
}