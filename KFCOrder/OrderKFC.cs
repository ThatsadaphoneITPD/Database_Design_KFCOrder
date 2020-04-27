using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder
{
	public class OrderKFC
	{
		public OrderedItems GetOrderKFC()
		{
			Console.WriteLine("Welcome for using our service");
			OrderedItems itemKFC = new OrderedItems();
			Console.WriteLine("Enter type of Food");
			Console.WriteLine("       welcom     ");
			Console.WriteLine("      1.Boneless       ");
			Console.WriteLine("      2.JumboBucket  ");
			Console.WriteLine("      3.Exit     ");
			int Choice = Convert.ToInt32(Console.ReadLine());
			switch (Choice)
			{
				case 1:
					itemKFC.addItems(new KFC.Boneless());
					break;
				case 2:
					itemKFC.addItems(new KFC.JumboBucket());
					break;
				default:
					break;
			}

			return itemKFC;
		}
	}
}
