using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder
{
	public class OrderedItems
	{
		List<IItem> items = new List<IItem>();

		public void addItems(IItem item)
		{
			items.Add(item);
		}
		public float getCost()
		{
			float cost = 0;
			foreach (IItem item in items)
			{
				cost += item.price();
			}
			

			return cost;
		}

		public void showSet()
		{
			Console.WriteLine();
			Console.WriteLine("Customer order");
			foreach (IItem item in items)
			{
				Console.WriteLine("Set BOX: " + item.name());
				Console.WriteLine("Size: " + item.size());
				Console.WriteLine("Price: " + item.price());
			}
		}
		public void showKFC() 
		{
			Console.WriteLine();
			Console.WriteLine("Customer KFC");
			foreach (IItem item in items)
			{
				Console.WriteLine("KFC: " + item.name());
				Console.WriteLine("Size: " + item.size());
				Console.WriteLine("Price: " + item.price());
			}
		}

		public void showDrink()
		{
			Console.WriteLine();
			Console.WriteLine("Customer Drink");
			foreach (IItem item in items)
			{
				Console.WriteLine("Drink: " + item.name());
				Console.WriteLine("Size: " + item.size());
				Console.WriteLine("Price: " + item.price());
			}
		}
	}
}
