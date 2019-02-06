using UnityEngine;
using RenderHeads.Media.AVProVideo;

namespace RenderHeads.Media.AVProVideo.Demos
{
	public class SimpleController : MonoBehaviour
	{
		public string _folder;
		public string[] _filenames;
		public string[] _streams;
		public MediaPlayer _mediaPlayer;
		public DisplayIMGUI _display;
		public GUISkin _guiSkin;
		public bool _useFading;
	}
}
