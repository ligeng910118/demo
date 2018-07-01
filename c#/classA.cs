using System;
using System.IO;
class A
{
	class Employee
	{	
		public string FirstName;
		public string LastName;
		public string Salary = "not enough";

		public string GetName()
		{
			return FirstName + " " + LastName;
		}	

		public void SetName(string first,string last)
		{
			this.FirstName = first;
			this.LastName = last;
			Console.WriteLine("name changed to {0}",this.GetName());
		}

		pubic void Save()
		{
			DataStorage.Store(this);
		}
	}

	class DataStorage
	{
		public static void Store(Employee employee)
		{
			FileStream stream = new FileStream(employee.FirstName+employee.LastName+".txt",FileMode.Create);
			StreamWrite writer = new StreamWrite(stream);
			writer.WriteLine(employee.FirstName);
			writer.WriteLine(employee.LastName);
			writer.WriteLine(employee.Salary);
			writer.Close();
		}

		public static Employee Load(string firstName,string lastName)
		{
			Employee employee = new Employee();

			FileStream stream = new FileStream(firstName+lastName+".txt",FileMode.Open);

			StreamReader reader = new StreamReader(stream);

			employee.FirstName = reader.ReadLine();
			employee.LastName = reader.ReadLine();
			employee.Salary = reader.ReadLine();

			reader.Close();

			return employee;
		}
	}

	static void Main()
	{
		Employee employee1,employee2;
		employee1 = new Employee();
		employee1.FirstName = "inigo";
		employee1.LastName = "montoya";
		employee1.Salary = "too little";
		IncreaseSalary(employee1);
		Console.WriteLine("{0} {1}",employee1.GetName(),employee1.Salary);

		employee2 = new Employee();
		employee2.SetName("bb","aa");

		employee2.Save();

		employee1 = DataStorage.Load("cc","dd");

		Console.WriteLine("{0} :{1}",employee1.GetName(),employee1.Salary);
	}

	static void IncreaseSalary(Employee employee)
	{
		employee.Salary = "enough to survive on";
	}
}