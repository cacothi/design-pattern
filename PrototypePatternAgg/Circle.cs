using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePatternAgg
{
	public class Circle : Shape
	{
		public Circle()
		{
			this.SetType("circle");
		}

		public void Draw()
		{
			Console.WriteLine("Circle.Draw()");
		}
	}
}
