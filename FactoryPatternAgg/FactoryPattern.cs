using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPatternAgg
{
	public static class FactoryPattern
	{
		public static void Run()
		{
			var shapeFactory = new ShapeFactory();

			var circle = shapeFactory.GetShape("circle");
			circle.Draw();

			var square = shapeFactory.GetShape("square");
			square.Draw();

			var retangle = shapeFactory.GetShape("retangle");
			retangle.Draw();

		}
	}
}
