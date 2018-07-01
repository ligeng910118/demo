class Program
{
	static void Main()
	{
			Employee employee = new Employee();
			employee.FirstName = "aa";
			System.Console.WriteLine("{0}",employee.FirstName);
	}

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