using System;
using System.IO;
class Employee
{
	public string FirstName;
	public string LastName;
	public string Salary = "not enough";
	private string Password;
	private bool IsAuthenticated;

	public bool Logon(string password)
	{
		if(Password == password)
		{
			IsAuthenticated = true;
		}
		return IsAuthenticated;
	}

	public bool GetIsAuthenticated()
	{
		return IsAuthenticated;
	}

	public string GetName()
	{
		return FirstName + " " + LastName;
	}

	public void SetName(string firstName,string lastName)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
		Console.WriteLine("name changed to {0}",this.GetName());
	}

	public void Save()
	{
		DataStorage.Store(this);
	}

	public Employee Load()
	{
		return	DataStorage.Load(this.FirstName,this.LastName);
	}
}

class DataStorage
{
	public static void Store(Employee employee)
	{
		// Console.WriteLine("{0} {1}",
		// 	employee.FirstName,
		// 	employee.LastName);

		FileStream stream = new FileStream(employee.FirstName+employee.LastName
			+".dat",FileMode.Create);
		StreamWriter writer = new StreamWriter(stream);

		writer.WriteLine(employee.LastName);
		writer.WriteLine(employee.Salary);
		writer.WriteLine(employee.FirstName);

		writer.Close();
	}

	public static  Employee Load(string firstName,string lastName)
	{
		Employee employee = new Employee();

		FileStream stream = new FileStream(
			firstName+lastName+".dat",FileMode.Open);
		StreamReader reader = new StreamReader(stream);
		employee.FirstName = reader.ReadLine();
		employee.LastName = reader.ReadLine();
		employee.Salary = reader.ReadLine();
		reader.Close();
		return employee;
	}
}

class ClassField
{
	static void Main()
	{
		Employee employee1 = new Employee();
		employee1.FirstName = "li";
		employee1.LastName = "geng";
		// employee1.FirstName = "inigo";
		// employee1.LastName = "montoya";
		// employee1.Salary = "too little";
		// IncreaseSalary(employee1);
		// Console.WriteLine("{0} : {1}",
		// 	employee1.GetName(),
		// 	employee1.Salary);

		// employee1.SetName("li","geng");
		// employee1.Save();
		Employee employee2 = new Employee();
		employee2 = employee1.Load();
		Console.WriteLine("{0}:{1}",employee2.GetName(),employee2.Salary);
	}

	static void IncreaseSalary(Employee employee)
	{
		employee.Salary = "enough to survive on ";
	}
}