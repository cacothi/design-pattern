using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class VegBurger : Burger
	{
		public override String Name { get; } = "Veggie Burger";

		public override Double Price { get; } = 25.0;
	}
}
