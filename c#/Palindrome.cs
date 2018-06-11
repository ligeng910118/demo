class Palindrome
{
	static void Main()
	{
		string reverse,palindrome;
		char[] temp;
		System.Console.WriteLine("enter a palindrome:");
		palindrome = System.Console.ReadLine();

		reverse = palindrome.Replace(" ","");
		reverse = reverse.ToLower();

		temp = reverse.ToCharArray();

		System.Array.Reverse(temp);

		if(reverse == new string(temp))
			System.Console.WriteLine("\"{0}\" is a palindrome",palindrome);
		else
			System.Console.WriteLine("\"{0}\" is not a palindrome",palindrome);
	}
}