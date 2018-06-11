class ProgrammingLanguages
{
	static void Main()
	{
		string[] languages = new string[]{
			"c#","cobol","java","c++","visual basic",
			"pascal","fortran","lisp","j#"
		};

		System.Array.Sort(languages);

		string searchString = "cobol";

		int index = System.Array.BinarySearch(languages,searchString);

		System.Console.WriteLine("the wave of the future,{0},is at index {1}",
			searchString,index);
		System.Console.WriteLine("{0,-20}\t{1,-20}","first element","last element");
		System.Console.WriteLine("{0,-20}\t{1,-20}","----------","----------");

		System.Console.WriteLine("{0,-20}\t{1,-20}",languages[0],languages[languages.Length-1]);
		System.Array.Reverse(languages);
		System.Console.WriteLine("{0,-20}\t{1,-20}",languages[0],languages[languages.Length-1]);

		System.Array.Clear(languages,0,languages.Length);

		System.Console.WriteLine("{0,-20}\t{1,-20}",languages[0],languages[languages.Length-1]);
		System.Console.WriteLine("after clear, the Array size is :{0}",languages.Length);
	}
}