using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class AudioOutput : MonoBehaviour
	{
		public enum AudioOutputMode
		{
			Single = 0,
			Multiple = 1,
		}

		public AudioOutputMode _audioOutputMode;
		[SerializeField]
		private MediaPlayer _mediaPlayer;
		public int _channelMask;
	}
}
