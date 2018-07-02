
using System;
class Program
{
	static void Main()
	{
		Employee employee = new Employee("aa","bb"){Salary = "vv"};
		Console.WriteLine("{0} {1} {2}",employee.FirstName,employee.LastName,employee.Salary);
	}
}

class Employee
{
	public string FirstName { get;set; }
	public string LastName { get;set; }
	public string Salary { get; set;}
	public int Id {get;set;}
	public Employee(string firstName,string lastName) 
	{
		FirstName = firstName;
		LastName = lastName;
	}

	public Employee(int id,string firstName,string lastName): this(firstName,lastName)
	{
		Id = id;
	}

	public Employee(int id)
	{
		Id = id;
	}
}