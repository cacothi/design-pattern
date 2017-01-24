using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	public class MediaPlayerAdapter : IMediaPlayer
	{
		IAdvancedMediaPlayer AdvancedMusicPlayer;

		public MediaPlayerAdapter(String audioType)
		{
			if (audioType.Equals("vlc"))
				AdvancedMusicPlayer = new VlcPlayer();

			if (audioType.Equals("mp4"))
				AdvancedMusicPlayer = new Mp4Player();
		}

		public void Play(String audioType, String fileName)
		{

			if (audioType.Equals("vlc"))
				AdvancedMusicPlayer.PlayVlc(fileName);

			if (audioType.Equals("mp4"))
				AdvancedMusicPlayer.PlayMp4(fileName);
		}
	}
}
