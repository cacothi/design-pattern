using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public class Red : IColor
	{
		public void Fill()
		{
			Console.WriteLine("Red.Fil()");
		}
	}
}
