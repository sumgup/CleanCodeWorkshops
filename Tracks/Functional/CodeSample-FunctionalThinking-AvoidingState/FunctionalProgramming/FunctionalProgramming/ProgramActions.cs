using System;
using System.Collections.Generic;

namespace FunctionalProgramming
{
	public class ProgramActions
	{
		
		public ProgramDetails CreteProgram(string programName,DateTime date)
		{
			return new ProgramDetails { ProgramName = programName, ProgramDate = date };
		}


		public void DisplayPrograms(List<ProgramDetails> Programs)
		{
			Console.WriteLine("\nAll Programs:\n");

			foreach (var program in Programs)
			{
				Console.WriteLine("Program Name {0}\t Program Date {1}", program.ProgramName, program.ProgramDate.ToString("d"));
			}
		}


		public List<ProgramDetails> GetProgramsAt(List<ProgramDetails> Programs, DateTime date)
		{
			List<ProgramDetails> programsAt = new List<ProgramDetails>();

			foreach (var program in Programs)
			{
				if (program.ProgramDate == DateTime.Today)
				{
					programsAt.Add(program);
				}
			}

			return programsAt;
		}
	}
}
