using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public class VlcPlayer : IAdvancedMediaPlayer
	{
		public void PlayVlc(String fileName)
		{
			Console.WriteLine($"Playing Vlc file {fileName}");
		}

		public void PlayMp4(String fileName)
		{
			
		}
	}
}
