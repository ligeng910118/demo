class PalindromeLength
{
	static void Main()
	{
		string Palindrome;

		System.Console.WriteLine("enter a Palindrome:");
		Palindrome = System.Console.ReadLine();
		System.Console.WriteLine("the Palindrome,\"{0}\" is {1} chars ."
			,Palindrome,Palindrome.Length);
	}

}