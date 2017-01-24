using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePatternAgg
{
	public class Square : Shape
	{
		public Square()
		{
			this.SetType("square");
		}

		public void Draw()
		{
			Console.WriteLine("Square.Draw()");
		}
	}
}
