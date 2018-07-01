public class PdaItem
{
	public string Name { get;set; }

	public DateTime LastUpdated { get;set; }
}

public class Contact : PdaItem
{
	public string Address { get;set; }
	public string Phone { get;set; }
} 

public class Program
{
	public static void Main()
	{
		Contact contact = new Contact();
		contact.Name = "aa";
	}
}