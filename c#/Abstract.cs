public abstract class PdaItem
{
	public virtual string Name { get;set; }
	public abstract string GetSummary();

	public PdaItem(string name) 
	{
		Name = name;
	}
}

public class Contact : PdaItem
{
	public string FirstName { get;set;}
	public string LastName { get;set;}
	public string Address { get;set;}
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

	public override string GetSummary()
	{
		return string.Format(
			"FirstName:{0}\n"
			+ "LastName : {1} \n"
			+ " Address : {2}",FirstName,LastName,Address
			);
	}
}

public class Appointment : PdaItem
{
	public DateTime StartDateTime { get;set; }
	public DateTime EndDateTime { get;set;}
	public string Location { get;set; }

	public Appointment(string name) : base(name)
	{
		Name = name;
	}

	public override string GetSummary()
	{
		return string.Format(
			"subject : {0}\n"
			+ "start : {1} \n"
			+ " end : {2}\n"
			+ "location : {3}",Name,StartDateTime,EndDateTime,Location
			);
	}
		
}