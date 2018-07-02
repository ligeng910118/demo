class Program
{
	static void Main()
	{
			Employee employee = new Employee();
			employee.FirstName = "aa";
			System.Console.WriteLine("{0}",employee.FirstName);

			Employee employee2 = new Employee();
			employee2.Title = "computer";
			employee.Manage = employee2;
			System.Console.WriteLine("{0}",employee.Manage.Title);
	}

	class Employee
	{
		public string Title { get;set; }
		public Employee Manage { get;set; }

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
		public string _LastName
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

	}
}