using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			EmploeeOperations EmploeeOperations = new EmploeeOperations();
				
			List<Employee> employees = new List<Employee>();
			employees.Add(EmploeeOperations.CreateEmployee(1,"Employee 1","XYZ","Bangalore",new DateTime(1995,4,9)));
			employees.Add(EmploeeOperations.CreateEmployee(2,"Employee 2","ABC","Hyderabad",new DateTime(1996,4,3)));
			employees.Add(EmploeeOperations.CreateEmployee(3,"Employee 3","QWE","Hyderabad",new DateTime(1991,5,7)));
			employees.Add(EmploeeOperations.CreateEmployee(3,"Employee 4","XYZ","Bangalore",new DateTime(1992,1,19)));

			//Traditional way
			List<string> resultEmp = new List<string>();
			foreach (var emp in employees)
			{
				if (string.Equals(emp.WorkingLocation, "Bangalore"))
				{
					resultEmp.Add(emp.Name);
				}
			}
			foreach(var emp in resultEmp)
			{
				Console.WriteLine(emp);
			}

			//Linq
			var result = employees.Where(y => y.WorkingLocation == "Bangalore").Select(x => x.Name);

			foreach(var emp in result)
			{
				Console.WriteLine(emp);
			}
		}
	}
}
