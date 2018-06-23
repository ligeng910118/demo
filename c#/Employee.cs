using System;
using System.IO;
class Employee
{
	public string FirstName;
	public string LastName;
	public string Salary;

	public string GetName()
	{
		return FirstName + " " + LastName;
	}

	public void SetName(string newFirstName,string newLastName)
	{
		this.FirstName = newFirstName;
		this.LastName = newLastName;
		System.Console.WriteLine("name changed to {0}",this.GetName());
	}

	
}

class Program
{
	static void Main()
	{
		Employee employee1 = new Employee();
		Employee employee2;
		employee2 = new Employee();

		employee1.FirstName = "彭梦";
		employee1.LastName = "雯姐";
		employee1.Salary = "很肥";

		System.Console.WriteLine("{0},{1}",
			employee1.GetName(),
			employee1.Salary);
	}
}