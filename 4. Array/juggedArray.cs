using System;

namespace LearningCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] array = new int[5][];
			for (int i = 0; i < 5; i++)
			{
				array[i] = new int[i + 1];
			}
			// now array shape:
			/*
			 * array[0] -> { _ }
			 * array[1] -> { _, _ }
			 * array[2] -> { _, _, _ }
			 * array[3] -> { _, _, _, _ }
			 * array[4] -> { _, _, _, _, _ }
			 * 
			 */
			// Jugged Array can have diffrent rows count
			// But It needs first column count.
		}
	}
}
