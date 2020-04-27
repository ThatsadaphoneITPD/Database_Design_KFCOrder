using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.SetSize
{
	public class Normal : SizeSet
	{
		public override float price()
		{
			return 1.5f;
		}
		public override string name()
		{
			return "Norml set";
		}
		public override string size()
		{
			return "Normal";
		}
	}
}
