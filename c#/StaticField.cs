using System;
class Program
{
	static void Main()
	{
		Employee.NextId = 100;

		Employee employee1 = new Employee("aa","bb");
		Employee employee2 = new Employee("cc","dd");

		Console.WriteLine("{0} {1} ({2})",employee1.FirstName,employee1.LastName,employee1.Id);
		Console.WriteLine("{0} {1} ({2})",employee2.FirstName,employee2.LastName,employee2.Id);
		Console.WriteLine("NextId = {0}",Employee.NextId);
	}
}

class Employee
{
	public static int NextId;
	public int Id { get;set;}
	public string FirstName { get;set;}
	public string LastName { get;set;}
	public string Salary { get;set;}

	public Employee(string firstName,string lastName)
	{
		FirstName = firstName;
		LastName = lastName;  
		Id = NextId;
		NextId++；
	}
}