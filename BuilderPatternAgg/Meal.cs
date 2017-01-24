using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPatternAgg
{
	public class Meal
	{
		private List<IItem> Items { get; set; } = new List<IItem>();

		public Meal AddItem(IItem item)
		{
			Items.Add(item);

			//Using the method Fluently
			return this;
		}

		public Double GetCost() => Items.Sum(x => x.Price);

		public void ShowItems() => Items.ForEach(x =>
		{
			Console.WriteLine(x.ToString());
		});
	}
}
