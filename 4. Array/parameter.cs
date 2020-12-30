using System;

namespace LearningCsharp
{
	class Program
	{
		static void toUpper(string[] names)
		{
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = names[i].ToUpper();
			}
		}

		static void Main(string[] args)
		{
			string[] names = { "muller", "flick", "neuer" };
			toUpper(names);
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
			/*
			 * 
			 * It prints MULLER FLICK NEUER.
			 * Because array in agument is reference.
			 * 
			 */
		}
	}
}
