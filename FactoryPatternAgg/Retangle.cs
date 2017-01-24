using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPatternAgg
{
	public class Retangle : IShape
	{
		public void Draw()
		{
			Console.WriteLine("Retangle.Draw");
		}
	}
}
