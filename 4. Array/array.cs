using System;

namespace LearningCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] emptyNames = new string[3];
			string[] names = { "Muller", "Lewandowski", "Neuer" };

			int[,] emptyMatrix = new int[3, 3];
			int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

			byte[,,] emptyCube = new byte[2, 2, 2];
			byte[,,] cube = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };


			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			Console.WriteLine();

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write(matrix[i, j]);
					Console.Write("\t");
				}
				Console.WriteLine();
			}
		}
	}
}
