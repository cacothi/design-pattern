using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPatternAgg
{
	/// <summary>
	/// Adapter pattern works as a bridge between two incompatible interfaces. 
	/// This type of design pattern comes under structural pattern as this pattern combines the capability of two independent interfaces.
	/// 
	/// This pattern involves a single class which is responsible to join functionalities of independent or incompatible interfaces.
	/// A real life example could be a case of card reader which acts as an adapter between memory card and a laptop.
	/// You plugin the memory card into card reader and card reader into the laptop so that memory card can be read via laptop.
	/// 
	/// We are demonstrating use of Adapter pattern via following example in which an audio player device can play mp3 files only and 
	/// wants to use an advanced audio player capable of playing vlc and mp4 files.   
	/// </summary>
	public class AdapterPattern
	{
		public static void Run()
		{
			var audioPlayer = new AudioPlayer();
			audioPlayer.Play("mp3", "MP3 file");
			audioPlayer.Play("mp4", "MP4 file");
			audioPlayer.Play("vlc", "VLC file");
		}
	}
}
