using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder
{
	public class OrderDrink
	{
		public OrderedItems GetOrderDrink()
		{
			Console.WriteLine("Welcome for using our service");
			OrderedItems itemFOOD = new OrderedItems();
			Console.WriteLine("Enter type of Drink");
			Console.WriteLine("       welcom     ");
			Console.WriteLine("      1.Coca       ");
			Console.WriteLine("      2.Waer  ");
			Console.WriteLine("      3.Exit     ");
			int Choice = Convert.ToInt32(Console.ReadLine());
			switch (Choice)
			{
				case 1:
					itemFOOD.addItems(new Drink.Coca());
					break;
				case 2:
					itemFOOD.addItems(new Drink.Water());
					break;
				default:
					break;
			}

			return itemFOOD;
		}
	}
}