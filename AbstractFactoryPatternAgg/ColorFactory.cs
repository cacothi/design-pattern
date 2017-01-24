using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public class ColorFactory : AbstractFactory
	{
		public override IColor GetColor(string color)
		{

			if (color == null)
				return null;

			if (color.Equals("blue", StringComparison.InvariantCultureIgnoreCase))
				return new Blue();

			if (color.Equals("red", StringComparison.InvariantCultureIgnoreCase))
				return new Red();

			if (color.Equals("green", StringComparison.InvariantCultureIgnoreCase))
				return new Green();

			return null;
		}

		public override IShape GetShape(string shape)
		{
			return null;
		}
	}
}
