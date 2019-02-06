using UnityEngine;
using RenderHeads.Media.AVProVideo;

namespace RenderHeads.Media.AVProVideo.Demos
{
	public class FrameExtract : MonoBehaviour
	{
		public MediaPlayer _mediaPlayer;
		public bool _accurateSeek;
		public int _timeoutMs;
		public GUISkin _skin;
		public bool _asyncExtract;
		public bool _saveToJPG;
	}
}
