using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public interface IMediaPlayer
	{
		void Play(String audioType, String fileName);
	}
}
