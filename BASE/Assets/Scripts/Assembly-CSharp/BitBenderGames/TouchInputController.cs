using UnityEngine;

namespace BitBenderGames
{
	public class TouchInputController : MonoBehaviour
	{
		[SerializeField]
		private bool expertModeEnabled;
		[SerializeField]
		private float clickDurationThreshold;
		[SerializeField]
		private float doubleclickDurationThreshold;
		[SerializeField]
		private float tiltMoveDotTreshold;
		[SerializeField]
		private float tiltHorizontalDotThreshold;
		[SerializeField]
		private float dragStartDistanceThresholdRelative;
		[SerializeField]
		private bool longTapStartsDrag;
	}
}
