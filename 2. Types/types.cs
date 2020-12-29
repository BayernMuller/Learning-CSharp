using System;

namespace LearningCsharp // namespace
{
	class Program // class name
	{
		static void Main(string[] args) // Main function (Entry Point)
		{
			object objectVal;				// base class

			bool boolVal = true;			// 8 bit

			sbyte sbyteVal = -1;			// 8bit // signed
			byte byteVal = 0xFF;			// 8bit // unsigned
			
			short shortVal = -1;				// 16bit
			ushort ushortVal = 0xFFFF;			// 16bit
			
			int intVal = -1234;				// 32bit
			uint uintVal = 1234;			// 32bit

			long longVal = 100L;			// 64bit
			ulong ulongVal = 100UL;			// 64bit

			float floatVal = 133.432F;			// 32bit
			double doubleVal = 1343.666D;		// 62bit
			decimal decimalVal = 313.32321M;		// 128bit

			char charVal = 'd';				// 16bit // unicode
			string stringVal = "bayernthebest";		// unicode
		}
	}
}
