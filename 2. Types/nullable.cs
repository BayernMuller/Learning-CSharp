using System;

namespace LearningCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			int? nullable_int = null;
			// nullable type can be used at not only int but also every types
			// such as bool, float.
			if (nullable_int.HasValue)
			{
				Console.WriteLine(nullable_int);
			}
			else
			{
				Console.WriteLine("It's null");
			}
		}
	}
}
