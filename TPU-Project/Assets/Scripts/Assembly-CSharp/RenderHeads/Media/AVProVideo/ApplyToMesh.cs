using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class ApplyToMesh : MonoBehaviour
	{
		[SerializeField]
		private MediaPlayer _media;
		[SerializeField]
		private Texture2D _defaultTexture;
		[SerializeField]
		private Renderer _mesh;
		[SerializeField]
		private string _texturePropertyName;
		[SerializeField]
		private Vector2 _offset;
		[SerializeField]
		private Vector2 _scale;
	}
}
