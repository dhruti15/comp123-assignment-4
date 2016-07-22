using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
	public class Airline
	{
		//Private Properties +++++++++++++++++++++++++++
		List<String> _seatingChart = new List<string> ();
		List<String> _assignedChart = new List<string> ();

		private string change;
		//Public Properties ++++++++++++++++++++++++++++
		public Airline()
		{
			_seatingChart.Add ("First");
			_seatingChart.Add ("First");
			_seatingChart.Add ("First");
			_seatingChart.Add ("First");
			_seatingChart.Add ("First");
			_seatingChart.Add ("Economy");
			_seatingChart.Add ("Economy");
			_seatingChart.Add ("Economy");
			_seatingChart.Add ("Economy");
			_seatingChart.Add ("Economy");
		}

		//Public Methods +++++++++++++++++++++++++++++++
		public void reserveFirstClass()
		{
			int seat = 0;
			while (seat < 5) {
				if (_seatingChart [seat] == "First") {
					_assignedChart.Add (_seatingChart [seat]);
					_seatingChart.RemoveAt (seat);
					this.print();
					break;
				} else{
					Console.WriteLine ("First class is fully booked");
				}
				seat++;
			}
		}

		public void reserveEconomicClass()
		{
			int seat = 6;
			while (seat > 5 && seat < _seatingChart.Count) 
			{
				if (_seatingChart [seat] == "Economy") 
				{
					_assignedChart.Add (_seatingChart [seat]);
					_seatingChart.RemoveAt (seat);
					this.print();
					break;
				} else 
				{
					Console.WriteLine ("Economy class is fully booked");
					Console.WriteLine ("Would you like to book your seat in the First Class?/n 1. Press y for Yes /n 2. Press n for No");
					change = Console.ReadLine ().ToLower ();
				}
				if (change == "y") 
				{
					reserveFirstClass ();
				} else 
				{
					Console.WriteLine ("Next Flight leaves in 3 hours");
				}
				seat++;
			}
		}
		public void print()
		{
			Console.WriteLine ("Congratulations! Your Seat is Booked");
		}
		public void Exit()
		{
			Console.Clear();
		}
	}
}