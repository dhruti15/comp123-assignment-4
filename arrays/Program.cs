using System;

namespace Dice
{
	class Program
	{
		public static void Main (string[] args)
		{
			int[] totalSum = new int[13];
			Random random = new Random ();
			int num1 = 0;
			int num2 = 0;
			int sum = 0;
			for (int i = 1; i <= 36000; ++i) 
			{
				num1 = random.Next (1, 7);
				num2 = random.Next (1, 7);
				sum = num1 + num2;
				++totalSum [sum];
			}
			Console.WriteLine ("{0,10} {1,10}", "Dice Sum", "Total Sum");
			for (int j = 2; j < 13; j++) 
			{
				Console.WriteLine ("{0,10} {1,10}", j, totalSum [j]);
			}
		}
	}
}