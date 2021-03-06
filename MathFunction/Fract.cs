﻿using System;

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

		public override string ToString()
		{
			if (mDenominator.IsOne || mNumerator.IsZero)
				return $"{mNumerator}";
			return $"({mNumerator}/{mDenominator})";
		}

		public Fract(Int num, Int den)
		{
			SetFract(num, den);
		}

		public void SetFract(Int num, Int den)
		{
			mNumerator = num;
			mDenominator = den;
			Simplify();
		}

		public static Fract operator +(Fract a, Fract b)
		{
			a.Equalize(ref b);
			return new Fract(a.mNumerator + b.mNumerator, a.mDenominator);
		}

		public static Fract operator -(Fract a, Fract b)
		{
			a.Equalize(ref b);
			return new Fract(a.mNumerator - b.mNumerator, a.mDenominator);
		}

		public static Fract operator *(Fract a, Fract b)
		{
			return new Fract(a.mNumerator * b.mNumerator, a.mDenominator * b.mDenominator);
		}
		public static Fract operator /(Fract a, Fract b)
		{
			return new Fract(a.mNumerator * b.mDenominator, a.mDenominator * b.mNumerator);
		}

		private void Equalize(ref Fract fract)
		{
			Int ratio = Lcm(fract.mDenominator, mDenominator) / mDenominator;
			mDenominator *= ratio;
			mNumerator *= ratio;
			ratio = (mDenominator / fract.mDenominator);
			fract.mDenominator *= ratio;
			fract.mNumerator *= ratio;
		}

		private void Simplify()
		{
			Int gcd = Gcd(mNumerator, mDenominator);
			mNumerator /= gcd;
			mDenominator /= gcd;
			if (mNumerator < 0 && mDenominator < 0 || mDenominator < 0 && mNumerator > 0)
			{
				mNumerator *= -1;
				mDenominator *= -1;
			}
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
