using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public interface IAdvancedMediaPlayer
	{
		void PlayVlc(String fileName);
		void PlayMp4(String fileName);
	}
}
