using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.SetSize
{
	public class VIP : SizeSet
	{
		public override float price()
		{
			return 10.0f;
		}
		public override string name()
		{
			return "VIP Set";
		}
		public override string size()
		{
			return "Add +10 pcs";
		}
	}
}
