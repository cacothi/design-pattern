using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public abstract class AbstractFactory
	{
		public abstract IColor GetColor(String color);

		public abstract IShape GetShape(String shape);
	}
}
