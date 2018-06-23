class Employee
{
	private string _FirstName;

	public string FirstName
	{
		get
		{
			return _FirstName;
		}
		set
		{
			_FirstName = value;
		}
	}

	private string _LastName;

	public string LastName
	{
		get
		{
			return _LastName;
		}
		set
		{
			_LastName = value;
		}
	}

	public string Title{get;set;}

	public Employee Manager {get;set;}
}

class Program
{
	static void Main()
	{
		Employee employee = new Employee();
		Employee employee2 = new Employee();

		employee.FirstName = "inigo";

		employee2.Title = "computer nerd";

		employee.Manager = employee2;

		System.Console.WriteLine("{0}",employee.FirstName);

		System.Console.WriteLine("{0}",employee.Manager.Title);
	}
}