using System;
using System.Collections.Generic;
using System.Text;

namespace KFCOrder
{
	public interface IItem
	{
		string name();
		string size();
		float price();
	}
	public abstract class SizeSet : IItem
	{
		public abstract string name();
		public abstract float price();
		public abstract string size();

	}
	public abstract class Food : IItem
	{
		public abstract string name();
		public abstract float price();
		public abstract string size();

	}
}
