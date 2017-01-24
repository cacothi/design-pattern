using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePatternAgg
{
	public class Shape : ICloneable
	{
		public String Id { get; private set; }

		public String Type { get; private set; }

		public void SetId(String id) => Id = id;

		public void SetType(String type) => Type = type;


		public Object Clone()
		{
			Object clone = null;
			try
			{
				clone = base.MemberwiseClone();
			}
			catch (Exception) 
			{
				throw;
			}
			return clone;
		}
	}
}
