using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

namespace RenderHeads.Media.AVProVideo.Demos
{
	public class VCR : MonoBehaviour
	{
		public MediaPlayer _mediaPlayer;
		public MediaPlayer _mediaPlayerB;
		public DisplayUGUI _mediaDisplay;
		public Slider _videoSeekSlider;
		public Slider _audioVolumeSlider;
		public Toggle _AutoStartToggle;
		public Toggle _MuteToggle;
		public MediaPlayer.FileLocation _location;
		public string _folder;
		public string[] _videoFiles;
	}
}
