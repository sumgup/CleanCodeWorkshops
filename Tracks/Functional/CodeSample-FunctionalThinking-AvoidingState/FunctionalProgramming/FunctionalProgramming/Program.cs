﻿using System;
using System.Collections.Generic;

namespace FunctionalProgramming
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			var programActions = new ProgramActions();

			List<ProgramDetails> Programs = new List<ProgramDetails>();

			Programs.Add(programActions.CreteProgram("Program 1",DateTime.Today));
			Programs.Add(programActions.CreteProgram("Program 2",DateTime.Today));

			//Known what are the programs to display since we are passing the Programs as paremeter
			programActions.DisplayPrograms(Programs);


			Console.WriteLine("\nCurrent programs are:\n");
			//Known from which programs list we are finding the programs for the given date.
			var currentPrograms = programActions.GetProgramsAt(Programs, DateTime.Today);
			foreach (var program in Programs)
			{
				Console.WriteLine("Program Name {0}\t Program Date {1}", program.ProgramName, program.ProgramDate.ToString("d"));
			}
		}
	}
}
