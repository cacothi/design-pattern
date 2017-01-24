using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class Bottle : IPacking
	{
		public String Pack { get; } = "Bottle";
	}
}
