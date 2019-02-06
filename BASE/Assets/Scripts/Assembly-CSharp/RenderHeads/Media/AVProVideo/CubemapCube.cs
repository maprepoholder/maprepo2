using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public class CubemapCube : MonoBehaviour
	{
		[SerializeField]
		protected Material _material;
		[SerializeField]
		private MediaPlayer _mediaPlayer;
		[SerializeField]
		private float expansion_coeff;
	}
}
