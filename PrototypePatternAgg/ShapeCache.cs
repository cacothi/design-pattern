using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePatternAgg
{
	public class ShapeCache
	{
		private static Dictionary<String, Shape> shapeMap { get; } = new Dictionary<String, Shape>();

		public static Shape GetShape(String shapeId)
		{
			Shape cachedShape;
			shapeMap.TryGetValue(shapeId, out cachedShape);
			return (Shape)cachedShape.Clone();
		}

		public static void LoadCache()
		{
			var circle = new Circle();
			circle.SetId("1");
			shapeMap.Add(circle.Id, circle);

			var square = new Square();
			square.SetId("2");
			shapeMap.Add(square.Id, square);

		}
	}
}
