using System;
using System.Collections.Generic;

namespace NonFunctionalProgramming
{
	public class ProgramActions
	{
		private List<ProgramDetails> Programs = new List<ProgramDetails>();

		public void AddPrograms()
		{
			Programs.Add(new ProgramDetails { ProgramName = "Program 1", ProgramDate = DateTime.Today });
			Programs.Add(new ProgramDetails { ProgramName = "Program 2", ProgramDate = DateTime.Today.AddDays(-1) });
		}

		public void DisplayPrograms()
		{
			Console.WriteLine("\nAll Programs:\n");

			foreach (var program in Programs)
			{
				Console.WriteLine("Program Name {0}\t Program Date {1}",program.ProgramName,program.ProgramDate.ToString("d"));
			}
		}

		public void GetCurrentPrograms()
		{
			Console.WriteLine("\nCurrent programs are:\n");

			foreach (var program in Programs)
			{
				if (program.ProgramDate == DateTime.Today) //DateTime.Today is the hidden input
				{
					Console.WriteLine("Program Name {0}\t Program Date {1}", program.ProgramName, program.ProgramDate.ToString("d"));
				}
			}
		}
	}
}
