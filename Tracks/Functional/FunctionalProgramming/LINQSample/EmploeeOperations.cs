using System;
namespace LINQSample
{
	public class EmploeeOperations
	{
		public Employee CreateEmployee(int id,string name,string address,string location,DateTime dob)
		{
			return
				new Employee
			{
				Id = id,
				Name =name,
				Address = address,
				WorkingLocation = location,
				DoB = dob
			};
		}
	}
}
