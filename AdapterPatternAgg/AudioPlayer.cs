using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public class AudioPlayer : IMediaPlayer
	{
		MediaPlayerAdapter MediaPlayerAdapter;

		public void Play(String audioType, String fileName)
		{
			if (audioType.Equals("mp3"))
				Console.WriteLine($"Playing mp3: {fileName}");
			else if(audioType.Equals("vlc") || audioType.Equals("mp4"))
			{
				MediaPlayerAdapter = new MediaPlayerAdapter(audioType);
				MediaPlayerAdapter.Play(audioType, fileName);
			} else
			{
				throw new Exception($"{audioType} invalid");
			}
		}
	}
}
