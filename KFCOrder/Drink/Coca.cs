using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.Drink
{
	public class Coca : Drink
	{
		public override string name()
		{
			return "Coca";
		}
		public override string size()
		{
			return "None";
		}
		public override float price()
		{
			return 3.0f;
		}
	}
}
