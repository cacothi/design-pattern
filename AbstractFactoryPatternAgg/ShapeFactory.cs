using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public class ShapeFactory : AbstractFactory
	{
		public override IColor GetColor(string color)
		{
			return null;
		}

		public override IShape GetShape(string shape)
		{
			if (shape == null)
				return null;

			if (shape.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
				return new Circle();

			if (shape.Equals("retangle", StringComparison.InvariantCultureIgnoreCase))
				return new Retangle();

			if (shape.Equals("square", StringComparison.InvariantCultureIgnoreCase))
				return new Square();

			return null;
		}
	}
}
