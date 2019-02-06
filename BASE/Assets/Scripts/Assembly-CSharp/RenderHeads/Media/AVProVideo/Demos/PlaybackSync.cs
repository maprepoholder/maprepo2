using UnityEngine;
using RenderHeads.Media.AVProVideo;

namespace RenderHeads.Media.AVProVideo.Demos
{
	public class PlaybackSync : MonoBehaviour
	{
		public MediaPlayer _masterPlayer;
		public MediaPlayer[] _slavePlayers;
		public float _toleranceMs;
		public bool _matchVideo;
		public bool _muteSlaves;
	}
}
