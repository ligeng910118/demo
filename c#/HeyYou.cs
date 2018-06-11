class HeyYou
{
	static void Main()
	{
		string firstName;
		string lastName;

		System.Console.WriteLine("hey you");

		System.Console.WriteLine("enter you first name:");
		firstName = System.Console.ReadLine();
		System.Console.WriteLine("enter you last name:");
		lastName = System.Console.ReadLine();

		System.Console.WriteLine("hello,{0} {1}",firstName,lastName);

	}
}