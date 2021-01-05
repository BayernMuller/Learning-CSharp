using System;

namespace Algebra
{
	using Int = System.Numerics.BigInteger;
	class Fract
	{
		private Int numerator;
		private Int denominator;

		public decimal Value
		{
			get
			{
				return (decimal)numerator / (decimal)denominator;
			}
		}

		public Fract(Int num, Int den)
		{
			numerator = num;
			denominator = den;
		}

	}
}
