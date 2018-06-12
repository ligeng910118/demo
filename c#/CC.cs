using System.Collections.Generic;
class CC
{
	static void Main()
	{
		List<Employee> employees = new List<Employee>()
		{
			new Employee("inigo","montoya"),
			new Employee("chuck","mcatte")
		};

		foreach(Employee e in employees)
		{
			System.Console.WriteLine("{0},{1}",e.FirstName,e.LastName);
		}
	}
}

class Employee
{
	public string FirstName{get;set;}
	public string LastName{get;set;}

	public Employee(string firstName,string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
	}
}