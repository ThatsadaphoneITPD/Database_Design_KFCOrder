using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder.Drink
{
	public abstract class Drink : Food
	{
		public abstract override string name();
		public abstract override string size();
		public abstract override float price();
	}
}
