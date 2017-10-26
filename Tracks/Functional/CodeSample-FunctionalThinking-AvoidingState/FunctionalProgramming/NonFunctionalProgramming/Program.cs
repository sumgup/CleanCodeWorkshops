using System;

namespace NonFunctionalProgramming
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			var obj = new ProgramActions();

			//Needs to fallow the order of execution since the Programs list is not available here.

			obj.AddPrograms();

			//Problem: Unknown what are all the programs to display
			obj.DisplayPrograms();

			//Problem: Unknown from which program list finding the current program.
			obj.GetCurrentPrograms();
		}
	}
}
