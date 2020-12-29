using System;

namespace LearningCsharp
{
	class MyClass
	{
		public const int constant = 123; // const values must be initialized.
		public readonly int rdonly; // readonly values don't have to be initialized.

		public MyClass()
		{
			rdonly = 789;
			// You can initialize readonly values at constructor.
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(MyClass.constant);
			// class' const fields are static.

			MyClass myClass = new MyClass();
			Console.WriteLine(myClass.rdonly);
			// readonly fields aren't staitc.
		}
	}
}
