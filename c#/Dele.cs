using System;
delegate void StringProcessor(string input);

class Person
{
	string name;
	public Person(string name)
	{
		this.name = name;
	}
	public void Say(string message)
	{
		Console.WriteLine("{0} says: {1}",name,message);
	}
}

class Background
{
	public static void Note(string note)
	{
		Console.WriteLine("({0})",note);
	}
}

class SimpleDelegateUse
{
	static void Main()
	{
		Person jon = new Person("jon");
		StringProcessor jonsVoice,background;
		jonsVoice = new StringProcessor(jon.Say);
		background = new StringProcessor(Background.Note);
		jonsVoice.Invoke("hello");
		jonsVoice.Invoke("hi");
		background("air plane!");
	}
}
