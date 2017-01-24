using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class Coke : ColdDrink
	{
		public override String Name { get; } = "Coke";

		public override Double Price { get; } = 30.0;
	}
}
