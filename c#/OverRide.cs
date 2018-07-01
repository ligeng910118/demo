public class PdaItem
{
	public virtual string Name { get;set;}
}

public class Contact : PdaItem
{
	public string FirstName { get;set; }
	public string LastName { get;set; }
	public override string Name
	{
		get
		{
			return FirstName + " " + LastName;
		}
		set
		{
			string[] names = value.Split(' ');
			FirstName = names[0];
			LastName = names[1];
		}
	}
}

public class Program
{
	public static void Main()
	{
		Contact contact = new Contact();
		PdaItem item = contact;

		item.Name = "bb aa";
		System.Console.WriteLine("{0} {1}",contact.FirstName,contact.LastName);
	}
}