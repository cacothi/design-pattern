using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class ChickenBurger : Burger
	{
		public override String Name { get; } = "Chicken Burger";

		public override Double Price { get; } = 50.5;
	}
}
