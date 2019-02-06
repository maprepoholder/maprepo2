using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class DisplayIMGUI : MonoBehaviour
	{
		public MediaPlayer _mediaPlayer;
		public bool _displayInEditor;
		public ScaleMode _scaleMode;
		public Color _color;
		public bool _alphaBlend;
		[SerializeField]
		private bool _useDepth;
		public int _depth;
		public bool _fullScreen;
		public float _x;
		public float _y;
		public float _width;
		public float _height;
	}
}
