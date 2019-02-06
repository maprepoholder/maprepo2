using UnityEngine;

namespace BitBenderGames
{
	public class MobilePickingController : MonoBehaviour
	{
		[SerializeField]
		private bool snapToGrid;
		[SerializeField]
		private float snapUnitSize;
		[SerializeField]
		private Vector2 snapOffset;
		[SerializeField]
		private SnapAngle snapAngle;
		[SerializeField]
		private bool isMultiSelectionEnabled;
		[SerializeField]
		private bool requireLongTapForMove;
		[SerializeField]
		private UnityEventWithTransform OnPickableTransformSelected;
		[SerializeField]
		private UnityEventWithPickableSelected OnPickableTransformSelectedExtended;
		[SerializeField]
		private UnityEventWithTransform OnPickableTransformDeselected;
		[SerializeField]
		private UnityEventWithTransform OnPickableTransformMoveStarted;
		[SerializeField]
		private UnityEventWithTransform OnPickableTransformMoved;
		[SerializeField]
		private UnityEventWithPositionAndTransform OnPickableTransformMoveEnded;
		[SerializeField]
		private bool expertModeEnabled;
		[SerializeField]
		private bool deselectPreviousColliderOnClick;
		[SerializeField]
		private bool repeatEventSelectedOnClick;
		[SerializeField]
		private bool useLegacyTransformMovedEventOrder;
	}
}
