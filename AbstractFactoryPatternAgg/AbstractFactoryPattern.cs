using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryPatternAgg
{
	public class AbstractFactoryPattern
	{

		///Abstract Factory patterns work around a super-factory which creates other factories. 
		///This factory is also called as factory of factories. 
		///This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
		///In Abstract Factory pattern an interface is responsible for creating a factory of related objects without explicitly specifying their classes.
		///Each generated factory can give the objects as per the Factory pattern.
		public static void Run()
		{
			var shapeFactory = FactoryProducer.GetFactory("shape");

			var circle = shapeFactory.GetShape("circle");
			circle.Draw();

			var retangle = shapeFactory.GetShape("retangle");
			retangle.Draw();

			var square = shapeFactory.GetShape("square");
			square.Draw();



			var colorFactory = FactoryProducer.GetFactory("color");

			var blue = colorFactory.GetColor("blue");
			blue.Fill();

			var red = colorFactory.GetColor("red");
			red.Fill();

			var green = colorFactory.GetColor("green");
			green.Fill();

		}
	}
}
