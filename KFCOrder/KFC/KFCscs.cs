using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.KFC
{
	public abstract class KFC : Food
	{
		public abstract override string name();
		public abstract override string size();
		public abstract override float price();
	}
}
