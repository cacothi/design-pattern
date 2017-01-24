using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class MealBuilder
	{
		public static Meal PrepareVegMeal()
		{
			var meal = new Meal().AddItem(new VegBurger())
								 .AddItem(new Coke())
								 ;
			return meal;
		}

		public static Meal PrepareChickenMeal()
		{
			var meal = new Meal().AddItem(new ChickenBurger())
								 .AddItem(new Pepsi())
								 ;
			return meal;
		}
	}
}
