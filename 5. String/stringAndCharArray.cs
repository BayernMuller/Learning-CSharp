using System;

namespace LearningCsharp
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] charArray = "the best team is bayern munich".ToCharArray();
			for (int i = 0; i < charArray.Length; i++)
			{
				charArray[i] -= (char)('a' - 'A');
			}

			string str = new string(charArray);
			/*
			 * flowwing code make compile error.
			 * 'cause string type's indexer is readonly
			 * 
			    for (int i = 0; i < str.Length; i++)
				{
					str[i] += (char)('a' - 'A');
				}
			*/
			Console.WriteLine(str);
		}
	}
}
