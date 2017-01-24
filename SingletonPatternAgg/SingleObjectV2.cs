using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPatternAgg
{
	public class SingleObjectV2
	{

		private static SingleObjectV2 _singleObjectV2 { get; set; }

		public static SingleObjectV2 Instance
		{
			get
			{
				if (_singleObjectV2 == null)
				{
					_singleObjectV2 = new SingleObjectV2();
				}
				return _singleObjectV2;
			}
		}

		public SingleObjectV2()
		{

		}

		public void ShowMessage()
		{
			Console.WriteLine("SingleObjectV2.ShowMessage");
		}
	}
}
