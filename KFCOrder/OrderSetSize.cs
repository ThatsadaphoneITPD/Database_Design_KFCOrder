using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder
{
	public class OrderSetSize
	{
		public OrderedItems GetOrderSet()
		{
			Console.WriteLine("Welcome for using our service");
			OrderedItems itemsorder = new OrderedItems();
			Console.WriteLine("Enter type of Set");
			Console.WriteLine("       welcom     ");
			Console.WriteLine("      1. Vip       ");
			Console.WriteLine("      2. Normal   ");
			Console.WriteLine("      3. Exit     ");
			int Choice = Convert.ToInt32(Console.ReadLine());
			switch (Choice)
			{
				case 1:
					itemsorder.addItems(new SetSize.VIP());
					break;
				case 2:
					itemsorder.addItems(new SetSize.Normal());
					break;
				default:
					break;
			}
			return itemsorder;
		}
	}
}
