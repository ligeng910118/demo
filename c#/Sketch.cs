using System;
public abstract class PdaItem
{
	public PdaItem(string name)
	{
		Name = name;
	}

	public virtual string Name { get;set;}
	public abstract string GetSummary();
}

public class Contact : PdaItem
{
	public string FirstName { get;set; }
	public string LastName { get;set; }
	public string Address { get;set; }

	public Contact(string name) : base(name)
	{
		Name = name;
	}

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
			"firstname : {0}\n"
			+ "lastname : {1}\n"
			+ "address : {2}",FirstName,LastName,Address
			);
	}
}

public class Appointment : PdaItem
{
	public DateTime StartDateTime { get;set; }
	public DateTime EndDateTime { get;set; }
	public string Location { get;set; }

	public Appointment(string name) : base(name)
	{
		Name = name;
	}

	public override string GetSummary()
	{
		return string.Format(
			"subject : {0}\n"
			+ "start : {1}\n"
			+ "end : {2}\n"
			+ "loaction : {3}",Name,StartDateTime,EndDateTime,Location
			);
	}
}

public class Program
{
	public static void Main()
	{
		PdaItem[] pda = new PdaItem[3];
		Contact contact  = new Contact("sherlock holmes");
		contact.Address = "221b baker street,london,england";
		pda[0] = contact;

		Appointment appointment = new Appointment("soccer tournament");
		appointment.StartDateTime = new DateTime(2008,7,18);
		appointment.EndDateTime = new DateTime(2008,7,19);
		appointment.Location = "estadio da machava";
		pda[1] = appointment;

		contact  =  new Contact("hercule poirot");
		contact.Address = "apt 56b,whitehaven mansions,sandhurst sq,london";
		pda[2] = contact;

		List(pda);
	}

	public static void List(PdaItem[] items)
	{
		foreach(PdaItem item in items)
		{
			Console.WriteLine("___________");
			Console.WriteLine(item.GetSummary());
		}
	}
}