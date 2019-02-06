using UnityEngine;

namespace BitBenderGames
{
	public class FocusCameraOnItem : MonoBehaviourWrapped
	{
		[SerializeField]
		private float transitionDuration;
		[SerializeField]
		private AnimationCurve transitionCurve;
	}
}
