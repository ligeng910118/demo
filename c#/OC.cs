using System;
class Employee
{
	public static int NextId;
	public int Id {get;set;}
	public string FirstName {get;set;}
	public string LastName {get;set;}
	public string Salary {get;set;}

	public Employee(string firstName,string lastName)
	{
		FirstName = firstName;
		LastName = lastName;
		Id = NextId;
		NextId++;
	}

	public Employee(int id,string firstName,string lastName) : this(firstName,lastName)
	{
		Id = id;
	}

	public Employee(int id)
	{
		Id = id;
	}
}

class Program
{
	static void Main()
	{
		Employee.NextId = 100;

		Employee employee1 = new Employee("inigo","montoya");

		Employee employee2 = new Employee("princess","buttercup");

		Console.WriteLine("{0} {1} {2}",
			employee1.FirstName,
			employee1.LastName,
			employee1.Id);
		Console.WriteLine("{0} {1} {2}",
			employee2.FirstName,
			employee2.LastName,
			employee2.Id);
		Console.WriteLine("NextId = {0}",Employee.NextId);
	}
}