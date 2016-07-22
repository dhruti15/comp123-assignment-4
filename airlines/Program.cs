using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline;

namespace Airline
{
	class Program
	{
		public static void Main(string[] args)
		{
			int choice = 0;
			Airline airline = new Airline();
			while(choice != 3)
			{
				Console.WriteLine("1. Press 1 For First Class");
				Console.WriteLine("2. Press 2 For Economy Class");
				Console.WriteLine("3. Press 3 For Exit");
				try
				{
					choice = Convert.ToInt32(Console.ReadLine());
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					choice = 0;
				}
				switch (choice)
				{
				case 1: airline.reserveFirstClass();
					break;

				case 2: airline.reserveEconomicClass();
					break;
				case 3: airline.Exit();
					break;
				default:
					Console.WriteLine("Make proper selection");
					break;
				}
			}
		}
	}
}