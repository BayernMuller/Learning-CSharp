using System;
using Algebra;

namespace MathFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			Fract fract = new Fract(10, 7);
			Console.WriteLine(fract.ToString());
		}
	}
}
