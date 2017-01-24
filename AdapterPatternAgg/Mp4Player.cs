using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public class Mp4Player : IAdvancedMediaPlayer
	{
		public void PlayVlc(String fileName)
		{
			
		}

		public void PlayMp4(String fileName)
		{
			Console.WriteLine($"Playing Mp4 file {fileName}");
		}
	}
}
