class Convert
{
	static void Main()
	{
		string text = "11.87";
		float inttext = float.Parse(text);
		System.Console.WriteLine("{0}",inttext);
		double boolean = System.Convert.ToDouble(text);
		System.Console.WriteLine("{0}",boolean);
	}
}