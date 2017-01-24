using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	/// <summary>
	/// Builder pattern builds a complex object using simple objects and using a step by step approach. 
	/// This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	///
	/// A Builder class builds the final object step by step.This builder is independent of other objects.
	/// </summary>
	public class BuilderPattern
	{
		public static void Run()
		{
			var vegMeal = MealBuilder.PrepareVegMeal();
			Console.WriteLine("Veggie Meal");
			vegMeal.ShowItems();
			Console.WriteLine($"Total Cost: {vegMeal.GetCost()}");

			Console.WriteLine("");

			var chicken = MealBuilder.PrepareChickenMeal();
			Console.WriteLine("Chicken Meal");
			chicken.ShowItems();
			Console.WriteLine($"Total Cost: {chicken.GetCost()}");
		}
	}
}
