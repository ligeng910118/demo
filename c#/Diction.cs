using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Diction
{
	static void Main()
	{
		D d = new D();
		string text = @"do you like green eggs and ham? i do not like them,sam-i-am.i do not like green eggs and ham.";
		Dictionary <string,int> frequencies = d.CountWords(text);
		foreach(KeyValuePair<string,int> entry in frequencies)
		{
			string word = entry.Key;
			int frequency = entry.Value;
			Console.WriteLine("{0}:{1}",word,frequency);
		}
	}
}

class D
{
	public  Dictionary<string,int> CountWords(string text)
	{
		Dictionary<string,int> frequencies = new Dictionary<string,int>();
		string[] words = Regex.Split(text,@"\W+");
		foreach(string word in words)
		{
			if(frequencies.ContainsKey(word))
			{
				frequencies[word]++;
			}
			else
			{
				frequencies[word] = 1;
			}
		}
		return frequencies;
	}
}