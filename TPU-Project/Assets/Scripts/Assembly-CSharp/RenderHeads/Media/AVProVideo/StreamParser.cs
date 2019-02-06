using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class StreamParser : MonoBehaviour
	{
		public enum StreamType
		{
			HLS = 0,
		}

		public string _url;
		public StreamType _streamType;
		public bool _autoLoad;
	}
}
