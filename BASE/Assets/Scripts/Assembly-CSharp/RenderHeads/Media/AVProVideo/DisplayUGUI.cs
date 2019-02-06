using UnityEngine.UI;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class DisplayUGUI : MaskableGraphic
	{
		[SerializeField]
		public MediaPlayer _mediaPlayer;
		[SerializeField]
		public Rect m_UVRect;
		[SerializeField]
		public bool _setNativeSize;
		[SerializeField]
		public ScaleMode _scaleMode;
		[SerializeField]
		public bool _noDefaultDisplay;
		[SerializeField]
		public bool _displayInEditor;
		[SerializeField]
		public Texture _defaultTexture;
	}
}
