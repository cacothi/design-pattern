using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public abstract class ColdDrink : IItem
	{
		public abstract String Name { get; }

		public IPacking Packing { get; } = new Bottle();

		public abstract Double Price { get; }

		public override string ToString()
		{
			return $"Item: {Name}, Packing: {Packing.Pack}, Price: ${Price}";
		}
	}
}
