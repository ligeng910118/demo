using System;
using System.Collections.Generic;
class Genner
{
	static void Main()
	{
		List<string> list = MakeList<string>("line 1","line 2");
		foreach(string x in list)
		{
			Console.WriteLine(x);
		}
	}

	static List<T> MakeList<T>(T first,T second)
	{
		List<T> list = new List<T>();
		list.Add(first);
		list.Add(second);
		return list;
	}
}