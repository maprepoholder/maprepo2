using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class ApplyToMaterial : MonoBehaviour
	{
		public Vector2 _offset;
		public Vector2 _scale;
		public Material _material;
		public string _texturePropertyName;
		public MediaPlayer _media;
		public Texture2D _defaultTexture;
	}
}
