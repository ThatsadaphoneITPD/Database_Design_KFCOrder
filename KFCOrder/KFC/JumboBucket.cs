using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.KFC
{
	public class JumboBucket : KFC
	{
		public override string name()
		{
			return "JumboBucket";
		}
		public override string size()
		{
			return "original 7 psc";
		}
		public override float price()
		{
			return 11.0f;
		}
	}
}
