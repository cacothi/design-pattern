using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public class FactoryProducer
	{
		public static AbstractFactory GetFactory(String choice)
		{
			if (choice.Equals("shape", StringComparison.InvariantCultureIgnoreCase))
				return new ShapeFactory();

			if (choice.Equals("color", StringComparison.InvariantCultureIgnoreCase))
				return new ColorFactory();

			return null;
		}
	}
}
