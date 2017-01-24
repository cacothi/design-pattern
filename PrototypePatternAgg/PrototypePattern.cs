using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePatternAgg
{ 
	/// <summary>
	/// Prototype pattern refers to creating duplicate object while keeping performance in mind. 
	/// This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
	///
	/// This pattern involves implementing a prototype interface which tells to create a clone of the current object. 
	/// This pattern is used when creation of object directly is costly.
	/// For example, an object is to be created after a costly database operation.
	/// We can cache the object, returns its clone on next request and update the database as and when needed thus reducing database calls.
	/// </summary>
	public class PrototypePattern
	{
		public static void Run()
		{
			ShapeCache.LoadCache();

			var clonedShape1 = ShapeCache.GetShape("1");
			Console.WriteLine($"Shape: {clonedShape1.Type}");

			var clonedShape2 = ShapeCache.GetShape("2");
			Console.WriteLine($"Shape: {clonedShape2.Type}");
		}
	}
}
