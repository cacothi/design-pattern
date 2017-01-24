using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPatternAgg
{
	public class ShapeFactory
	{
		public IShape GetShape(String type)
		{
			if (type.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
				return new Circle();

			if (type.Equals("retangle", StringComparison.InvariantCultureIgnoreCase))
				return new Retangle();

			if (type.Equals("square", StringComparison.InvariantCultureIgnoreCase))
				return new Square();

			return null;

		}
	}
}
