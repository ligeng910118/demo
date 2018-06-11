class IntroducingMethods
{
	static void Main()
	{
		string firstName;
		string lastName;
		string fullName;

		System.Console.WriteLine("hey,you!");
		firstName = GetUserInput("enter you firstName :");
		lastName = GetUserInput("enter you lastName : ");

		fullName = GetFullName(firstName,lastName);
		DisplayGreeting(fullName);

	}

	static string GetUserInput(string prompt)
	{
		System.Console.Write(prompt);
		return System.Console.ReadLine();
	}

	static string GetFullName(string firstName,string lastName)
	{
		return firstName + " " + lastName;
	}

	static void DisplayGreeting(string name)
	{
		System.Console.WriteLine("your full name is {0}.",name);
	}
}