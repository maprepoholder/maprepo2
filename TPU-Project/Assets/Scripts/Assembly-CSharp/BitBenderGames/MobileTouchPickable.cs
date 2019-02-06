using UnityEngine;

namespace BitBenderGames
{
	public class MobileTouchPickable : MonoBehaviour
	{
		[SerializeField]
		private Transform pickableTransform;
		[SerializeField]
		private Vector2 localSnapOffset;
	}
}
