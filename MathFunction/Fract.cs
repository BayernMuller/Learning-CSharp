using System;

namespace Algebra
{
	using Int = System.Numerics.BigInteger;

	class Fract
	{
		private Int mNumerator;
		private Int mDenominator;

		public decimal Value
		{
			get
			{
				return (decimal)mNumerator / (decimal)mDenominator;
			}
		}

		public override string ToString() => $"({mNumerator}/{mDenominator})";

		public Fract(Int num, Int den)
		{
			mNumerator = num;
			mDenominator = den;
		}

		private void Reduce(ref Fract fract)
		{
			Int ratio = Lcm(fract.mDenominator, mDenominator) / mDenominator;
			mDenominator *= ratio;
			mNumerator *= ratio;
			ratio *= fract.mDenominator * mDenominator;
			fract.mDenominator *= ratio;
			fract.mNumerator *= ratio;
		}

		private Int Gcd(Int a, Int b)
		{
			if (b.IsZero)
				return a;
			return Gcd(b, a % b);
		}

		private Int Lcm(Int a, Int b)
		{
			return (a * b) / Gcd(a, b);
		}
	}
}
