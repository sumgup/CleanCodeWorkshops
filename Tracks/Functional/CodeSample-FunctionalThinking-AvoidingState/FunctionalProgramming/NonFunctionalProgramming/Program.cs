namespace NonFunctionalProgramming
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			var programActions = new ProgramActions();

			//Needs to follow the order of execution since the Programs list is not available here.
			programActions.AddPrograms();

			//Problem: Unknown what are the programs to display
			programActions.DisplayPrograms();

			//Problem: Unknown from which program list finding the current program.
			programActions.GetCurrentPrograms();
		}
	}
}
