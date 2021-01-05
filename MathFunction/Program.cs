using System;
using Algebra;

namespace MathFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			Fract one_third = new Fract(-1, 3);
			Fract three_fourths = new Fract(-3, 4);

			Console.WriteLine(one_third / three_fourths);
		}
	}
}
