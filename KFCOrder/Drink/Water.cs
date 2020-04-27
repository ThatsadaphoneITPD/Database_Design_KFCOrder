using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.Drink
{
	public class Water : Drink
	{
		public override string name()
		{
			return "Water";
		}
		public override string size()
		{
			return "None";
		}
		public override float price()
		{
			return 1.5f;
		}
	}
}
