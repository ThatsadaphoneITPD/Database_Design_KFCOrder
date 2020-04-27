using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.KFC
{
	public class Boneless : KFC
	{
		public override string name()
		{
			return "BoneLess Meat";
		}
		public override string size()
		{
			return "original 5 pcs";
		}
		public override float price()
		{
			return 13.0f;
		}
	}
}
