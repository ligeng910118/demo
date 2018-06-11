class Program
{
	static void Main()
	{
		var patent1 = new {title = "bifocals",age = "1784"};
		var patent2 = new {title = "photograph", age = "1878"};

		System.Console.WriteLine("{0} {1} ",patent1.title,patent1.age);
		System.Console.WriteLine("{0} {1} ",patent2.title,patent2.age);
	}
}