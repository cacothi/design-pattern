using DesignPattern.AbstractFactoryPatternAgg;
using DesignPattern.AdapterPatternAgg;
using DesignPattern.BuilderPatternAgg;
using DesignPattern.FactoryPatternAgg;
using DesignPattern.PrototypePatternAgg;
using DesignPattern.SingletonPatternAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			//FactoryPattern.Run();

			//AbstractFactoryPattern.Run();

			//SingletonPattern.Run();

			//BuilderPattern.Run();

			//PrototypePattern.Run();

			AdapterPattern.Run();

			Console.ReadLine();
		}
	}
}
