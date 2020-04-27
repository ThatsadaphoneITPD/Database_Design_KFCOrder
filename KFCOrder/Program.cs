using System;

namespace KFCOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			var Set = new OrderSetSize();
			OrderedItems orderSet = Set.GetOrderSet();
			var Kfc = new OrderKFC();
			OrderedItems KFC = Kfc.GetOrderKFC();
			var drink = new OrderDrink();
			OrderedItems Drink = drink.GetOrderDrink();
			orderSet.showSet();
			KFC.showKFC();
			Drink.showDrink();
			var total = orderSet.getCost() + KFC.getCost() + Drink.getCost();
			Console.WriteLine();
			Console.WriteLine("Total cost: " + total + " s$");
			Console.ReadLine();
			Console.ReadKey();
		}
	}
}
