using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public interface IItem
	{
		String Name { get; }

		IPacking Packing { get; }

		Double Price { get; }
	}
}
