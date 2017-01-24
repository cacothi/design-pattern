using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class Pepsi : ColdDrink
	{
		public override String Name { get; } = "Pepsi";

		public override Double Price { get; } = 35.0;
	}
}
