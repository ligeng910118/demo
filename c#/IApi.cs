interface IListable
{
	string[] ColumnValues
	{
		get;
	}
}

public abstract class PdaItem
{
	public virtual string Name { get;set; }

	public PdaItem(string name)
	{
		Name = name;
	}
}

class Contact : PdaItem,IListable
{
	public string FirstName { get;set; }
	public string LastName { get;set; }
	public string Address { get;set; }
	public string Phone { get;set; }

	public Contact(string firstName,string lastName,string address,string phone):base(null)
	{
		FirstName = firstName;
		LastName = lastName;
		Address = address;
		Phone = phone;
	}	

	public string[] ColumnValues
	{
		get
		{
			return new string[]
			{
				FirstName,
				LastName,
				Phone,
				Address
			};
		}
	}

	public static string[] Headers
	{
		get
		{
			return new string[]
			{
				"first name",
				"last name",
				"phone",
				"address"
			};
		}
	}
}

class Publication : IListable
{
	public string Title { get;set; }
	public string Author { get;set; }
	public int Year { get;set; }

	public Publication(string title,string author,int year)
	{
		Title = title;
		Author = author;
		Year = year;
	}

	public string[] ColumnValues
	{
		get
		{
			return new string[]
			{
				Title,
				Author,
				Year.ToString()
			};
		}
	}
2
	public static string[] Headers
	{
		get
		{
			return new string[]
			{
				"title",
				"author",
				"year"
			}
		}
	}
}